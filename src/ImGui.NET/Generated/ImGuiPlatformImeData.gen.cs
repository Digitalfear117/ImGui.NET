using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiPlatformImeData
    {
        public byte WantVisible;
        public Vector2 InputPos;
        public float InputLineHeight;
    }
    public unsafe partial struct ImGuiPlatformImeDataPtr
    {
        public ImGuiPlatformImeData* NativePtr { get; }
        public ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => NativePtr = nativePtr;
        public ImGuiPlatformImeDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformImeData*)nativePtr;
        public static implicit operator ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => new ImGuiPlatformImeDataPtr(nativePtr);
        public static implicit operator ImGuiPlatformImeData* (ImGuiPlatformImeDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPlatformImeDataPtr(IntPtr nativePtr) => new ImGuiPlatformImeDataPtr(nativePtr);
        public bool WantVisible
        {
            get => NativePtr->WantVisible != 0;
            set => NativePtr->WantVisible = (byte)(value ? 1 : 0);
        }
        public ref Vector2 InputPos => ref NativePtr->InputPos;
        public ref float InputLineHeight => ref NativePtr->InputLineHeight;
        public void Destroy()
        {
            ImGuiNative.ImGuiPlatformImeData_destroy((ImGuiPlatformImeData*)(NativePtr));
        }
    }
}
