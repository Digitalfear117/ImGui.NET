using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableSortSpecs
    {
        public ImGuiTableColumnSortSpecs* Specs;
        public int SpecsCount;
        public byte SpecsDirty;
    }
    public unsafe partial struct ImGuiTableSortSpecsPtr
    {
        public ImGuiTableSortSpecs* NativePtr { get; }
        public ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSortSpecs*)nativePtr;
        public static implicit operator ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);
        public static implicit operator ImGuiTableSortSpecs* (ImGuiTableSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);
        public ImGuiTableColumnSortSpecsPtr Specs => new ImGuiTableColumnSortSpecsPtr(NativePtr->Specs);
        public ref int SpecsCount => ref NativePtr->SpecsCount;
        public bool SpecsDirty
        {
            get => NativePtr->SpecsDirty != 0;
            set => NativePtr->SpecsDirty = (byte)(value ? 1 : 0);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiTableSortSpecs_destroy((ImGuiTableSortSpecs*)(NativePtr));
        }
    }
}
