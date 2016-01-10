﻿using System;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Threading;
using PSExt.Host;

namespace PSExt
{
	/// <summary>
	///     A sample implementation of the PSHost abstract class for console
	///     applications. Not all members are implemented. Those that are not
	///     implemented throw a NotImplementedException exception.
	/// </summary>
	internal class DbgPsHost : PSHost, IHostSupportsInteractiveSession
	{
		/// <summary>
		///     The identifier of this instance of the host implementation.
		/// </summary>
		private static readonly Guid instanceId = Guid.NewGuid();

		private readonly IDebugger _debugger;

		/// <summary>
		///     A reference to the implementation of the PSHostUserInterface
		///     class for this application.
		/// </summary>
		private readonly HostUserInterface _hostUserInterface;

		/// <summary>
		///     A reference to the listener.
		/// </summary>
		private readonly IProgram _program;


		/// <summary>
		///     A reference to the runspace used to start an interactive session.
		/// </summary>
		public Runspace PushedRunspace;

		public DbgPsHost(IDebugger debugger, IProgram progam)
		{
			_debugger = debugger;
			_program = progam;
			_hostUserInterface = new HostUserInterface(_debugger);
		}

		/// <summary>
		///     Gets the culture information to use. This implementation takes a
		///     snapshot of the culture information of the thread that created
		///     this object.
		/// </summary>
		public override CultureInfo CurrentCulture { get; } = Thread.CurrentThread.CurrentCulture;

		/// <summary>
		///     Gets the UI culture information to use. This implementation takes
		///     snapshot of the UI culture information of the thread that created
		///     this object.
		/// </summary>
		public override CultureInfo CurrentUICulture { get; } = Thread.CurrentThread.CurrentUICulture;

		/// <summary>
		///     Gets the identifier of this instance of the host implementation.
		///     This implementation always returns the GUID allocated at
		///     instantiation time.
		/// </summary>
		public override Guid InstanceId => instanceId;

		/// <summary>
		///     Gets the name of the host implementation. This string may be used
		///     by script writers to identify when this host is being used.
		/// </summary>
		public override string Name { get; } = "MySampleConsoleHostImplementation";

		/// <summary>
		///     Gets an instance of the implementation of the PSHostUserInterface class
		///     for this application. This instance is allocated once at startup time
		///     and returned every time thereafter.
		/// </summary>
		public override PSHostUserInterface UI => _hostUserInterface;

		/// <summary>
		///     Gets the version object for this host application. Typically
		///     this should match the version resource in the application.
		/// </summary>
		public override Version Version => new Version(1, 0, 0, 0);

		/// <summary>
		///     Instructs the host to interrupt the currently running pipeline
		///     and start a new nested input loop. Not implemented by this example class.
		///     The call fails with an exception.
		/// </summary>
		public override void EnterNestedPrompt()
		{
			throw new NotImplementedException(
				"Cannot suspend the shell, EnterNestedPrompt() method is not implemented by MyHost.");
		}

		/// <summary>
		///     Instructs the host to exit the currently running input loop. Not
		///     implemented by this example class. The call fails with an
		///     exception.
		/// </summary>
		public override void ExitNestedPrompt()
		{
			throw new NotImplementedException("The ExitNestedPrompt() method is not implemented by MyHost.");
		}

		/// <summary>
		///     Notifies the host that the Windows PowerShell runtime is about to
		///     execute a legacy command-line application. Typically it is used
		///     to restore state that was changed by a child process after the
		///     child exits. This implementation does nothing and simply returns.
		/// </summary>
		public override void NotifyBeginApplication()
		{
		}

		/// <summary>
		///     Notifies the host that the Windows PowerShell engine has
		///     completed the execution of a legacy command. Typically it
		///     is used to restore state that was changed by a child process
		///     after the child exits. This implementation does nothing and
		///     simply returns.
		/// </summary>
		public override void NotifyEndApplication()
		{
		}

		/// <summary>
		///     Indicate to the host application that exit has
		///     been requested. Pass the exit code that the host
		///     application should use when exiting the process.
		/// </summary>
		/// <param name="exitCode">
		///     The exit code that the
		///     host application should use.
		/// </param>
		public override void SetShouldExit(int exitCode)
		{
			_program.ShouldExit = true;
			_program.ExitCode = exitCode;
		}

		#region IHostSupportsInteractiveSession Properties

		/// <summary>
		///     Gets a value indicating whether a request
		///     to open a PSSession has been made.
		/// </summary>
		public bool IsRunspacePushed => PushedRunspace != null;

		/// <summary>
		///     Gets or sets the runspace used by the PSSession.
		/// </summary>
		public Runspace Runspace { get; internal set; }

		#endregion IHostSupportsInteractiveSession Properties

		#region IHostSupportsInteractiveSession Methods

		/// <summary>
		///     Requests to close a PSSession.
		/// </summary>
		public void PopRunspace()
		{
			Runspace = PushedRunspace;
			PushedRunspace = null;
		}

		/// <summary>
		///     Requests to open a PSSession.
		/// </summary>
		/// <param name="runspace">Runspace to use.</param>
		public void PushRunspace(Runspace runspace)
		{
			PushedRunspace = Runspace;
			Runspace = runspace;
		}

		#endregion IHostSupportsInteractiveSession Methods
	}
}