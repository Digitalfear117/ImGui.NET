using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableColumnSortSpecs
    {
        public uint ColumnUserID;
        public short ColumnIndex;
        public short SortOrder;
        public ImGuiSortDirection SortDirection;
    }
    public unsafe partial struct ImGuiTableColumnSortSpecsPtr
    {
        public ImGuiTableColumnSortSpecs* NativePtr { get; }
        public ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSortSpecs*)nativePtr;
        public static implicit operator ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);
        public static implicit operator ImGuiTableColumnSortSpecs* (ImGuiTableColumnSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);
        public ref uint ColumnUserID => ref NativePtr->ColumnUserID;
        public ref short ColumnIndex => ref NativePtr->ColumnIndex;
        public ref short SortOrder => ref NativePtr->SortOrder;
        public ref ImGuiSortDirection SortDirection => ref NativePtr->SortDirection;
        public void Destroy()
        {
            ImGuiNative.ImGuiTableColumnSortSpecs_destroy((ImGuiTableColumnSortSpecs*)(NativePtr));
        }
    }
}
