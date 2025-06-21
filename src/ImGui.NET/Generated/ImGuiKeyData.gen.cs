using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiKeyData
    {
        public byte Down;
        public float DownDuration;
        public float DownDurationPrev;
        public float AnalogValue;
    }
    public unsafe partial struct ImGuiKeyDataPtr
    {
        public ImGuiKeyData* NativePtr { get; }
        public ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => NativePtr = nativePtr;
        public ImGuiKeyDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyData*)nativePtr;
        public static implicit operator ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => new ImGuiKeyDataPtr(nativePtr);
        public static implicit operator ImGuiKeyData* (ImGuiKeyDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiKeyDataPtr(IntPtr nativePtr) => new ImGuiKeyDataPtr(nativePtr);
        public bool Down
        {
            get => NativePtr->Down != 0;
            set => NativePtr->Down = (byte)(value ? 1 : 0);
        }
        public ref float DownDuration => ref NativePtr->DownDuration;
        public ref float DownDurationPrev => ref NativePtr->DownDurationPrev;
        public ref float AnalogValue => ref NativePtr->AnalogValue;
    }
}
