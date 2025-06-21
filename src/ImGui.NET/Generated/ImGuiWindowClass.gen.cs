using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiWindowClass
    {
        public uint ClassId;
        public uint ParentViewportId;
        public uint FocusRouteParentWindowId;
        public ImGuiViewportFlags ViewportFlagsOverrideSet;
        public ImGuiViewportFlags ViewportFlagsOverrideClear;
        public ImGuiTabItemFlags TabItemFlagsOverrideSet;
        public ImGuiDockNodeFlags DockNodeFlagsOverrideSet;
        public byte DockingAlwaysTabBar;
        public byte DockingAllowUnclassed;
    }
    public unsafe partial struct ImGuiWindowClassPtr
    {
        public ImGuiWindowClass* NativePtr { get; }
        public ImGuiWindowClassPtr(ImGuiWindowClass* nativePtr) => NativePtr = nativePtr;
        public ImGuiWindowClassPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowClass*)nativePtr;
        public static implicit operator ImGuiWindowClassPtr(ImGuiWindowClass* nativePtr) => new ImGuiWindowClassPtr(nativePtr);
        public static implicit operator ImGuiWindowClass* (ImGuiWindowClassPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiWindowClassPtr(IntPtr nativePtr) => new ImGuiWindowClassPtr(nativePtr);
        public ref uint ClassId => ref NativePtr->ClassId;
        public ref uint ParentViewportId => ref NativePtr->ParentViewportId;
        public ref uint FocusRouteParentWindowId => ref NativePtr->FocusRouteParentWindowId;
        public ref ImGuiViewportFlags ViewportFlagsOverrideSet => ref NativePtr->ViewportFlagsOverrideSet;
        public ref ImGuiViewportFlags ViewportFlagsOverrideClear => ref NativePtr->ViewportFlagsOverrideClear;
        public ref ImGuiTabItemFlags TabItemFlagsOverrideSet => ref NativePtr->TabItemFlagsOverrideSet;
        public ref ImGuiDockNodeFlags DockNodeFlagsOverrideSet => ref NativePtr->DockNodeFlagsOverrideSet;
        public bool DockingAlwaysTabBar
        {
            get => NativePtr->DockingAlwaysTabBar != 0;
            set => NativePtr->DockingAlwaysTabBar = (byte)(value ? 1 : 0);
        }
        public bool DockingAllowUnclassed
        {
            get => NativePtr->DockingAllowUnclassed != 0;
            set => NativePtr->DockingAllowUnclassed = (byte)(value ? 1 : 0);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiWindowClass_destroy((ImGuiWindowClass*)(NativePtr));
        }
    }
}
