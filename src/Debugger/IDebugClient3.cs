﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace Microsoft.Diagnostics.Runtime.Interop
{
	[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("dd492d7f-71b8-4ad6-a8dc-1c887479ff91")]
	public interface IDebugClient3 : IDebugClient2
	{
		/* IDebugClient */

		[PreserveSig]
		new int AttachKernel(
			[In] DEBUG_ATTACH Flags,
			[In, MarshalAs(UnmanagedType.LPStr)] string ConnectOptions);

		[PreserveSig]
		new int GetKernelConnectionOptions(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint OptionsSize);

		[PreserveSig]
		new int SetKernelConnectionOptions(
			[In, MarshalAs(UnmanagedType.LPStr)] string Options);

		[PreserveSig]
		new int StartProcessServer(
			[In] DEBUG_CLASS Flags,
			[In, MarshalAs(UnmanagedType.LPStr)] string Options,
			[In] IntPtr Reserved);

		[PreserveSig]
		new int ConnectProcessServer(
			[In, MarshalAs(UnmanagedType.LPStr)] string RemoteOptions,
			[Out] out ulong Server);

		[PreserveSig]
		new int DisconnectProcessServer(
			[In] ulong Server);

		[PreserveSig]
		new int GetRunningProcessSystemIds(
			[In] ulong Server,
			[Out, MarshalAs(UnmanagedType.LPArray)] uint[] Ids,
			[In] uint Count,
			[Out] out uint ActualCount);

		[PreserveSig]
		new int GetRunningProcessSystemIdByExecutableName(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPStr)] string ExeName,
			[In] DEBUG_GET_PROC Flags,
			[Out] out uint Id);

		[PreserveSig]
		new int GetRunningProcessDescription(
			[In] ulong Server,
			[In] uint SystemId,
			[In] DEBUG_PROC_DESC Flags,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeName,
			[In] int ExeNameSize,
			[Out] out uint ActualExeNameSize,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Description,
			[In] int DescriptionSize,
			[Out] out uint ActualDescriptionSize);

		[PreserveSig]
		new int AttachProcess(
			[In] ulong Server,
			[In] uint ProcessID,
			[In] DEBUG_ATTACH AttachFlags);

		[PreserveSig]
		new int CreateProcess(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPStr)] string CommandLine,
			[In] DEBUG_CREATE_PROCESS Flags);

		[PreserveSig]
		new int CreateProcessAndAttach(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPStr)] string CommandLine,
			[In] DEBUG_CREATE_PROCESS Flags,
			[In] uint ProcessId,
			[In] DEBUG_ATTACH AttachFlags);

		[PreserveSig]
		new int GetProcessOptions(
			[Out] out DEBUG_PROCESS Options);

		[PreserveSig]
		new int AddProcessOptions(
			[In] DEBUG_PROCESS Options);

		[PreserveSig]
		new int RemoveProcessOptions(
			[In] DEBUG_PROCESS Options);

		[PreserveSig]
		new int SetProcessOptions(
			[In] DEBUG_PROCESS Options);

		[PreserveSig]
		new int OpenDumpFile(
			[In, MarshalAs(UnmanagedType.LPStr)] string DumpFile);

		[PreserveSig]
		new int WriteDumpFile(
			[In, MarshalAs(UnmanagedType.LPStr)] string DumpFile,
			[In] DEBUG_DUMP Qualifier);

		[PreserveSig]
		new int ConnectSession(
			[In] DEBUG_CONNECT_SESSION Flags,
			[In] uint HistoryLimit);

		[PreserveSig]
		new int StartServer(
			[In, MarshalAs(UnmanagedType.LPStr)] string Options);

		[PreserveSig]
		new int OutputServer(
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPStr)] string Machine,
			[In] DEBUG_SERVERS Flags);

		[PreserveSig]
		new int TerminateProcesses();

		[PreserveSig]
		new int DetachProcesses();

		[PreserveSig]
		new int EndSession(
			[In] DEBUG_END Flags);

		[PreserveSig]
		new int GetExitCode(
			[Out] out uint Code);

		[PreserveSig]
		new int DispatchCallbacks(
			[In] uint Timeout);

		[PreserveSig]
		new int ExitDispatch(
			[In, MarshalAs(UnmanagedType.Interface)] IDebugClient Client);

		[PreserveSig]
		new int CreateClient(
			[Out, MarshalAs(UnmanagedType.Interface)] out IDebugClient Client);

		[PreserveSig]
		new int GetInputCallbacks(
			[Out, MarshalAs(UnmanagedType.Interface)] out IDebugInputCallbacks Callbacks);

		[PreserveSig]
		new int SetInputCallbacks(
			[In, MarshalAs(UnmanagedType.Interface)] IDebugInputCallbacks Callbacks);

		/* GetOutputCallbacks could a conversion thunk from the debugger engine so we can't specify a specific interface */

		[PreserveSig]
		new int GetOutputCallbacks(
			[Out] out IDebugOutputCallbacks Callbacks);

		/* We may have to pass a debugger engine conversion thunk back in so we can't specify a specific interface */

		[PreserveSig]
		new int SetOutputCallbacks(
			[In] IDebugOutputCallbacks Callbacks);

		[PreserveSig]
		new int GetOutputMask(
			[Out] out DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int SetOutputMask(
			[In] DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int GetOtherOutputMask(
			[In, MarshalAs(UnmanagedType.Interface)] IDebugClient Client,
			[Out] out DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int SetOtherOutputMask(
			[In, MarshalAs(UnmanagedType.Interface)] IDebugClient Client,
			[In] DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int GetOutputWidth(
			[Out] out uint Columns);

		[PreserveSig]
		new int SetOutputWidth(
			[In] uint Columns);

		[PreserveSig]
		new int GetOutputLinePrefix(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint PrefixSize);

		[PreserveSig]
		new int SetOutputLinePrefix(
			[In, MarshalAs(UnmanagedType.LPStr)] string Prefix);

		[PreserveSig]
		new int GetIdentity(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint IdentitySize);

		[PreserveSig]
		new int OutputIdentity(
			[In] DEBUG_OUTCTL OutputControl,
			[In] uint Flags,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format);

		/* GetEventCallbacks could a conversion thunk from the debugger engine so we can't specify a specific interface */

		[PreserveSig]
		new int GetEventCallbacks(
			[Out] out IDebugEventCallbacks Callbacks);

		/* We may have to pass a debugger engine conversion thunk back in so we can't specify a specific interface */

		[PreserveSig]
		new int SetEventCallbacks(
			[In] IDebugEventCallbacks Callbacks);

		[PreserveSig]
		new int FlushCallbacks();

		/* IDebugClient2 */

		[PreserveSig]
		new int WriteDumpFile2(
			[In, MarshalAs(UnmanagedType.LPStr)] string DumpFile,
			[In] DEBUG_DUMP Qualifier,
			[In] DEBUG_FORMAT FormatFlags,
			[In, MarshalAs(UnmanagedType.LPStr)] string Comment);

		[PreserveSig]
		new int AddDumpInformationFile(
			[In, MarshalAs(UnmanagedType.LPStr)] string InfoFile,
			[In] DEBUG_DUMP_FILE Type);

		[PreserveSig]
		new int EndProcessServer(
			[In] ulong Server);

		[PreserveSig]
		new int WaitForProcessServerEnd(
			[In] uint Timeout);

		[PreserveSig]
		new int IsKernelDebuggerEnabled();

		[PreserveSig]
		new int TerminateCurrentProcess();

		[PreserveSig]
		new int DetachCurrentProcess();

		[PreserveSig]
		new int AbandonCurrentProcess();

		/* IDebugClient3 */

		[PreserveSig]
		int GetRunningProcessSystemIdByExecutableNameWide(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPWStr)] string ExeName,
			[In] DEBUG_GET_PROC Flags,
			[Out] out uint Id);

		[PreserveSig]
		int GetRunningProcessDescriptionWide(
			[In] ulong Server,
			[In] uint SystemId,
			[In] DEBUG_PROC_DESC Flags,
			[Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName,
			[In] int ExeNameSize,
			[Out] out uint ActualExeNameSize,
			[Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder Description,
			[In] int DescriptionSize,
			[Out] out uint ActualDescriptionSize);

		[PreserveSig]
		int CreateProcessWide(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPWStr)] string CommandLine,
			[In] DEBUG_CREATE_PROCESS CreateFlags);

		[PreserveSig]
		int CreateProcessAndAttachWide(
			[In] ulong Server,
			[In, MarshalAs(UnmanagedType.LPWStr)] string CommandLine,
			[In] DEBUG_CREATE_PROCESS CreateFlags,
			[In] uint ProcessId,
			[In] DEBUG_ATTACH AttachFlags);
	}
}