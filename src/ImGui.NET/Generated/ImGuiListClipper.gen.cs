using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiListClipper
    {
        public IntPtr Ctx;
        public int DisplayStart;
        public int DisplayEnd;
        public int ItemsCount;
        public float ItemsHeight;
        public float StartPosY;
        public double StartSeekOffsetY;
        public void* TempData;
    }
    public unsafe partial struct ImGuiListClipperPtr
    {
        public ImGuiListClipper* NativePtr { get; }
        public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
        public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
        public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) => new ImGuiListClipperPtr(nativePtr);
        public ref IntPtr Ctx => ref NativePtr->Ctx;
        public ref int DisplayStart => ref NativePtr->DisplayStart;
        public ref int DisplayEnd => ref NativePtr->DisplayEnd;
        public ref int ItemsCount => ref NativePtr->ItemsCount;
        public ref float ItemsHeight => ref NativePtr->ItemsHeight;
        public ref float StartPosY => ref NativePtr->StartPosY;
        public ref double StartSeekOffsetY => ref NativePtr->StartSeekOffsetY;
        public IntPtr TempData { get => (IntPtr)NativePtr->TempData; set => NativePtr->TempData = (void*)value; }
        public void Begin(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_Begin((ImGuiListClipper*)(NativePtr), items_count, items_height);
        }
        public void Begin(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_Begin((ImGuiListClipper*)(NativePtr), items_count, items_height);
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiListClipper_destroy((ImGuiListClipper*)(NativePtr));
        }
        public void End()
        {
            ImGuiNative.ImGuiListClipper_End((ImGuiListClipper*)(NativePtr));
        }
        public void IncludeItemByIndex(int item_index)
        {
            ImGuiNative.ImGuiListClipper_IncludeItemByIndex((ImGuiListClipper*)(NativePtr), item_index);
        }
        public void SeekCursorForItem(int item_index)
        {
            ImGuiNative.ImGuiListClipper_SeekCursorForItem((ImGuiListClipper*)(NativePtr), item_index);
        }
        public bool Step()
        {
            byte ret = ImGuiNative.ImGuiListClipper_Step((ImGuiListClipper*)(NativePtr));
            return ret != 0;
        }
    }
}
