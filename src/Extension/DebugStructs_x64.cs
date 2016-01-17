using System;
using System.Runtime.InteropServices;
using Microsoft.Diagnostics.Runtime.Interop;

// ReSharper disable InconsistentNaming
namespace PSExt.Extension.x64
{


	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x28)]
	public struct ACTIVATION_CONTEXT_STACK
	{
		[FieldOffset(0x000)] public IntPtr ActiveFrame;
		[FieldOffset(0x008)] public LIST_ENTRY FrameListCache;
		[FieldOffset(0x018)] public uint Flags;
		[FieldOffset(0x01c)] public uint NextCookieSequenceNumber;
		[FieldOffset(0x020)] public uint StackId;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public struct CLIENT_ID
	{
		[FieldOffset(0x000)] public IntPtr UniqueProcess;
		[FieldOffset(0x008)] public IntPtr UniqueThread;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x18)]
	public struct CURDIR
	{
		[FieldOffset(0x000)] public UNICODE_STRING DosPath;
		[FieldOffset(0x010)] public IntPtr Handle;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public unsafe struct EXCEPTION_REGISTRATION_RECORD
	{
		[FieldOffset(0x000)] public IntPtr Next;
		[FieldOffset(0x008)] public IntPtr* Handler;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x4e8)]
	public unsafe struct GDI_TEB_BATCH
	{
		[FieldOffset(0x000)] public uint BitField;
		[FieldOffset(0x008)] public ulong HDC;
		[FieldOffset(0x010)] public fixed uint Buffer [310];


		public uint Offset => ((BitField & 0x7FFFFFFF) >> 0);
		public bool HasRenderingCommand => (BitField & 0x80000000) >> 31 == 1;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public struct LIST_ENTRY
	{
		[FieldOffset(0x000)] public IntPtr Flink;
		[FieldOffset(0x008)] public IntPtr Blink;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x38)]
	public struct NT_TIB
	{
		[FieldOffset(0x000)] public IntPtr ExceptionList;
		[FieldOffset(0x008)] public IntPtr StackBase;
		[FieldOffset(0x010)] public IntPtr StackLimit;
		[FieldOffset(0x018)] public IntPtr SubSystemTib;
		[FieldOffset(0x020)] public IntPtr FiberData;
		[FieldOffset(0x020)] public uint Version;
		[FieldOffset(0x028)] public IntPtr ArbitraryUserPointer;
		[FieldOffset(0x030)] public IntPtr Self;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x7a0)]
	public unsafe struct PEB
	{
		[FieldOffset(0x000)] public byte InheritedAddressSpace;
		[FieldOffset(0x001)] public byte ReadImageFileExecOptions;
		[FieldOffset(0x002)] public byte BeingDebugged;
		[FieldOffset(0x003)] public byte BitField;
		[FieldOffset(0x004)] public fixed byte Padding0 [4];
		[FieldOffset(0x008)] public IntPtr Mutant;
		[FieldOffset(0x010)] public IntPtr ImageBaseAddress;
		[FieldOffset(0x018)] public IntPtr Ldr;
		[FieldOffset(0x020)] public IntPtr ProcessParameters;
		[FieldOffset(0x028)] public IntPtr SubSystemData;
		[FieldOffset(0x030)] public IntPtr ProcessHeap;
		[FieldOffset(0x038)] public IntPtr FastPebLock;
		[FieldOffset(0x040)] public IntPtr AtlThunkSListPtr;
		[FieldOffset(0x048)] public IntPtr IFEOKey;
		[FieldOffset(0x050)] public uint CrossProcessFlags;
		[FieldOffset(0x054)] public fixed byte Padding1 [4];
		[FieldOffset(0x058)] public IntPtr KernelCallbackTable;
		[FieldOffset(0x058)] public IntPtr UserSharedInfoPtr;
		[FieldOffset(0x060)] public fixed uint SystemReserved [1];
		[FieldOffset(0x064)] public uint AtlThunkSListPtr32;
		[FieldOffset(0x068)] public IntPtr ApiSetMap;
		[FieldOffset(0x070)] public uint TlsExpansionCounter;
		[FieldOffset(0x074)] public fixed byte Padding2 [4];
		[FieldOffset(0x078)] public IntPtr TlsBitmap;
		[FieldOffset(0x080)] public fixed uint TlsBitmapBits [2];
		[FieldOffset(0x088)] public IntPtr ReadOnlySharedMemoryBase;
		[FieldOffset(0x090)] public IntPtr SparePvoid0;
		[FieldOffset(0x098)] public IntPtr ReadOnlyStaticServerData;
		[FieldOffset(0x0a0)] public IntPtr AnsiCodePageData;
		[FieldOffset(0x0a8)] public IntPtr OemCodePageData;
		[FieldOffset(0x0b0)] public IntPtr UnicodeCaseTableData;
		[FieldOffset(0x0b8)] public uint NumberOfProcessors;
		[FieldOffset(0x0bc)] public uint NtGlobalFlag;
		[FieldOffset(0x0c0)] public long CriticalSectionTimeout;
		[FieldOffset(0x0c8)] public ulong HeapSegmentReserve;
		[FieldOffset(0x0d0)] public ulong HeapSegmentCommit;
		[FieldOffset(0x0d8)] public ulong HeapDeCommitTotalFreeThreshold;
		[FieldOffset(0x0e0)] public ulong HeapDeCommitFreeBlockThreshold;
		[FieldOffset(0x0e8)] public uint NumberOfHeaps;
		[FieldOffset(0x0ec)] public uint MaximumNumberOfHeaps;
		[FieldOffset(0x0f0)] public IntPtr ProcessHeaps;
		[FieldOffset(0x0f8)] public IntPtr GdiSharedHandleTable;
		[FieldOffset(0x100)] public IntPtr ProcessStarterHelper;
		[FieldOffset(0x108)] public uint GdiDCAttributeList;
		[FieldOffset(0x10c)] public fixed byte Padding3 [4];
		[FieldOffset(0x110)] public IntPtr LoaderLock;
		[FieldOffset(0x118)] public uint OSMajorVersion;
		[FieldOffset(0x11c)] public uint OSMinorVersion;
		[FieldOffset(0x120)] public ushort OSBuildNumber;
		[FieldOffset(0x122)] public ushort OSCSDVersion;
		[FieldOffset(0x124)] public uint OSPlatformId;
		[FieldOffset(0x128)] public uint ImageSubsystem;
		[FieldOffset(0x12c)] public uint ImageSubsystemMajorVersion;
		[FieldOffset(0x130)] public uint ImageSubsystemMinorVersion;
		[FieldOffset(0x134)] public fixed byte Padding4 [4];
		[FieldOffset(0x138)] public ulong ActiveProcessAffinityMask;
		[FieldOffset(0x140)] public fixed uint GdiHandleBuffer [60];
		[FieldOffset(0x230)] public IntPtr PostProcessInitRoutine;
		[FieldOffset(0x238)] public IntPtr TlsExpansionBitmap;
		[FieldOffset(0x240)] public fixed uint TlsExpansionBitmapBits [32];
		[FieldOffset(0x2c0)] public uint SessionId;
		[FieldOffset(0x2c4)] public fixed byte Padding5 [4];
		[FieldOffset(0x2c8)] public ulong AppCompatFlags;
		[FieldOffset(0x2d0)] public ulong AppCompatFlagsUser;
		[FieldOffset(0x2d8)] public IntPtr pShimData;
		[FieldOffset(0x2e0)] public IntPtr AppCompatInfo;
		[FieldOffset(0x2e8)] public UNICODE_STRING CSDVersion;
		[FieldOffset(0x2f8)] public IntPtr ActivationContextData;
		[FieldOffset(0x300)] public IntPtr ProcessAssemblyStorageMap;
		[FieldOffset(0x308)] public IntPtr SystemDefaultActivationContextData;
		[FieldOffset(0x310)] public IntPtr SystemAssemblyStorageMap;
		[FieldOffset(0x318)] public ulong MinimumStackCommit;
		[FieldOffset(0x320)] public IntPtr FlsCallback;
		[FieldOffset(0x328)] public LIST_ENTRY FlsListHead;
		[FieldOffset(0x338)] public IntPtr FlsBitmap;
		[FieldOffset(0x340)] public fixed uint FlsBitmapBits [4];
		[FieldOffset(0x350)] public uint FlsHighIndex;
		[FieldOffset(0x358)] public IntPtr WerRegistrationData;
		[FieldOffset(0x360)] public IntPtr WerShipAssertPtr;
		[FieldOffset(0x368)] public IntPtr pUnused;
		[FieldOffset(0x370)] public IntPtr pImageHeaderHash;
		[FieldOffset(0x378)] public uint TracingFlags;
		[FieldOffset(0x37c)] public fixed byte Padding6 [4];
		[FieldOffset(0x380)] public ulong CsrServerReadOnlySharedMemoryBase;
		[FieldOffset(0x388)] public ulong TppWorkerpListLock;
		[FieldOffset(0x390)] public LIST_ENTRY TppWorkerpList;
		[FieldOffset(0x3a0)] public IntPtr WaitOnAddressHashTable;


		public bool ImageUsesLargePages => (BitField & 0x0001) >> 0 == 1;
		public bool IsProtectedProcess => (BitField & 0x0002) >> 1 == 1;
		public bool IsImageDynamicallyRelocated => (BitField & 0x0004) >> 2 == 1;
		public bool SkipPatchingUser32Forwarders => (BitField & 0x0008) >> 3 == 1;
		public bool IsPackagedProcess => (BitField & 0x0010) >> 4 == 1;
		public bool IsAppContainer => (BitField & 0x0020) >> 5 == 1;
		public bool IsProtectedProcessLight => (BitField & 0x0040) >> 6 == 1;
		public bool SpareBits => (BitField & 0x0080) >> 7 == 1;

		public bool ProcessInJob => (CrossProcessFlags & 0x0001) >> 0 == 1;
		public bool ProcessInitializing => (CrossProcessFlags & 0x0002) >> 1 == 1;
		public bool ProcessUsingVEH => (CrossProcessFlags & 0x0004) >> 2 == 1;
		public bool ProcessUsingVCH => (CrossProcessFlags & 0x0008) >> 3 == 1;
		public bool ProcessUsingFTH => (CrossProcessFlags & 0x0010) >> 4 == 1;
		public uint ReservedBits0 => ((CrossProcessFlags & 0xFFFFFFE0) >> 5);

		public bool HeapTracingEnabled => (TracingFlags & 0x0001) >> 0 == 1;
		public bool CritSecTracingEnabled => (TracingFlags & 0x0002) >> 1 == 1;
		public bool LibLoaderTracingEnabled => (TracingFlags & 0x0004) >> 2 == 1;
		public uint SpareTracingBits => ((TracingFlags & 0xFFFFFFF8) >> 3);

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x58)]
	public struct PEB_LDR_DATA
	{
		[FieldOffset(0x000)] public uint Length;
		[FieldOffset(0x004)] public byte Initialized;
		[FieldOffset(0x008)] public IntPtr SsHandle;
		[FieldOffset(0x010)] public LIST_ENTRY InLoadOrderModuleList;
		[FieldOffset(0x020)] public LIST_ENTRY InMemoryOrderModuleList;
		[FieldOffset(0x030)] public LIST_ENTRY InInitializationOrderModuleList;
		[FieldOffset(0x040)] public IntPtr EntryInProgress;
		[FieldOffset(0x048)] public byte ShutdownInProgress;
		[FieldOffset(0x050)] public IntPtr ShutdownThreadId;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x4)]
	public struct PROCESSOR_NUMBER
	{
		[FieldOffset(0x000)] public ushort Group;
		[FieldOffset(0x002)] public byte Number;
		[FieldOffset(0x003)] public byte Reserved;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x18)]
	public struct RTL_ACTIVATION_CONTEXT_STACK_FRAME
	{
		[FieldOffset(0x000)] public IntPtr Previous;
		[FieldOffset(0x008)] public IntPtr ActivationContext;
		[FieldOffset(0x010)] public uint Flags;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x28)]
	public struct RTL_CRITICAL_SECTION
	{
		[FieldOffset(0x000)] public IntPtr DebugInfo;
		[FieldOffset(0x008)] public int LockCount;
		[FieldOffset(0x00c)] public int RecursionCount;
		[FieldOffset(0x010)] public IntPtr OwningThread;
		[FieldOffset(0x018)] public IntPtr LockSemaphore;
		[FieldOffset(0x020)] public ulong SpinCount;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x30)]
	public struct RTL_CRITICAL_SECTION_DEBUG
	{
		[FieldOffset(0x000)] public ushort Type;
		[FieldOffset(0x002)] public ushort CreatorBackTraceIndex;
		[FieldOffset(0x008)] public IntPtr CriticalSection;
		[FieldOffset(0x010)] public LIST_ENTRY ProcessLocksList;
		[FieldOffset(0x020)] public uint EntryCount;
		[FieldOffset(0x024)] public uint ContentionCount;
		[FieldOffset(0x028)] public uint Flags;
		[FieldOffset(0x02c)] public ushort CreatorBackTraceIndexHigh;
		[FieldOffset(0x02e)] public ushort SpareWORD;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x18)]
	public struct RTL_DRIVE_LETTER_CURDIR
	{
		[FieldOffset(0x000)] public ushort Flags;
		[FieldOffset(0x002)] public ushort Length;
		[FieldOffset(0x004)] public uint TimeStamp;
		[FieldOffset(0x008)] public STRING DosPath;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x410)]
	public struct RTL_USER_PROCESS_PARAMETERS
	{
		[FieldOffset(0x000)] public uint MaximumLength;
		[FieldOffset(0x004)] public uint Length;
		[FieldOffset(0x008)] public uint Flags;
		[FieldOffset(0x00c)] public uint DebugFlags;
		[FieldOffset(0x010)] public IntPtr ConsoleHandle;
		[FieldOffset(0x018)] public uint ConsoleFlags;
		[FieldOffset(0x020)] public IntPtr StandardInput;
		[FieldOffset(0x028)] public IntPtr StandardOutput;
		[FieldOffset(0x030)] public IntPtr StandardError;
		[FieldOffset(0x038)] public CURDIR CurrentDirectory;
		[FieldOffset(0x050)] public UNICODE_STRING DllPath;
		[FieldOffset(0x060)] public UNICODE_STRING ImagePathName;
		[FieldOffset(0x070)] public UNICODE_STRING CommandLine;
		[FieldOffset(0x080)] public IntPtr Environment;
		[FieldOffset(0x088)] public uint StartingX;
		[FieldOffset(0x08c)] public uint StartingY;
		[FieldOffset(0x090)] public uint CountX;
		[FieldOffset(0x094)] public uint CountY;
		[FieldOffset(0x098)] public uint CountCharsX;
		[FieldOffset(0x09c)] public uint CountCharsY;
		[FieldOffset(0x0a0)] public uint FillAttribute;
		[FieldOffset(0x0a4)] public uint WindowFlags;
		[FieldOffset(0x0a8)] public uint ShowWindowFlags;
		[FieldOffset(0x0b0)] public UNICODE_STRING WindowTitle;
		[FieldOffset(0x0c0)] public UNICODE_STRING DesktopInfo;
		[FieldOffset(0x0d0)] public UNICODE_STRING ShellInfo;
		[FieldOffset(0x0e0)] public UNICODE_STRING RuntimeData;
		[FieldOffset(0x0f0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores0;
		[FieldOffset(0x108)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores1;
		[FieldOffset(0x120)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores2;
		[FieldOffset(0x138)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores3;
		[FieldOffset(0x150)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores4;
		[FieldOffset(0x168)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores5;
		[FieldOffset(0x180)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores6;
		[FieldOffset(0x198)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores7;
		[FieldOffset(0x1b0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores8;
		[FieldOffset(0x1c8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores9;
		[FieldOffset(0x1e0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores10;
		[FieldOffset(0x1f8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores11;
		[FieldOffset(0x210)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores12;
		[FieldOffset(0x228)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores13;
		[FieldOffset(0x240)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores14;
		[FieldOffset(0x258)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores15;
		[FieldOffset(0x270)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores16;
		[FieldOffset(0x288)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores17;
		[FieldOffset(0x2a0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores18;
		[FieldOffset(0x2b8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores19;
		[FieldOffset(0x2d0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores20;
		[FieldOffset(0x2e8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores21;
		[FieldOffset(0x300)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores22;
		[FieldOffset(0x318)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores23;
		[FieldOffset(0x330)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores24;
		[FieldOffset(0x348)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores25;
		[FieldOffset(0x360)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores26;
		[FieldOffset(0x378)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores27;
		[FieldOffset(0x390)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores28;
		[FieldOffset(0x3a8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores29;
		[FieldOffset(0x3c0)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores30;
		[FieldOffset(0x3d8)] public RTL_DRIVE_LETTER_CURDIR CurrentDirectores31;
		[FieldOffset(0x3f0)] public ulong EnvironmentSize;
		[FieldOffset(0x3f8)] public ulong EnvironmentVersion;
		[FieldOffset(0x400)] public IntPtr PackageDependencyData;
		[FieldOffset(0x408)] public uint ProcessGroupId;
		[FieldOffset(0x40c)] public uint LoaderThreads;


		public static unsafe RTL_DRIVE_LETTER_CURDIR* GetCurrentDirectores(RTL_USER_PROCESS_PARAMETERS* item, int zeroBasedIndex)
		{
				return &item->CurrentDirectores0 + zeroBasedIndex;
		}

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public unsafe struct STRING
	{
		[FieldOffset(0x000)] public ushort Length;
		[FieldOffset(0x002)] public ushort MaximumLength;
		[FieldOffset(0x008)] public IntPtr* Buffer;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x1838)]
	public unsafe struct TEB
	{
		[FieldOffset(0x000)] public NT_TIB NtTib;
		[FieldOffset(0x038)] public IntPtr EnvironmentPointer;
		[FieldOffset(0x040)] public CLIENT_ID ClientId;
		[FieldOffset(0x050)] public IntPtr ActiveRpcHandle;
		[FieldOffset(0x058)] public IntPtr ThreadLocalStoragePointer;
		[FieldOffset(0x060)] public IntPtr ProcessEnvironmentBlock;
		[FieldOffset(0x068)] public uint LastErrorValue;
		[FieldOffset(0x06c)] public uint CountOfOwnedCriticalSections;
		[FieldOffset(0x070)] public IntPtr CsrClientThread;
		[FieldOffset(0x078)] public IntPtr Win32ThreadInfo;
		[FieldOffset(0x080)] public fixed uint User32Reserved [26];
		[FieldOffset(0x0e8)] public fixed uint UserReserved [5];
		[FieldOffset(0x100)] public IntPtr WOW32Reserved;
		[FieldOffset(0x108)] public uint CurrentLocale;
		[FieldOffset(0x10c)] public uint FpSoftwareStatusRegister;
		[FieldOffset(0x110)] public IntPtr ReservedForDebuggerInstrumentation;
		[FieldOffset(0x190)] public IntPtr SystemReserved1;
		[FieldOffset(0x2c0)] public int ExceptionCode;
		[FieldOffset(0x2c4)] public fixed byte Padding0 [4];
		[FieldOffset(0x2c8)] public IntPtr ActivationContextStackPointer;
		[FieldOffset(0x2d0)] public ulong InstrumentationCallbackSp;
		[FieldOffset(0x2d8)] public ulong InstrumentationCallbackPreviousPc;
		[FieldOffset(0x2e0)] public ulong InstrumentationCallbackPreviousSp;
		[FieldOffset(0x2e8)] public uint TxFsContext;
		[FieldOffset(0x2ec)] public byte InstrumentationCallbackDisabled;
		[FieldOffset(0x2ed)] public fixed byte Padding1 [3];
		[FieldOffset(0x2f0)] public GDI_TEB_BATCH GdiTebBatch;
		[FieldOffset(0x7d8)] public CLIENT_ID RealClientId;
		[FieldOffset(0x7e8)] public IntPtr GdiCachedProcessHandle;
		[FieldOffset(0x7f0)] public uint GdiClientPID;
		[FieldOffset(0x7f4)] public uint GdiClientTID;
		[FieldOffset(0x7f8)] public IntPtr GdiThreadLocalInfo;
		[FieldOffset(0x800)] public fixed ulong Win32ClientInfo [62];
		[FieldOffset(0x9f0)] public IntPtr glDispatchTable;
		[FieldOffset(0x1138)] public fixed ulong glReserved1 [29];
		[FieldOffset(0x1220)] public IntPtr glReserved2;
		[FieldOffset(0x1228)] public IntPtr glSectionInfo;
		[FieldOffset(0x1230)] public IntPtr glSection;
		[FieldOffset(0x1238)] public IntPtr glTable;
		[FieldOffset(0x1240)] public IntPtr glCurrentRC;
		[FieldOffset(0x1248)] public IntPtr glContext;
		[FieldOffset(0x1250)] public uint LastStatusValue;
		[FieldOffset(0x1254)] public fixed byte Padding2 [4];
		[FieldOffset(0x1258)] public UNICODE_STRING StaticUnicodeString;
		[FieldOffset(0x1268)] public short StaticUnicodeBuffer;
		[FieldOffset(0x1472)] public fixed byte Padding3 [6];
		[FieldOffset(0x1478)] public IntPtr DeallocationStack;
		[FieldOffset(0x1480)] public IntPtr TlsSlots;
		[FieldOffset(0x1680)] public LIST_ENTRY TlsLinks;
		[FieldOffset(0x1690)] public IntPtr Vdm;
		[FieldOffset(0x1698)] public IntPtr ReservedForNtRpc;
		[FieldOffset(0x16a0)] public IntPtr DbgSsReserved;
		[FieldOffset(0x16b0)] public uint HardErrorMode;
		[FieldOffset(0x16b4)] public fixed byte Padding4 [4];
		[FieldOffset(0x16b8)] public IntPtr Instrumentation;
		[FieldOffset(0x1710)] public Guid ActivityId;
		[FieldOffset(0x1720)] public IntPtr SubProcessTag;
		[FieldOffset(0x1728)] public IntPtr PerflibData;
		[FieldOffset(0x1730)] public IntPtr EtwTraceData;
		[FieldOffset(0x1738)] public IntPtr WinSockData;
		[FieldOffset(0x1740)] public uint GdiBatchCount;
		[FieldOffset(0x1744)] public PROCESSOR_NUMBER CurrentIdealProcessor;
		[FieldOffset(0x1744)] public uint IdealProcessorValue;
		[FieldOffset(0x1744)] public byte ReservedPad0;
		[FieldOffset(0x1745)] public byte ReservedPad1;
		[FieldOffset(0x1746)] public byte ReservedPad2;
		[FieldOffset(0x1747)] public byte IdealProcessor;
		[FieldOffset(0x1748)] public uint GuaranteedStackBytes;
		[FieldOffset(0x174c)] public fixed byte Padding5 [4];
		[FieldOffset(0x1750)] public IntPtr ReservedForPerf;
		[FieldOffset(0x1758)] public IntPtr ReservedForOle;
		[FieldOffset(0x1760)] public uint WaitingOnLoaderLock;
		[FieldOffset(0x1764)] public fixed byte Padding6 [4];
		[FieldOffset(0x1768)] public IntPtr SavedPriorityState;
		[FieldOffset(0x1770)] public ulong ReservedForCodeCoverage;
		[FieldOffset(0x1778)] public IntPtr ThreadPoolData;
		[FieldOffset(0x1780)] public IntPtr TlsExpansionSlots;
		[FieldOffset(0x1788)] public IntPtr DeallocationBStore;
		[FieldOffset(0x1790)] public IntPtr BStoreLimit;
		[FieldOffset(0x1798)] public uint MuiGeneration;
		[FieldOffset(0x179c)] public uint IsImpersonating;
		[FieldOffset(0x17a0)] public IntPtr NlsCache;
		[FieldOffset(0x17a8)] public IntPtr pShimData;
		[FieldOffset(0x17b0)] public ushort HeapVirtualAffinity;
		[FieldOffset(0x17b2)] public ushort LowFragHeapDataSlot;
		[FieldOffset(0x17b4)] public fixed byte Padding7 [4];
		[FieldOffset(0x17b8)] public IntPtr CurrentTransactionHandle;
		[FieldOffset(0x17c0)] public IntPtr ActiveFrame;
		[FieldOffset(0x17c8)] public IntPtr FlsData;
		[FieldOffset(0x17d0)] public IntPtr PreferredLanguages;
		[FieldOffset(0x17d8)] public IntPtr UserPrefLanguages;
		[FieldOffset(0x17e0)] public IntPtr MergedPrefLanguages;
		[FieldOffset(0x17e8)] public uint MuiImpersonation;
		[FieldOffset(0x17ec)] public ushort CrossTebFlags;
		[FieldOffset(0x17ee)] public ushort SameTebFlags;
		[FieldOffset(0x17f0)] public IntPtr TxnScopeEnterCallback;
		[FieldOffset(0x17f8)] public IntPtr TxnScopeExitCallback;
		[FieldOffset(0x1800)] public IntPtr TxnScopeContext;
		[FieldOffset(0x1808)] public uint LockCount;
		[FieldOffset(0x180c)] public int WowTebOffset;
		[FieldOffset(0x1810)] public IntPtr ResourceRetValue;
		[FieldOffset(0x1818)] public IntPtr ReservedForWdf;
		[FieldOffset(0x1820)] public ulong ReservedForCrt;
		[FieldOffset(0x1828)] public Guid EffectiveContainerId;


		public ushort SpareCrossTebBits => (ushort)((CrossTebFlags & 0xFFFF) >> 0);

		public bool SafeThunkCall => (SameTebFlags & 0x0001) >> 0 == 1;
		public bool InDebugPrint => (SameTebFlags & 0x0002) >> 1 == 1;
		public bool HasFiberData => (SameTebFlags & 0x0004) >> 2 == 1;
		public bool SkipThreadAttach => (SameTebFlags & 0x0008) >> 3 == 1;
		public bool WerInShipAssertCode => (SameTebFlags & 0x0010) >> 4 == 1;
		public bool RanProcessInit => (SameTebFlags & 0x0020) >> 5 == 1;
		public bool ClonedThread => (SameTebFlags & 0x0040) >> 6 == 1;
		public bool SuppressDebugMsg => (SameTebFlags & 0x0080) >> 7 == 1;
		public bool DisableUserStackWalk => (SameTebFlags & 0x0100) >> 8 == 1;
		public bool RtlExceptionAttached => (SameTebFlags & 0x0200) >> 9 == 1;
		public bool InitialThread => (SameTebFlags & 0x0400) >> 10 == 1;
		public bool SessionAware => (SameTebFlags & 0x0800) >> 11 == 1;
		public bool LoadOwner => (SameTebFlags & 0x1000) >> 12 == 1;
		public bool LoaderWorker => (SameTebFlags & 0x2000) >> 13 == 1;
		public ushort SpareSameTebBits => (ushort)((SameTebFlags & 0xC000) >> 14);

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x18)]
	public struct TEB_ACTIVE_FRAME
	{
		[FieldOffset(0x000)] public uint Flags;
		[FieldOffset(0x008)] public IntPtr Previous;
		[FieldOffset(0x010)] public IntPtr Context;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public unsafe struct TEB_ACTIVE_FRAME_CONTEXT
	{
		[FieldOffset(0x000)] public uint Flags;
		[FieldOffset(0x008)] public IntPtr* FrameName;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x10)]
	public unsafe struct UNICODE_STRING
	{
		[FieldOffset(0x000)] public ushort Length;
		[FieldOffset(0x002)] public ushort MaximumLength;
		[FieldOffset(0x008)] public IntPtr* Buffer;

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x4d0)]
	public struct CONTEXT
	{
		[FieldOffset(0x000)] public ulong P1Home;
		[FieldOffset(0x008)] public ulong P2Home;
		[FieldOffset(0x010)] public ulong P3Home;
		[FieldOffset(0x018)] public ulong P4Home;
		[FieldOffset(0x020)] public ulong P5Home;
		[FieldOffset(0x028)] public ulong P6Home;
		[FieldOffset(0x030)] public uint ContextFlags;
		[FieldOffset(0x034)] public uint MxCsr;
		[FieldOffset(0x038)] public ushort SegCs;
		[FieldOffset(0x03a)] public ushort SegDs;
		[FieldOffset(0x03c)] public ushort SegEs;
		[FieldOffset(0x03e)] public ushort SegFs;
		[FieldOffset(0x040)] public ushort SegGs;
		[FieldOffset(0x042)] public ushort SegSs;
		[FieldOffset(0x044)] public uint EFlags;
		[FieldOffset(0x048)] public ulong Dr0;
		[FieldOffset(0x050)] public ulong Dr1;
		[FieldOffset(0x058)] public ulong Dr2;
		[FieldOffset(0x060)] public ulong Dr3;
		[FieldOffset(0x068)] public ulong Dr6;
		[FieldOffset(0x070)] public ulong Dr7;
		[FieldOffset(0x078)] public ulong Rax;
		[FieldOffset(0x080)] public ulong Rcx;
		[FieldOffset(0x088)] public ulong Rdx;
		[FieldOffset(0x090)] public ulong Rbx;
		[FieldOffset(0x098)] public ulong Rsp;
		[FieldOffset(0x0a0)] public ulong Rbp;
		[FieldOffset(0x0a8)] public ulong Rsi;
		[FieldOffset(0x0b0)] public ulong Rdi;
		[FieldOffset(0x0b8)] public ulong R8;
		[FieldOffset(0x0c0)] public ulong R9;
		[FieldOffset(0x0c8)] public ulong R10;
		[FieldOffset(0x0d0)] public ulong R11;
		[FieldOffset(0x0d8)] public ulong R12;
		[FieldOffset(0x0e0)] public ulong R13;
		[FieldOffset(0x0e8)] public ulong R14;
		[FieldOffset(0x0f0)] public ulong R15;
		[FieldOffset(0x0f8)] public ulong Rip;
		[FieldOffset(0x100)] public XSAVE_FORMAT FltSave;
		[FieldOffset(0x100)] public F128PARTS64 Header0;
		[FieldOffset(0x110)] public F128PARTS64 Header1;
		[FieldOffset(0x120)] public F128PARTS64 Legacy0;
		[FieldOffset(0x130)] public F128PARTS64 Legacy1;
		[FieldOffset(0x140)] public F128PARTS64 Legacy2;
		[FieldOffset(0x150)] public F128PARTS64 Legacy3;
		[FieldOffset(0x160)] public F128PARTS64 Legacy4;
		[FieldOffset(0x170)] public F128PARTS64 Legacy5;
		[FieldOffset(0x180)] public F128PARTS64 Legacy6;
		[FieldOffset(0x190)] public F128PARTS64 Legacy7;
		[FieldOffset(0x1a0)] public F128PARTS64 Xmm0;
		[FieldOffset(0x1b0)] public F128PARTS64 Xmm1;
		[FieldOffset(0x1c0)] public F128PARTS64 Xmm2;
		[FieldOffset(0x1d0)] public F128PARTS64 Xmm3;
		[FieldOffset(0x1e0)] public F128PARTS64 Xmm4;
		[FieldOffset(0x1f0)] public F128PARTS64 Xmm5;
		[FieldOffset(0x200)] public F128PARTS64 Xmm6;
		[FieldOffset(0x210)] public F128PARTS64 Xmm7;
		[FieldOffset(0x220)] public F128PARTS64 Xmm8;
		[FieldOffset(0x230)] public F128PARTS64 Xmm9;
		[FieldOffset(0x240)] public F128PARTS64 Xmm10;
		[FieldOffset(0x250)] public F128PARTS64 Xmm11;
		[FieldOffset(0x260)] public F128PARTS64 Xmm12;
		[FieldOffset(0x270)] public F128PARTS64 Xmm13;
		[FieldOffset(0x280)] public F128PARTS64 Xmm14;
		[FieldOffset(0x290)] public F128PARTS64 Xmm15;
		[FieldOffset(0x300)] public F128PARTS64 VectorRegister0;
		[FieldOffset(0x310)] public F128PARTS64 VectorRegister1;
		[FieldOffset(0x320)] public F128PARTS64 VectorRegister2;
		[FieldOffset(0x330)] public F128PARTS64 VectorRegister3;
		[FieldOffset(0x340)] public F128PARTS64 VectorRegister4;
		[FieldOffset(0x350)] public F128PARTS64 VectorRegister5;
		[FieldOffset(0x360)] public F128PARTS64 VectorRegister6;
		[FieldOffset(0x370)] public F128PARTS64 VectorRegister7;
		[FieldOffset(0x380)] public F128PARTS64 VectorRegister8;
		[FieldOffset(0x390)] public F128PARTS64 VectorRegister9;
		[FieldOffset(0x3a0)] public F128PARTS64 VectorRegister10;
		[FieldOffset(0x3b0)] public F128PARTS64 VectorRegister11;
		[FieldOffset(0x3c0)] public F128PARTS64 VectorRegister12;
		[FieldOffset(0x3d0)] public F128PARTS64 VectorRegister13;
		[FieldOffset(0x3e0)] public F128PARTS64 VectorRegister14;
		[FieldOffset(0x3f0)] public F128PARTS64 VectorRegister15;
		[FieldOffset(0x400)] public F128PARTS64 VectorRegister16;
		[FieldOffset(0x410)] public F128PARTS64 VectorRegister17;
		[FieldOffset(0x420)] public F128PARTS64 VectorRegister18;
		[FieldOffset(0x430)] public F128PARTS64 VectorRegister19;
		[FieldOffset(0x440)] public F128PARTS64 VectorRegister20;
		[FieldOffset(0x450)] public F128PARTS64 VectorRegister21;
		[FieldOffset(0x460)] public F128PARTS64 VectorRegister22;
		[FieldOffset(0x470)] public F128PARTS64 VectorRegister23;
		[FieldOffset(0x480)] public F128PARTS64 VectorRegister24;
		[FieldOffset(0x490)] public F128PARTS64 VectorRegister25;
		[FieldOffset(0x4a0)] public ulong VectorControl;
		[FieldOffset(0x4a8)] public ulong DebugControl;
		[FieldOffset(0x4b0)] public ulong LastBranchToRip;
		[FieldOffset(0x4b8)] public ulong LastBranchFromRip;
		[FieldOffset(0x4c0)] public ulong LastExceptionToRip;
		[FieldOffset(0x4c8)] public ulong LastExceptionFromRip;


		public static unsafe F128PARTS64* GetHeader(CONTEXT* item, int zeroBasedIndex)
		{
				return &item->Header0 + zeroBasedIndex;
		}

		public static unsafe F128PARTS64* GetLegacy(CONTEXT* item, int zeroBasedIndex)
		{
				return &item->Legacy0 + zeroBasedIndex;
		}

		public static unsafe F128PARTS64* GetVectorRegister(CONTEXT* item, int zeroBasedIndex)
		{
				return &item->VectorRegister0 + zeroBasedIndex;
		}

	}
 
	/// Generated by SystemStruct.ps1
	[StructLayout(LayoutKind.Explicit, Size=0x200)]
	public unsafe struct XSAVE_FORMAT
	{
		[FieldOffset(0x000)] public ushort ControlWord;
		[FieldOffset(0x002)] public ushort StatusWord;
		[FieldOffset(0x004)] public byte TagWord;
		[FieldOffset(0x005)] public byte Reserved1;
		[FieldOffset(0x006)] public ushort ErrorOpcode;
		[FieldOffset(0x008)] public uint ErrorOffset;
		[FieldOffset(0x00c)] public ushort ErrorSelector;
		[FieldOffset(0x00e)] public ushort Reserved2;
		[FieldOffset(0x010)] public uint DataOffset;
		[FieldOffset(0x014)] public ushort DataSelector;
		[FieldOffset(0x016)] public ushort Reserved3;
		[FieldOffset(0x018)] public uint MxCsr;
		[FieldOffset(0x01c)] public uint MxCsr_Mask;
		[FieldOffset(0x020)] public F128PARTS64 FloatRegisters0;
		[FieldOffset(0x030)] public F128PARTS64 FloatRegisters1;
		[FieldOffset(0x040)] public F128PARTS64 FloatRegisters2;
		[FieldOffset(0x050)] public F128PARTS64 FloatRegisters3;
		[FieldOffset(0x060)] public F128PARTS64 FloatRegisters4;
		[FieldOffset(0x070)] public F128PARTS64 FloatRegisters5;
		[FieldOffset(0x080)] public F128PARTS64 FloatRegisters6;
		[FieldOffset(0x090)] public F128PARTS64 FloatRegisters7;
		[FieldOffset(0x0a0)] public F128PARTS64 XmmRegisters0;
		[FieldOffset(0x0b0)] public F128PARTS64 XmmRegisters1;
		[FieldOffset(0x0c0)] public F128PARTS64 XmmRegisters2;
		[FieldOffset(0x0d0)] public F128PARTS64 XmmRegisters3;
		[FieldOffset(0x0e0)] public F128PARTS64 XmmRegisters4;
		[FieldOffset(0x0f0)] public F128PARTS64 XmmRegisters5;
		[FieldOffset(0x100)] public F128PARTS64 XmmRegisters6;
		[FieldOffset(0x110)] public F128PARTS64 XmmRegisters7;
		[FieldOffset(0x120)] public F128PARTS64 XmmRegisters8;
		[FieldOffset(0x130)] public F128PARTS64 XmmRegisters9;
		[FieldOffset(0x140)] public F128PARTS64 XmmRegisters10;
		[FieldOffset(0x150)] public F128PARTS64 XmmRegisters11;
		[FieldOffset(0x160)] public F128PARTS64 XmmRegisters12;
		[FieldOffset(0x170)] public F128PARTS64 XmmRegisters13;
		[FieldOffset(0x180)] public F128PARTS64 XmmRegisters14;
		[FieldOffset(0x190)] public F128PARTS64 XmmRegisters15;
		[FieldOffset(0x1a0)] public fixed byte Reserved4 [96];


		public static F128PARTS64* GetFloatRegisters(XSAVE_FORMAT* item, int zeroBasedIndex)
		{
				return &item->FloatRegisters0 + zeroBasedIndex;
		}

		public static F128PARTS64* GetXmmRegisters(XSAVE_FORMAT* item, int zeroBasedIndex)
		{
				return &item->XmmRegisters0 + zeroBasedIndex;
		}

	}


}
