using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlasCustomRect
    {
        public ushort X;
        public ushort Y;
        public ushort Width;
        public ushort Height;
        public uint GlyphID;
        public uint GlyphColored;
        public float GlyphAdvanceX;
        public Vector2 GlyphOffset;
        public ImFont* Font;
    }
    public unsafe partial struct ImFontAtlasCustomRectPtr
    {
        public ImFontAtlasCustomRect* NativePtr { get; }
        public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasCustomRectPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasCustomRect*)nativePtr;
        public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => new ImFontAtlasCustomRectPtr(nativePtr);
        public static implicit operator ImFontAtlasCustomRect* (ImFontAtlasCustomRectPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasCustomRectPtr(IntPtr nativePtr) => new ImFontAtlasCustomRectPtr(nativePtr);
        public ref ushort X => ref NativePtr->X;
        public ref ushort Y => ref NativePtr->Y;
        public ref ushort Width => ref NativePtr->Width;
        public ref ushort Height => ref NativePtr->Height;
        public ref uint GlyphID => ref NativePtr->GlyphID;
        public ref uint GlyphColored => ref NativePtr->GlyphColored;
        public ref float GlyphAdvanceX => ref NativePtr->GlyphAdvanceX;
        public ref Vector2 GlyphOffset => ref NativePtr->GlyphOffset;
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public void Destroy()
        {
            ImGuiNative.ImFontAtlasCustomRect_destroy((ImFontAtlasCustomRect*)(NativePtr));
        }
        public bool IsPacked()
        {
            byte ret = ImGuiNative.ImFontAtlasCustomRect_IsPacked((ImFontAtlasCustomRect*)(NativePtr));
            return ret != 0;
        }
    }
}
