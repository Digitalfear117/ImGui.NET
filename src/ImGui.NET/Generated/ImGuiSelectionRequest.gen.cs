using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionRequest
    {
        public ImGuiSelectionRequestType Type;
        public byte Selected;
        public sbyte RangeDirection;
        public long RangeFirstItem;
        public long RangeLastItem;
    }
    public unsafe partial struct ImGuiSelectionRequestPtr
    {
        public ImGuiSelectionRequest* NativePtr { get; }
        public ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionRequest*)nativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public static implicit operator ImGuiSelectionRequest* (ImGuiSelectionRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(IntPtr nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public ref ImGuiSelectionRequestType Type => ref NativePtr->Type;
        public bool Selected
        {
            get => NativePtr->Selected != 0;
            set => NativePtr->Selected = (byte)(value ? 1 : 0);
        }
        public ref sbyte RangeDirection => ref NativePtr->RangeDirection;
        public ref long RangeFirstItem => ref NativePtr->RangeFirstItem;
        public ref long RangeLastItem => ref NativePtr->RangeLastItem;
    }
}
