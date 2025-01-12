﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Diagnostics.Runtime.Interop;
using PSExt.Host;
using RGiesecke.DllExport;

namespace PSExt.Extension
{
	public class DebuggerExtension
	{		
		public static IDebugClient DebugClient { get; private set; }

		private static IDebugger _debugger;
		private static IDebugger Debugger => _debugger ?? (_debugger = new DebuggerProxy(new Debugger(DebugClient), Dispatcher));

		private static DebuggerDispatcher _dispatcher;
		private static DebuggerDispatcher Dispatcher => _dispatcher ?? (_dispatcher = new DebuggerDispatcher());

		private static ExitManager _exitManager;
		private static ExitManager ExitManager => _exitManager ?? (_exitManager = new ExitManager());

		private static PSSession _powerShellSession;
		private static PSSession PowerShellSession => _powerShellSession;

		static bool _supportsConsole = false;

		private static bool InitApi(IntPtr ptrClient)
		{
			// On our first call to the API:
			//   1. Store a copy of IDebugClient in DebugClient.
			//   2. Replace Console's output stream to be the debugger window.
			//   3. Create an instance of DataTarget using the IDebugClient.
			if (DebugClient == null)
			{
				var client = Marshal.GetUniqueObjectForIUnknown(ptrClient);
				DebugClient = (IDebugClient) client;
				if (_powerShellSession == null)
				{					
					_powerShellSession = CreatePSSession(_supportsConsole);
				}
			}

			return true;
		}

		private static PSSession CreatePSSession(bool consoleSupport)
		{			
			
			if (consoleSupport)
			{
				return new ConsolePSSession(Debugger, new ConsoleHost(), Dispatcher);
			}
			var dbgPsHost = new DbgPsHost(Debugger, ExitManager);
			return new DbgEnginePSSession(Debugger, dbgPsHost, Dispatcher);
		}

		[DllExport("DebugExtensionInitialize")]
		public static int DebugExtensionInitialize(out uint version, out uint flags)
		{
			// Set the extension version to 1, which expects exports with this signature:
			//      void _stdcall function(IDebugClient *client, const char *args)
			version = DEBUG_EXTENSION_VERSION(1, 0);
			flags = 0;
			_supportsConsole = System.Diagnostics.Process.GetCurrentProcess()
				.ProcessName.StartsWith("cdb", StringComparison.OrdinalIgnoreCase);

			return 0;
		}

		[DllExport("DebugExtensionUninitialize")]		
		public static int DebugExtensionUninitialize()
		{
			PowerShellSession?.Dispose();			
			DebugClient = null;			
			return 0;
		}


		[DllExport("ps")]
		public static int PS(IntPtr client, [MarshalAs(UnmanagedType.LPStr)] string args)
		{
			// Must be the first thing in our extension.
			if (!InitApi(client))
				return -1;

			PowerShellSession.Invoke(args);
			return 0;
		}

		[DllExport("psi")]
		public static int PSI(IntPtr client, [MarshalAs(UnmanagedType.LPStr)] string args)
		{
			// Must be the first thing in our extension.
			if (!InitApi(client))
				return -1;

			if (!PowerShellSession.RunInteractive())
			{
				var ctrl = (IDebugControl5)DebugClient;
				ctrl.Output(DEBUG_OUTPUT.ERROR, "The host does not support interactive PowerShell sessions\r\n");
			}
			return 0;
		}

		[DllExport("help")]
		public static int Help(IntPtr client, [MarshalAs(UnmanagedType.LPStr)] string args)
		{
			var dbgClient = (IDebugClient) Marshal.GetUniqueObjectForIUnknown(client);
			var ctrl = (IDebugControl3) dbgClient;
			var help = @"
!ps <cmd> - Invokes PowerShell with the specified cmd.

            Example: !ps k | where BaseOfImage -gt 0x7fff45000000 

			";


			ctrl.Output(DEBUG_OUTPUT.NORMAL, help);
			if (!_supportsConsole)
			{
				return 0;
			}
			help = @"
!psi      - Starts an interactive PowerShell session.

";

			ctrl.Output(DEBUG_OUTPUT.NORMAL, help);
			return 0;
		}

		private static uint DEBUG_EXTENSION_VERSION(uint major, uint minor)
		{
			return ((major & 0xffff) << 16) | (minor & 0xffff);
		}

	}	
}