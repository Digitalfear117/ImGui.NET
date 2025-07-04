using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiIO
    {
        public ImGuiConfigFlags ConfigFlags;
        public ImGuiBackendFlags BackendFlags;
        public Vector2 DisplaySize;
        public float DeltaTime;
        public float IniSavingRate;
        public byte* IniFilename;
        public byte* LogFilename;
        public void* UserData;
        public ImFontAtlas* Fonts;
        public float FontGlobalScale;
        public byte FontAllowUserScaling;
        public ImFont* FontDefault;
        public Vector2 DisplayFramebufferScale;
        public byte ConfigNavSwapGamepadButtons;
        public byte ConfigNavMoveSetMousePos;
        public byte ConfigNavCaptureKeyboard;
        public byte ConfigNavEscapeClearFocusItem;
        public byte ConfigNavEscapeClearFocusWindow;
        public byte ConfigNavCursorVisibleAuto;
        public byte ConfigNavCursorVisibleAlways;
        public byte ConfigDockingNoSplit;
        public byte ConfigDockingWithShift;
        public byte ConfigDockingAlwaysTabBar;
        public byte ConfigDockingTransparentPayload;
        public byte ConfigViewportsNoAutoMerge;
        public byte ConfigViewportsNoTaskBarIcon;
        public byte ConfigViewportsNoDecoration;
        public byte ConfigViewportsNoDefaultParent;
        public byte MouseDrawCursor;
        public byte ConfigMacOSXBehaviors;
        public byte ConfigInputTrickleEventQueue;
        public byte ConfigInputTextCursorBlink;
        public byte ConfigInputTextEnterKeepActive;
        public byte ConfigDragClickToInputText;
        public byte ConfigWindowsResizeFromEdges;
        public byte ConfigWindowsMoveFromTitleBarOnly;
        public byte ConfigWindowsCopyContentsWithCtrlC;
        public byte ConfigScrollbarScrollByPage;
        public float ConfigMemoryCompactTimer;
        public float MouseDoubleClickTime;
        public float MouseDoubleClickMaxDist;
        public float MouseDragThreshold;
        public float KeyRepeatDelay;
        public float KeyRepeatRate;
        public byte ConfigErrorRecovery;
        public byte ConfigErrorRecoveryEnableAssert;
        public byte ConfigErrorRecoveryEnableDebugLog;
        public byte ConfigErrorRecoveryEnableTooltip;
        public byte ConfigDebugIsDebuggerPresent;
        public byte ConfigDebugHighlightIdConflicts;
        public byte ConfigDebugBeginReturnValueOnce;
        public byte ConfigDebugBeginReturnValueLoop;
        public byte ConfigDebugIgnoreFocusLoss;
        public byte ConfigDebugIniSettings;
        public byte* BackendPlatformName;
        public byte* BackendRendererName;
        public void* BackendPlatformUserData;
        public void* BackendRendererUserData;
        public void* BackendLanguageUserData;
        public byte WantCaptureMouse;
        public byte WantCaptureKeyboard;
        public byte WantTextInput;
        public byte WantSetMousePos;
        public byte WantSaveIniSettings;
        public byte NavActive;
        public byte NavVisible;
        public float Framerate;
        public int MetricsRenderVertices;
        public int MetricsRenderIndices;
        public int MetricsRenderWindows;
        public int MetricsActiveWindows;
        public Vector2 MouseDelta;
        public IntPtr Ctx;
        public Vector2 MousePos;
        public fixed byte MouseDown[5];
        public float MouseWheel;
        public float MouseWheelH;
        public ImGuiMouseSource MouseSource;
        public uint MouseHoveredViewport;
        public byte KeyCtrl;
        public byte KeyShift;
        public byte KeyAlt;
        public byte KeySuper;
        public ImGuiKey KeyMods;
        public ImGuiKeyData KeysData_0;
        public ImGuiKeyData KeysData_1;
        public ImGuiKeyData KeysData_2;
        public ImGuiKeyData KeysData_3;
        public ImGuiKeyData KeysData_4;
        public ImGuiKeyData KeysData_5;
        public ImGuiKeyData KeysData_6;
        public ImGuiKeyData KeysData_7;
        public ImGuiKeyData KeysData_8;
        public ImGuiKeyData KeysData_9;
        public ImGuiKeyData KeysData_10;
        public ImGuiKeyData KeysData_11;
        public ImGuiKeyData KeysData_12;
        public ImGuiKeyData KeysData_13;
        public ImGuiKeyData KeysData_14;
        public ImGuiKeyData KeysData_15;
        public ImGuiKeyData KeysData_16;
        public ImGuiKeyData KeysData_17;
        public ImGuiKeyData KeysData_18;
        public ImGuiKeyData KeysData_19;
        public ImGuiKeyData KeysData_20;
        public ImGuiKeyData KeysData_21;
        public ImGuiKeyData KeysData_22;
        public ImGuiKeyData KeysData_23;
        public ImGuiKeyData KeysData_24;
        public ImGuiKeyData KeysData_25;
        public ImGuiKeyData KeysData_26;
        public ImGuiKeyData KeysData_27;
        public ImGuiKeyData KeysData_28;
        public ImGuiKeyData KeysData_29;
        public ImGuiKeyData KeysData_30;
        public ImGuiKeyData KeysData_31;
        public ImGuiKeyData KeysData_32;
        public ImGuiKeyData KeysData_33;
        public ImGuiKeyData KeysData_34;
        public ImGuiKeyData KeysData_35;
        public ImGuiKeyData KeysData_36;
        public ImGuiKeyData KeysData_37;
        public ImGuiKeyData KeysData_38;
        public ImGuiKeyData KeysData_39;
        public ImGuiKeyData KeysData_40;
        public ImGuiKeyData KeysData_41;
        public ImGuiKeyData KeysData_42;
        public ImGuiKeyData KeysData_43;
        public ImGuiKeyData KeysData_44;
        public ImGuiKeyData KeysData_45;
        public ImGuiKeyData KeysData_46;
        public ImGuiKeyData KeysData_47;
        public ImGuiKeyData KeysData_48;
        public ImGuiKeyData KeysData_49;
        public ImGuiKeyData KeysData_50;
        public ImGuiKeyData KeysData_51;
        public ImGuiKeyData KeysData_52;
        public ImGuiKeyData KeysData_53;
        public ImGuiKeyData KeysData_54;
        public ImGuiKeyData KeysData_55;
        public ImGuiKeyData KeysData_56;
        public ImGuiKeyData KeysData_57;
        public ImGuiKeyData KeysData_58;
        public ImGuiKeyData KeysData_59;
        public ImGuiKeyData KeysData_60;
        public ImGuiKeyData KeysData_61;
        public ImGuiKeyData KeysData_62;
        public ImGuiKeyData KeysData_63;
        public ImGuiKeyData KeysData_64;
        public ImGuiKeyData KeysData_65;
        public ImGuiKeyData KeysData_66;
        public ImGuiKeyData KeysData_67;
        public ImGuiKeyData KeysData_68;
        public ImGuiKeyData KeysData_69;
        public ImGuiKeyData KeysData_70;
        public ImGuiKeyData KeysData_71;
        public ImGuiKeyData KeysData_72;
        public ImGuiKeyData KeysData_73;
        public ImGuiKeyData KeysData_74;
        public ImGuiKeyData KeysData_75;
        public ImGuiKeyData KeysData_76;
        public ImGuiKeyData KeysData_77;
        public ImGuiKeyData KeysData_78;
        public ImGuiKeyData KeysData_79;
        public ImGuiKeyData KeysData_80;
        public ImGuiKeyData KeysData_81;
        public ImGuiKeyData KeysData_82;
        public ImGuiKeyData KeysData_83;
        public ImGuiKeyData KeysData_84;
        public ImGuiKeyData KeysData_85;
        public ImGuiKeyData KeysData_86;
        public ImGuiKeyData KeysData_87;
        public ImGuiKeyData KeysData_88;
        public ImGuiKeyData KeysData_89;
        public ImGuiKeyData KeysData_90;
        public ImGuiKeyData KeysData_91;
        public ImGuiKeyData KeysData_92;
        public ImGuiKeyData KeysData_93;
        public ImGuiKeyData KeysData_94;
        public ImGuiKeyData KeysData_95;
        public ImGuiKeyData KeysData_96;
        public ImGuiKeyData KeysData_97;
        public ImGuiKeyData KeysData_98;
        public ImGuiKeyData KeysData_99;
        public ImGuiKeyData KeysData_100;
        public ImGuiKeyData KeysData_101;
        public ImGuiKeyData KeysData_102;
        public ImGuiKeyData KeysData_103;
        public ImGuiKeyData KeysData_104;
        public ImGuiKeyData KeysData_105;
        public ImGuiKeyData KeysData_106;
        public ImGuiKeyData KeysData_107;
        public ImGuiKeyData KeysData_108;
        public ImGuiKeyData KeysData_109;
        public ImGuiKeyData KeysData_110;
        public ImGuiKeyData KeysData_111;
        public ImGuiKeyData KeysData_112;
        public ImGuiKeyData KeysData_113;
        public ImGuiKeyData KeysData_114;
        public ImGuiKeyData KeysData_115;
        public ImGuiKeyData KeysData_116;
        public ImGuiKeyData KeysData_117;
        public ImGuiKeyData KeysData_118;
        public ImGuiKeyData KeysData_119;
        public ImGuiKeyData KeysData_120;
        public ImGuiKeyData KeysData_121;
        public ImGuiKeyData KeysData_122;
        public ImGuiKeyData KeysData_123;
        public ImGuiKeyData KeysData_124;
        public ImGuiKeyData KeysData_125;
        public ImGuiKeyData KeysData_126;
        public ImGuiKeyData KeysData_127;
        public ImGuiKeyData KeysData_128;
        public ImGuiKeyData KeysData_129;
        public ImGuiKeyData KeysData_130;
        public ImGuiKeyData KeysData_131;
        public ImGuiKeyData KeysData_132;
        public ImGuiKeyData KeysData_133;
        public ImGuiKeyData KeysData_134;
        public ImGuiKeyData KeysData_135;
        public ImGuiKeyData KeysData_136;
        public ImGuiKeyData KeysData_137;
        public ImGuiKeyData KeysData_138;
        public ImGuiKeyData KeysData_139;
        public ImGuiKeyData KeysData_140;
        public ImGuiKeyData KeysData_141;
        public ImGuiKeyData KeysData_142;
        public ImGuiKeyData KeysData_143;
        public ImGuiKeyData KeysData_144;
        public ImGuiKeyData KeysData_145;
        public ImGuiKeyData KeysData_146;
        public ImGuiKeyData KeysData_147;
        public ImGuiKeyData KeysData_148;
        public ImGuiKeyData KeysData_149;
        public ImGuiKeyData KeysData_150;
        public ImGuiKeyData KeysData_151;
        public ImGuiKeyData KeysData_152;
        public ImGuiKeyData KeysData_153;
        public byte WantCaptureMouseUnlessPopupClose;
        public Vector2 MousePosPrev;
        public Vector2 MouseClickedPos_0;
        public Vector2 MouseClickedPos_1;
        public Vector2 MouseClickedPos_2;
        public Vector2 MouseClickedPos_3;
        public Vector2 MouseClickedPos_4;
        public fixed double MouseClickedTime[5];
        public fixed byte MouseClicked[5];
        public fixed byte MouseDoubleClicked[5];
        public fixed ushort MouseClickedCount[5];
        public fixed ushort MouseClickedLastCount[5];
        public fixed byte MouseReleased[5];
        public fixed byte MouseDownOwned[5];
        public fixed byte MouseDownOwnedUnlessPopupClose[5];
        public byte MouseWheelRequestAxisSwap;
        public byte MouseCtrlLeftAsRightClick;
        public fixed float MouseDownDuration[5];
        public fixed float MouseDownDurationPrev[5];
        public Vector2 MouseDragMaxDistanceAbs_0;
        public Vector2 MouseDragMaxDistanceAbs_1;
        public Vector2 MouseDragMaxDistanceAbs_2;
        public Vector2 MouseDragMaxDistanceAbs_3;
        public Vector2 MouseDragMaxDistanceAbs_4;
        public fixed float MouseDragMaxDistanceSqr[5];
        public float PenPressure;
        public byte AppFocusLost;
        public byte AppAcceptingEvents;
        public ushort InputQueueSurrogate;
        public ImVector InputQueueCharacters;
    }
    public unsafe partial struct ImGuiIOPtr
    {
        public ImGuiIO* NativePtr { get; }
        public ImGuiIOPtr(ImGuiIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiIO*)nativePtr;
        public static implicit operator ImGuiIOPtr(ImGuiIO* nativePtr) => new ImGuiIOPtr(nativePtr);
        public static implicit operator ImGuiIO* (ImGuiIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiIOPtr(IntPtr nativePtr) => new ImGuiIOPtr(nativePtr);
        public ref ImGuiConfigFlags ConfigFlags => ref NativePtr->ConfigFlags;
        public ref ImGuiBackendFlags BackendFlags => ref NativePtr->BackendFlags;
        public ref Vector2 DisplaySize => ref NativePtr->DisplaySize;
        public ref float DeltaTime => ref NativePtr->DeltaTime;
        public ref float IniSavingRate => ref NativePtr->IniSavingRate;
        public NullTerminatedString IniFilename => new NullTerminatedString(NativePtr->IniFilename);
        public NullTerminatedString LogFilename => new NullTerminatedString(NativePtr->LogFilename);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ImFontAtlasPtr Fonts => new ImFontAtlasPtr(NativePtr->Fonts);
        public ref float FontGlobalScale => ref NativePtr->FontGlobalScale;
        public bool FontAllowUserScaling
        {
            get => NativePtr->FontAllowUserScaling != 0;
            set => NativePtr->FontAllowUserScaling = (byte)(value ? 1 : 0);
        }
        public ImFontPtr FontDefault => new ImFontPtr(NativePtr->FontDefault);
        public ref Vector2 DisplayFramebufferScale => ref NativePtr->DisplayFramebufferScale;
        public bool ConfigNavSwapGamepadButtons
        {
            get => NativePtr->ConfigNavSwapGamepadButtons != 0;
            set => NativePtr->ConfigNavSwapGamepadButtons = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavMoveSetMousePos
        {
            get => NativePtr->ConfigNavMoveSetMousePos != 0;
            set => NativePtr->ConfigNavMoveSetMousePos = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavCaptureKeyboard
        {
            get => NativePtr->ConfigNavCaptureKeyboard != 0;
            set => NativePtr->ConfigNavCaptureKeyboard = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavEscapeClearFocusItem
        {
            get => NativePtr->ConfigNavEscapeClearFocusItem != 0;
            set => NativePtr->ConfigNavEscapeClearFocusItem = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavEscapeClearFocusWindow
        {
            get => NativePtr->ConfigNavEscapeClearFocusWindow != 0;
            set => NativePtr->ConfigNavEscapeClearFocusWindow = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavCursorVisibleAuto
        {
            get => NativePtr->ConfigNavCursorVisibleAuto != 0;
            set => NativePtr->ConfigNavCursorVisibleAuto = (byte)(value ? 1 : 0);
        }
        public bool ConfigNavCursorVisibleAlways
        {
            get => NativePtr->ConfigNavCursorVisibleAlways != 0;
            set => NativePtr->ConfigNavCursorVisibleAlways = (byte)(value ? 1 : 0);
        }
        public bool ConfigDockingNoSplit
        {
            get => NativePtr->ConfigDockingNoSplit != 0;
            set => NativePtr->ConfigDockingNoSplit = (byte)(value ? 1 : 0);
        }
        public bool ConfigDockingWithShift
        {
            get => NativePtr->ConfigDockingWithShift != 0;
            set => NativePtr->ConfigDockingWithShift = (byte)(value ? 1 : 0);
        }
        public bool ConfigDockingAlwaysTabBar
        {
            get => NativePtr->ConfigDockingAlwaysTabBar != 0;
            set => NativePtr->ConfigDockingAlwaysTabBar = (byte)(value ? 1 : 0);
        }
        public bool ConfigDockingTransparentPayload
        {
            get => NativePtr->ConfigDockingTransparentPayload != 0;
            set => NativePtr->ConfigDockingTransparentPayload = (byte)(value ? 1 : 0);
        }
        public bool ConfigViewportsNoAutoMerge
        {
            get => NativePtr->ConfigViewportsNoAutoMerge != 0;
            set => NativePtr->ConfigViewportsNoAutoMerge = (byte)(value ? 1 : 0);
        }
        public bool ConfigViewportsNoTaskBarIcon
        {
            get => NativePtr->ConfigViewportsNoTaskBarIcon != 0;
            set => NativePtr->ConfigViewportsNoTaskBarIcon = (byte)(value ? 1 : 0);
        }
        public bool ConfigViewportsNoDecoration
        {
            get => NativePtr->ConfigViewportsNoDecoration != 0;
            set => NativePtr->ConfigViewportsNoDecoration = (byte)(value ? 1 : 0);
        }
        public bool ConfigViewportsNoDefaultParent
        {
            get => NativePtr->ConfigViewportsNoDefaultParent != 0;
            set => NativePtr->ConfigViewportsNoDefaultParent = (byte)(value ? 1 : 0);
        }
        public bool MouseDrawCursor
        {
            get => NativePtr->MouseDrawCursor != 0;
            set => NativePtr->MouseDrawCursor = (byte)(value ? 1 : 0);
        }
        public bool ConfigMacOSXBehaviors
        {
            get => NativePtr->ConfigMacOSXBehaviors != 0;
            set => NativePtr->ConfigMacOSXBehaviors = (byte)(value ? 1 : 0);
        }
        public bool ConfigInputTrickleEventQueue
        {
            get => NativePtr->ConfigInputTrickleEventQueue != 0;
            set => NativePtr->ConfigInputTrickleEventQueue = (byte)(value ? 1 : 0);
        }
        public bool ConfigInputTextCursorBlink
        {
            get => NativePtr->ConfigInputTextCursorBlink != 0;
            set => NativePtr->ConfigInputTextCursorBlink = (byte)(value ? 1 : 0);
        }
        public bool ConfigInputTextEnterKeepActive
        {
            get => NativePtr->ConfigInputTextEnterKeepActive != 0;
            set => NativePtr->ConfigInputTextEnterKeepActive = (byte)(value ? 1 : 0);
        }
        public bool ConfigDragClickToInputText
        {
            get => NativePtr->ConfigDragClickToInputText != 0;
            set => NativePtr->ConfigDragClickToInputText = (byte)(value ? 1 : 0);
        }
        public bool ConfigWindowsResizeFromEdges
        {
            get => NativePtr->ConfigWindowsResizeFromEdges != 0;
            set => NativePtr->ConfigWindowsResizeFromEdges = (byte)(value ? 1 : 0);
        }
        public bool ConfigWindowsMoveFromTitleBarOnly
        {
            get => NativePtr->ConfigWindowsMoveFromTitleBarOnly != 0;
            set => NativePtr->ConfigWindowsMoveFromTitleBarOnly = (byte)(value ? 1 : 0);
        }
        public bool ConfigWindowsCopyContentsWithCtrlC
        {
            get => NativePtr->ConfigWindowsCopyContentsWithCtrlC != 0;
            set => NativePtr->ConfigWindowsCopyContentsWithCtrlC = (byte)(value ? 1 : 0);
        }
        public bool ConfigScrollbarScrollByPage
        {
            get => NativePtr->ConfigScrollbarScrollByPage != 0;
            set => NativePtr->ConfigScrollbarScrollByPage = (byte)(value ? 1 : 0);
        }
        public ref float ConfigMemoryCompactTimer => ref NativePtr->ConfigMemoryCompactTimer;
        public ref float MouseDoubleClickTime => ref NativePtr->MouseDoubleClickTime;
        public ref float MouseDoubleClickMaxDist => ref NativePtr->MouseDoubleClickMaxDist;
        public ref float MouseDragThreshold => ref NativePtr->MouseDragThreshold;
        public ref float KeyRepeatDelay => ref NativePtr->KeyRepeatDelay;
        public ref float KeyRepeatRate => ref NativePtr->KeyRepeatRate;
        public bool ConfigErrorRecovery
        {
            get => NativePtr->ConfigErrorRecovery != 0;
            set => NativePtr->ConfigErrorRecovery = (byte)(value ? 1 : 0);
        }
        public bool ConfigErrorRecoveryEnableDebugLog
        {
            get => NativePtr->ConfigErrorRecoveryEnableDebugLog != 0;
            set => NativePtr->ConfigErrorRecoveryEnableDebugLog = (byte)(value ? 1 : 0);
        }
        public bool ConfigErrorRecoveryEnableTooltip
        {
            get => NativePtr->ConfigErrorRecoveryEnableTooltip != 0;
            set => NativePtr->ConfigErrorRecoveryEnableTooltip = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugIsDebuggerPresent
        {
            get => NativePtr->ConfigDebugIsDebuggerPresent != 0;
            set => NativePtr->ConfigDebugIsDebuggerPresent = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugHighlightIdConflicts
        {
            get => NativePtr->ConfigDebugHighlightIdConflicts != 0;
            set => NativePtr->ConfigDebugHighlightIdConflicts = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugBeginReturnValueOnce
        {
            get => NativePtr->ConfigDebugBeginReturnValueOnce != 0;
            set => NativePtr->ConfigDebugBeginReturnValueOnce = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugBeginReturnValueLoop
        {
            get => NativePtr->ConfigDebugBeginReturnValueLoop != 0;
            set => NativePtr->ConfigDebugBeginReturnValueLoop = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugIgnoreFocusLoss
        {
            get => NativePtr->ConfigDebugIgnoreFocusLoss != 0;
            set => NativePtr->ConfigDebugIgnoreFocusLoss = (byte)(value ? 1 : 0);
        }
        public bool ConfigDebugIniSettings
        {
            get => NativePtr->ConfigDebugIniSettings != 0;
            set => NativePtr->ConfigDebugIniSettings = (byte)(value ? 1 : 0);
        }
        public NullTerminatedString BackendPlatformName => new NullTerminatedString(NativePtr->BackendPlatformName);
        public NullTerminatedString BackendRendererName => new NullTerminatedString(NativePtr->BackendRendererName);
        public IntPtr BackendPlatformUserData { get => (IntPtr)NativePtr->BackendPlatformUserData; set => NativePtr->BackendPlatformUserData = (void*)value; }
        public IntPtr BackendRendererUserData { get => (IntPtr)NativePtr->BackendRendererUserData; set => NativePtr->BackendRendererUserData = (void*)value; }
        public IntPtr BackendLanguageUserData { get => (IntPtr)NativePtr->BackendLanguageUserData; set => NativePtr->BackendLanguageUserData = (void*)value; }
        public bool WantCaptureMouse
        {
            get => NativePtr->WantCaptureMouse != 0;
            set => NativePtr->WantCaptureMouse = (byte)(value ? 1 : 0);
        }
        public bool WantCaptureKeyboard
        {
            get => NativePtr->WantCaptureKeyboard != 0;
            set => NativePtr->WantCaptureKeyboard = (byte)(value ? 1 : 0);
        }
        public bool WantTextInput
        {
            get => NativePtr->WantTextInput != 0;
            set => NativePtr->WantTextInput = (byte)(value ? 1 : 0);
        }
        public bool WantSetMousePos
        {
            get => NativePtr->WantSetMousePos != 0;
            set => NativePtr->WantSetMousePos = (byte)(value ? 1 : 0);
        }
        public bool WantSaveIniSettings
        {
            get => NativePtr->WantSaveIniSettings != 0;
            set => NativePtr->WantSaveIniSettings = (byte)(value ? 1 : 0);
        }
        public bool NavActive
        {
            get => NativePtr->NavActive != 0;
            set => NativePtr->NavActive = (byte)(value ? 1 : 0);
        }
        public bool NavVisible
        {
            get => NativePtr->NavVisible != 0;
            set => NativePtr->NavVisible = (byte)(value ? 1 : 0);
        }
        public ref float Framerate => ref NativePtr->Framerate;
        public ref int MetricsRenderVertices => ref NativePtr->MetricsRenderVertices;
        public ref int MetricsRenderIndices => ref NativePtr->MetricsRenderIndices;
        public ref int MetricsRenderWindows => ref NativePtr->MetricsRenderWindows;
        public ref int MetricsActiveWindows => ref NativePtr->MetricsActiveWindows;
        public ref Vector2 MouseDelta => ref NativePtr->MouseDelta;
        public ref IntPtr Ctx => ref NativePtr->Ctx;
        public ref Vector2 MousePos => ref NativePtr->MousePos;
        public RangeAccessor<bool> MouseDown => new RangeAccessor<bool>(NativePtr->MouseDown, 5);
        public ref float MouseWheel => ref NativePtr->MouseWheel;
        public ref float MouseWheelH => ref NativePtr->MouseWheelH;
        public ref ImGuiMouseSource MouseSource => ref NativePtr->MouseSource;
        public ref uint MouseHoveredViewport => ref NativePtr->MouseHoveredViewport;
        public bool KeyCtrl
        {
            get => NativePtr->KeyCtrl != 0;
            set => NativePtr->KeyCtrl = (byte)(value ? 1 : 0);
        }
        public bool KeyShift
        {
            get => NativePtr->KeyShift != 0;
            set => NativePtr->KeyShift = (byte)(value ? 1 : 0);
        }
        public bool KeyAlt
        {
            get => NativePtr->KeyAlt != 0;
            set => NativePtr->KeyAlt = (byte)(value ? 1 : 0);
        }
        public bool KeySuper
        {
            get => NativePtr->KeySuper != 0;
            set => NativePtr->KeySuper = (byte)(value ? 1 : 0);
        }
        public ref ImGuiKey KeyMods => ref NativePtr->KeyMods;
        public RangeAccessor<ImGuiKeyData> KeysData => new RangeAccessor<ImGuiKeyData>(&NativePtr->KeysData_0, 154);
        public bool WantCaptureMouseUnlessPopupClose
        {
            get => NativePtr->WantCaptureMouseUnlessPopupClose != 0;
            set => NativePtr->WantCaptureMouseUnlessPopupClose = (byte)(value ? 1 : 0);
        }
        public ref Vector2 MousePosPrev => ref NativePtr->MousePosPrev;
        public RangeAccessor<Vector2> MouseClickedPos => new RangeAccessor<Vector2>(&NativePtr->MouseClickedPos_0, 5);
        public RangeAccessor<double> MouseClickedTime => new RangeAccessor<double>(NativePtr->MouseClickedTime, 5);
        public RangeAccessor<bool> MouseClicked => new RangeAccessor<bool>(NativePtr->MouseClicked, 5);
        public RangeAccessor<bool> MouseDoubleClicked => new RangeAccessor<bool>(NativePtr->MouseDoubleClicked, 5);
        public RangeAccessor<ushort> MouseClickedCount => new RangeAccessor<ushort>(NativePtr->MouseClickedCount, 5);
        public RangeAccessor<ushort> MouseClickedLastCount => new RangeAccessor<ushort>(NativePtr->MouseClickedLastCount, 5);
        public RangeAccessor<bool> MouseReleased => new RangeAccessor<bool>(NativePtr->MouseReleased, 5);
        public RangeAccessor<bool> MouseDownOwned => new RangeAccessor<bool>(NativePtr->MouseDownOwned, 5);
        public RangeAccessor<bool> MouseDownOwnedUnlessPopupClose => new RangeAccessor<bool>(NativePtr->MouseDownOwnedUnlessPopupClose, 5);
        public bool MouseWheelRequestAxisSwap
        {
            get => NativePtr->MouseWheelRequestAxisSwap != 0;
            set => NativePtr->MouseWheelRequestAxisSwap = (byte)(value ? 1 : 0);
        }
        public bool MouseCtrlLeftAsRightClick
        {
            get => NativePtr->MouseCtrlLeftAsRightClick != 0;
            set => NativePtr->MouseCtrlLeftAsRightClick = (byte)(value ? 1 : 0);
        }
        public RangeAccessor<float> MouseDownDuration => new RangeAccessor<float>(NativePtr->MouseDownDuration, 5);
        public RangeAccessor<float> MouseDownDurationPrev => new RangeAccessor<float>(NativePtr->MouseDownDurationPrev, 5);
        public RangeAccessor<Vector2> MouseDragMaxDistanceAbs => new RangeAccessor<Vector2>(&NativePtr->MouseDragMaxDistanceAbs_0, 5);
        public RangeAccessor<float> MouseDragMaxDistanceSqr => new RangeAccessor<float>(NativePtr->MouseDragMaxDistanceSqr, 5);
        public ref float PenPressure => ref NativePtr->PenPressure;
        public bool AppFocusLost
        {
            get => NativePtr->AppFocusLost != 0;
            set => NativePtr->AppFocusLost = (byte)(value ? 1 : 0);
        }
        public bool AppAcceptingEvents
        {
            get => NativePtr->AppAcceptingEvents != 0;
            set => NativePtr->AppAcceptingEvents = (byte)(value ? 1 : 0);
        }
        public ref ushort InputQueueSurrogate => ref NativePtr->InputQueueSurrogate;
        public ImVector<ushort> InputQueueCharacters => new ImVector<ushort>(NativePtr->InputQueueCharacters);
        public void AddFocusEvent(bool focused)
        {
            byte native_focused = focused ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiIO_AddFocusEvent((ImGuiIO*)(NativePtr), native_focused);
        }
        public void AddInputCharacter(uint c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacter((ImGuiIO*)(NativePtr), c);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddInputCharactersUTF8(ReadOnlySpan<char> str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.ImGuiIO_AddInputCharactersUTF8((ImGuiIO*)(NativePtr), native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
#endif
        public void AddInputCharactersUTF8(string str)
        {
            byte* native_str;
            int str_byteCount = 0;
            if (str != null)
            {
                str_byteCount = Encoding.UTF8.GetByteCount(str);
                if (str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str = Util.Allocate(str_byteCount + 1);
                }
                else
                {
                    byte* native_str_stackBytes = stackalloc byte[str_byteCount + 1];
                    native_str = native_str_stackBytes;
                }
                int native_str_offset = Util.GetUtf8(str, native_str, str_byteCount);
                native_str[native_str_offset] = 0;
            }
            else { native_str = null; }
            ImGuiNative.ImGuiIO_AddInputCharactersUTF8((ImGuiIO*)(NativePtr), native_str);
            if (str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str);
            }
        }
        public void AddInputCharacterUTF16(ushort c)
        {
            ImGuiNative.ImGuiIO_AddInputCharacterUTF16((ImGuiIO*)(NativePtr), c);
        }
        public void AddKeyAnalogEvent(ImGuiKey key, bool down, float v)
        {
            byte native_down = down ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiIO_AddKeyAnalogEvent((ImGuiIO*)(NativePtr), key, native_down, v);
        }
        public void AddKeyEvent(ImGuiKey key, bool down)
        {
            byte native_down = down ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiIO_AddKeyEvent((ImGuiIO*)(NativePtr), key, native_down);
        }
        public void AddMouseButtonEvent(int button, bool down)
        {
            byte native_down = down ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiIO_AddMouseButtonEvent((ImGuiIO*)(NativePtr), button, native_down);
        }
        public void AddMousePosEvent(float x, float y)
        {
            ImGuiNative.ImGuiIO_AddMousePosEvent((ImGuiIO*)(NativePtr), x, y);
        }
        public void AddMouseSourceEvent(ImGuiMouseSource source)
        {
            ImGuiNative.ImGuiIO_AddMouseSourceEvent((ImGuiIO*)(NativePtr), source);
        }
        public void AddMouseViewportEvent(uint id)
        {
            ImGuiNative.ImGuiIO_AddMouseViewportEvent((ImGuiIO*)(NativePtr), id);
        }
        public void AddMouseWheelEvent(float wheel_x, float wheel_y)
        {
            ImGuiNative.ImGuiIO_AddMouseWheelEvent((ImGuiIO*)(NativePtr), wheel_x, wheel_y);
        }
        public void ClearEventsQueue()
        {
            ImGuiNative.ImGuiIO_ClearEventsQueue((ImGuiIO*)(NativePtr));
        }
        public void ClearInputKeys()
        {
            ImGuiNative.ImGuiIO_ClearInputKeys((ImGuiIO*)(NativePtr));
        }
        public void ClearInputMouse()
        {
            ImGuiNative.ImGuiIO_ClearInputMouse((ImGuiIO*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiIO_destroy((ImGuiIO*)(NativePtr));
        }
        public void SetAppAcceptingEvents(bool accepting_events)
        {
            byte native_accepting_events = accepting_events ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiIO_SetAppAcceptingEvents((ImGuiIO*)(NativePtr), native_accepting_events);
        }
        public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode)
        {
            int native_legacy_index = -1;
            ImGuiNative.ImGuiIO_SetKeyEventNativeData((ImGuiIO*)(NativePtr), key, native_keycode, native_scancode, native_legacy_index);
        }
        public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index)
        {
            ImGuiNative.ImGuiIO_SetKeyEventNativeData((ImGuiIO*)(NativePtr), key, native_keycode, native_scancode, native_legacy_index);
        }
    }
}
