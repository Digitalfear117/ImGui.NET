using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawData
    {
        public byte Valid;
        public int CmdListsCount;
        public int TotalIdxCount;
        public int TotalVtxCount;
        public ImVector CmdLists;
        public Vector2 DisplayPos;
        public Vector2 DisplaySize;
        public Vector2 FramebufferScale;
        public ImGuiViewport* OwnerViewport;
    }
    public unsafe partial struct ImDrawDataPtr
    {
        public ImDrawData* NativePtr { get; }
        public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
        public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new ImDrawDataPtr(nativePtr);
        public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new ImDrawDataPtr(nativePtr);
        public bool Valid
        {
            get => NativePtr->Valid != 0;
            set => NativePtr->Valid = (byte)(value ? 1 : 0);
        }

        public ref int CmdListsCount => ref NativePtr->CmdListsCount;
        public ref int TotalIdxCount => ref NativePtr->TotalIdxCount;
        public ref int TotalVtxCount => ref NativePtr->TotalVtxCount;
        public ImVector<ImDrawListPtr> CmdLists => new ImVector<ImDrawListPtr>(NativePtr->CmdLists);
        public ref Vector2 DisplayPos => ref NativePtr->DisplayPos;
        public ref Vector2 DisplaySize => ref NativePtr->DisplaySize;
        public ref Vector2 FramebufferScale => ref NativePtr->FramebufferScale;

        public ImGuiViewportPtr OwnerViewport => new ImGuiViewportPtr(NativePtr->OwnerViewport);
        public void AddDrawList(ImDrawListPtr draw_list)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            ImGuiNative.ImDrawData_AddDrawList((ImDrawData*)(NativePtr), native_draw_list);
        }
        public void Clear()
        {
            ImGuiNative.ImDrawData_Clear((ImDrawData*)(NativePtr));
        }
        public void DeIndexAllBuffers()
        {
            ImGuiNative.ImDrawData_DeIndexAllBuffers((ImDrawData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawData_destroy((ImDrawData*)(NativePtr));
        }
        public void ScaleClipRects(Vector2 fb_scale)
        {
            ImGuiNative.ImDrawData_ScaleClipRects((ImDrawData*)(NativePtr), fb_scale);
        }
    }
}
