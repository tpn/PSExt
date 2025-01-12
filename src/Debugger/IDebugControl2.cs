﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace Microsoft.Diagnostics.Runtime.Interop
{
	[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("d4366723-44df-4bed-8c7e-4c05424f4588")]
	public interface IDebugControl2 : IDebugControl
	{
		/* IDebugControl */

		[PreserveSig]
		new int GetInterrupt();

		[PreserveSig]
		new int SetInterrupt(
			[In] DEBUG_INTERRUPT Flags);

		[PreserveSig]
		new int GetInterruptTimeout(
			[Out] out uint Seconds);

		[PreserveSig]
		new int SetInterruptTimeout(
			[In] uint Seconds);

		[PreserveSig]
		new int GetLogFile(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint FileSize,
			[Out, MarshalAs(UnmanagedType.Bool)] out bool Append);

		[PreserveSig]
		new int OpenLogFile(
			[In, MarshalAs(UnmanagedType.LPStr)] string File,
			[In, MarshalAs(UnmanagedType.Bool)] bool Append);

		[PreserveSig]
		new int CloseLogFile();

		[PreserveSig]
		new int GetLogMask(
			[Out] out DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int SetLogMask(
			[In] DEBUG_OUTPUT Mask);

		[PreserveSig]
		new int Input(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint InputSize);

		[PreserveSig]
		new int ReturnInput(
			[In, MarshalAs(UnmanagedType.LPStr)] string Buffer);

		[PreserveSig]
		new int Output(
			[In] DEBUG_OUTPUT Mask,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format);

		[PreserveSig]
		new int OutputVaList( /* THIS SHOULD NEVER BE CALLED FROM C# */
			[In] DEBUG_OUTPUT Mask,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format,
			[In] IntPtr va_list_Args);

		[PreserveSig]
		new int ControlledOutput(
			[In] DEBUG_OUTCTL OutputControl,
			[In] DEBUG_OUTPUT Mask,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format);

		[PreserveSig]
		new int ControlledOutputVaList( /* THIS SHOULD NEVER BE CALLED FROM C# */
			[In] DEBUG_OUTCTL OutputControl,
			[In] DEBUG_OUTPUT Mask,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format,
			[In] IntPtr va_list_Args);

		[PreserveSig]
		new int OutputPrompt(
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format);

		[PreserveSig]
		new int OutputPromptVaList( /* THIS SHOULD NEVER BE CALLED FROM C# */
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPStr)] string Format,
			[In] IntPtr va_list_Args);

		[PreserveSig]
		new int GetPromptText(
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint TextSize);

		[PreserveSig]
		new int OutputCurrentState(
			[In] DEBUG_OUTCTL OutputControl,
			[In] DEBUG_CURRENT Flags);

		[PreserveSig]
		new int OutputVersionInformation(
			[In] DEBUG_OUTCTL OutputControl);

		[PreserveSig]
		new int GetNotifyEventHandle(
			[Out] out ulong Handle);

		[PreserveSig]
		new int SetNotifyEventHandle(
			[In] ulong Handle);

		[PreserveSig]
		new int Assemble(
			[In] ulong Offset,
			[In, MarshalAs(UnmanagedType.LPStr)] string Instr,
			[Out] out ulong EndOffset);

		[PreserveSig]
		new int Disassemble(
			[In] ulong Offset,
			[In] DEBUG_DISASM Flags,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint DisassemblySize,
			[Out] out ulong EndOffset);

		[PreserveSig]
		new int GetDisassembleEffectiveOffset(
			[Out] out ulong Offset);

		[PreserveSig]
		new int OutputDisassembly(
			[In] DEBUG_OUTCTL OutputControl,
			[In] ulong Offset,
			[In] DEBUG_DISASM Flags,
			[Out] out ulong EndOffset);

		[PreserveSig]
		new int OutputDisassemblyLines(
			[In] DEBUG_OUTCTL OutputControl,
			[In] uint PreviousLines,
			[In] uint TotalLines,
			[In] ulong Offset,
			[In] DEBUG_DISASM Flags,
			[Out] out uint OffsetLine,
			[Out] out ulong StartOffset,
			[Out] out ulong EndOffset,
			[Out, MarshalAs(UnmanagedType.LPArray)] ulong[] LineOffsets);

		[PreserveSig]
		new int GetNearInstruction(
			[In] ulong Offset,
			[In] int Delta,
			[Out] out ulong NearOffset);

		[PreserveSig]
		new int GetStackTrace(
			[In] ulong FrameOffset,
			[In] ulong StackOffset,
			[In] ulong InstructionOffset,
			[Out, MarshalAs(UnmanagedType.LPArray)] DEBUG_STACK_FRAME[] Frames,
			[In] int FrameSize,
			[Out] out uint FramesFilled);

		[PreserveSig]
		new int GetReturnOffset(
			[Out] out ulong Offset);

		[PreserveSig]
		new int OutputStackTrace(
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPArray)] DEBUG_STACK_FRAME[] Frames,
			[In] int FramesSize,
			[In] DEBUG_STACK Flags);

		[PreserveSig]
		new int GetDebuggeeType(
			[Out] out DEBUG_CLASS Class,
			[Out] out DEBUG_CLASS_QUALIFIER Qualifier);

		[PreserveSig]
		new int GetActualProcessorType(
			[Out] out IMAGE_FILE_MACHINE Type);

		[PreserveSig]
		new int GetExecutingProcessorType(
			[Out] out IMAGE_FILE_MACHINE Type);

		[PreserveSig]
		new int GetNumberPossibleExecutingProcessorTypes(
			[Out] out uint Number);

		[PreserveSig]
		new int GetPossibleExecutingProcessorTypes(
			[In] uint Start,
			[In] uint Count,
			[Out, MarshalAs(UnmanagedType.LPArray)] IMAGE_FILE_MACHINE[] Types);

		[PreserveSig]
		new int GetNumberProcessors(
			[Out] out uint Number);

		[PreserveSig]
		new int GetSystemVersion(
			[Out] out uint PlatformId,
			[Out] out uint Major,
			[Out] out uint Minor,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder ServicePackString,
			[In] int ServicePackStringSize,
			[Out] out uint ServicePackStringUsed,
			[Out] out uint ServicePackNumber,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder BuildString,
			[In] int BuildStringSize,
			[Out] out uint BuildStringUsed);

		[PreserveSig]
		new int GetPageSize(
			[Out] out uint Size);

		[PreserveSig]
		new int IsPointer64Bit();

		[PreserveSig]
		new int ReadBugCheckData(
			[Out] out uint Code,
			[Out] out ulong Arg1,
			[Out] out ulong Arg2,
			[Out] out ulong Arg3,
			[Out] out ulong Arg4);

		[PreserveSig]
		new int GetNumberSupportedProcessorTypes(
			[Out] out uint Number);

		[PreserveSig]
		new int GetSupportedProcessorTypes(
			[In] uint Start,
			[In] uint Count,
			[Out, MarshalAs(UnmanagedType.LPArray)] IMAGE_FILE_MACHINE[] Types);

		[PreserveSig]
		new int GetProcessorTypeNames(
			[In] IMAGE_FILE_MACHINE Type,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder FullNameBuffer,
			[In] int FullNameBufferSize,
			[Out] out uint FullNameSize,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder AbbrevNameBuffer,
			[In] int AbbrevNameBufferSize,
			[Out] out uint AbbrevNameSize);

		[PreserveSig]
		new int GetEffectiveProcessorType(
			[Out] out IMAGE_FILE_MACHINE Type);

		[PreserveSig]
		new int SetEffectiveProcessorType(
			[In] IMAGE_FILE_MACHINE Type);

		[PreserveSig]
		new int GetExecutionStatus(
			[Out] out DEBUG_STATUS Status);

		[PreserveSig]
		new int SetExecutionStatus(
			[In] DEBUG_STATUS Status);

		[PreserveSig]
		new int GetCodeLevel(
			[Out] out DEBUG_LEVEL Level);

		[PreserveSig]
		new int SetCodeLevel(
			[In] DEBUG_LEVEL Level);

		[PreserveSig]
		new int GetEngineOptions(
			[Out] out DEBUG_ENGOPT Options);

		[PreserveSig]
		new int AddEngineOptions(
			[In] DEBUG_ENGOPT Options);

		[PreserveSig]
		new int RemoveEngineOptions(
			[In] DEBUG_ENGOPT Options);

		[PreserveSig]
		new int SetEngineOptions(
			[In] DEBUG_ENGOPT Options);

		[PreserveSig]
		new int GetSystemErrorControl(
			[Out] out ERROR_LEVEL OutputLevel,
			[Out] out ERROR_LEVEL BreakLevel);

		[PreserveSig]
		new int SetSystemErrorControl(
			[In] ERROR_LEVEL OutputLevel,
			[In] ERROR_LEVEL BreakLevel);

		[PreserveSig]
		new int GetTextMacro(
			[In] uint Slot,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint MacroSize);

		[PreserveSig]
		new int SetTextMacro(
			[In] uint Slot,
			[In, MarshalAs(UnmanagedType.LPStr)] string Macro);

		[PreserveSig]
		new int GetRadix(
			[Out] out uint Radix);

		[PreserveSig]
		new int SetRadix(
			[In] uint Radix);

		[PreserveSig]
		new int Evaluate(
			[In, MarshalAs(UnmanagedType.LPStr)] string Expression,
			[In] DEBUG_VALUE_TYPE DesiredType,
			[Out] out DEBUG_VALUE Value,
			[Out] out uint RemainderIndex);

		[PreserveSig]
		new int CoerceValue(
			[In] DEBUG_VALUE In,
			[In] DEBUG_VALUE_TYPE OutType,
			[Out] out DEBUG_VALUE Out);

		[PreserveSig]
		new int CoerceValues(
			[In] uint Count,
			[In, MarshalAs(UnmanagedType.LPArray)] DEBUG_VALUE[] In,
			[In, MarshalAs(UnmanagedType.LPArray)] DEBUG_VALUE_TYPE[] OutType,
			[Out, MarshalAs(UnmanagedType.LPArray)] DEBUG_VALUE[] Out);

		[PreserveSig]
		new int Execute(
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPStr)] string Command,
			[In] DEBUG_EXECUTE Flags);

		[PreserveSig]
		new int ExecuteCommandFile(
			[In] DEBUG_OUTCTL OutputControl,
			[In, MarshalAs(UnmanagedType.LPStr)] string CommandFile,
			[In] DEBUG_EXECUTE Flags);

		[PreserveSig]
		new int GetNumberBreakpoints(
			[Out] out uint Number);

		[PreserveSig]
		new int GetBreakpointByIndex(
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.Interface)] out IDebugBreakpoint bp);

		[PreserveSig]
		new int GetBreakpointById(
			[In] uint Id,
			[Out, MarshalAs(UnmanagedType.Interface)] out IDebugBreakpoint bp);

		[PreserveSig]
		new int GetBreakpointParameters(
			[In] uint Count,
			[In, MarshalAs(UnmanagedType.LPArray)] uint[] Ids,
			[In] uint Start,
			[Out, MarshalAs(UnmanagedType.LPArray)] DEBUG_BREAKPOINT_PARAMETERS[] Params);

		[PreserveSig]
		new int AddBreakpoint(
			[In] DEBUG_BREAKPOINT_TYPE Type,
			[In] uint DesiredId,
			[Out, MarshalAs(UnmanagedType.Interface)] out IDebugBreakpoint Bp);

		[PreserveSig]
		new int RemoveBreakpoint(
			[In, MarshalAs(UnmanagedType.Interface)] IDebugBreakpoint Bp);

		[PreserveSig]
		new int AddExtension(
			[In, MarshalAs(UnmanagedType.LPStr)] string Path,
			[In] uint Flags,
			[Out] out ulong Handle);

		[PreserveSig]
		new int RemoveExtension(
			[In] ulong Handle);

		[PreserveSig]
		new int GetExtensionByPath(
			[In, MarshalAs(UnmanagedType.LPStr)] string Path,
			[Out] out ulong Handle);

		[PreserveSig]
		new int CallExtension(
			[In] ulong Handle,
			[In, MarshalAs(UnmanagedType.LPStr)] string Function,
			[In, MarshalAs(UnmanagedType.LPStr)] string Arguments);

		[PreserveSig]
		new int GetExtensionFunction(
			[In] ulong Handle,
			[In, MarshalAs(UnmanagedType.LPStr)] string FuncName,
			[Out] out IntPtr Function);

		[PreserveSig]
		new int GetWindbgExtensionApis32(
			[In, Out] ref WINDBG_EXTENSION_APIS Api);

		/* Must be In and Out as the nSize member has to be initialized */

		[PreserveSig]
		new int GetWindbgExtensionApis64(
			[In, Out] ref WINDBG_EXTENSION_APIS Api);

		/* Must be In and Out as the nSize member has to be initialized */

		[PreserveSig]
		new int GetNumberEventFilters(
			[Out] out uint SpecificEvents,
			[Out] out uint SpecificExceptions,
			[Out] out uint ArbitraryExceptions);

		[PreserveSig]
		new int GetEventFilterText(
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint TextSize);

		[PreserveSig]
		new int GetEventFilterCommand(
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint CommandSize);

		[PreserveSig]
		new int SetEventFilterCommand(
			[In] uint Index,
			[In, MarshalAs(UnmanagedType.LPStr)] string Command);

		[PreserveSig]
		new int GetSpecificFilterParameters(
			[In] uint Start,
			[In] uint Count,
			[Out, MarshalAs(UnmanagedType.LPArray)] DEBUG_SPECIFIC_FILTER_PARAMETERS[] Params);

		[PreserveSig]
		new int SetSpecificFilterParameters(
			[In] uint Start,
			[In] uint Count,
			[In, MarshalAs(UnmanagedType.LPArray)] DEBUG_SPECIFIC_FILTER_PARAMETERS[] Params);

		[PreserveSig]
		new int GetSpecificEventFilterArgument(
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint ArgumentSize);

		[PreserveSig]
		new int SetSpecificEventFilterArgument(
			[In] uint Index,
			[In, MarshalAs(UnmanagedType.LPStr)] string Argument);

		[PreserveSig]
		new int GetExceptionFilterParameters(
			[In] uint Count,
			[In, MarshalAs(UnmanagedType.LPArray)] uint[] Codes,
			[In] uint Start,
			[Out, MarshalAs(UnmanagedType.LPArray)] DEBUG_EXCEPTION_FILTER_PARAMETERS[] Params);

		[PreserveSig]
		new int SetExceptionFilterParameters(
			[In] uint Count,
			[In, MarshalAs(UnmanagedType.LPArray)] DEBUG_EXCEPTION_FILTER_PARAMETERS[] Params);

		[PreserveSig]
		new int GetExceptionFilterSecondCommand(
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Buffer,
			[In] int BufferSize,
			[Out] out uint CommandSize);

		[PreserveSig]
		new int SetExceptionFilterSecondCommand(
			[In] uint Index,
			[In, MarshalAs(UnmanagedType.LPStr)] string Command);

		[PreserveSig]
		new int WaitForEvent(
			[In] DEBUG_WAIT Flags,
			[In] uint Timeout);

		[PreserveSig]
		new int GetLastEventInformation(
			[Out] out DEBUG_EVENT Type,
			[Out] out uint ProcessId,
			[Out] out uint ThreadId,
			[In] IntPtr ExtraInformation,
			[In] uint ExtraInformationSize,
			[Out] out uint ExtraInformationUsed,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder Description,
			[In] int DescriptionSize,
			[Out] out uint DescriptionUsed);

		/* IDebugControl2 */

		[PreserveSig]
		int GetCurrentTimeDate(
			[Out] out uint TimeDate);

		[PreserveSig]
		int GetCurrentSystemUpTime(
			[Out] out uint UpTime);

		[PreserveSig]
		int GetDumpFormatFlags(
			[Out] out DEBUG_FORMAT FormatFlags);

		[PreserveSig]
		int GetNumberTextReplacements(
			[Out] out uint NumRepl);

		[PreserveSig]
		int GetTextReplacement(
			[In, MarshalAs(UnmanagedType.LPStr)] string SrcText,
			[In] uint Index,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder SrcBuffer,
			[In] int SrcBufferSize,
			[Out] out uint SrcSize,
			[Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder DstBuffer,
			[In] int DstBufferSize,
			[Out] out uint DstSize);

		[PreserveSig]
		int SetTextReplacement(
			[In, MarshalAs(UnmanagedType.LPStr)] string SrcText,
			[In, MarshalAs(UnmanagedType.LPStr)] string DstText);

		[PreserveSig]
		int RemoveTextReplacements();

		[PreserveSig]
		int OutputTextReplacements(
			[In] DEBUG_OUTCTL OutputControl,
			[In] DEBUG_OUT_TEXT_REPL Flags);
	}
}