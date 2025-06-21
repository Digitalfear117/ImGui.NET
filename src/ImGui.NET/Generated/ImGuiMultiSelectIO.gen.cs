using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMultiSelectIO
    {
        public ImVector Requests;
        public long RangeSrcItem;
        public long NavIdItem;
        public byte NavIdSelected;
        public byte RangeSrcReset;
        public int ItemsCount;
    }
    public unsafe partial struct ImGuiMultiSelectIOPtr
    {
        public ImGuiMultiSelectIO* NativePtr { get; }
        public ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiMultiSelectIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectIO*)nativePtr;
        public static implicit operator ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);
        public static implicit operator ImGuiMultiSelectIO* (ImGuiMultiSelectIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMultiSelectIOPtr(IntPtr nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);
        public ImPtrVector<ImGuiSelectionRequestPtr> Requests => new ImPtrVector<ImGuiSelectionRequestPtr>(NativePtr->Requests, sizeof(ImGuiSelectionRequest));
        public ref long RangeSrcItem => ref NativePtr->RangeSrcItem;
        public ref long NavIdItem => ref NativePtr->NavIdItem;
        public bool NavIdSelected
        {
            get => NativePtr->NavIdSelected != 0;
            set => NativePtr->NavIdSelected = (byte)(value ? 1 : 0);
        }
        public bool RangeSrcReset
        {
            get => NativePtr->RangeSrcReset != 0;
            set => NativePtr->RangeSrcReset = (byte)(value ? 1 : 0);
        }
        public ref int ItemsCount => ref NativePtr->ItemsCount;
    }
}
