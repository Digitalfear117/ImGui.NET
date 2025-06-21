using System;
using SlimDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiPlatformIO
    {
        public IntPtr Platform_GetClipboardTextFn;
        public IntPtr Platform_SetClipboardTextFn;
        public void* Platform_ClipboardUserData;
        public IntPtr Platform_OpenInShellFn;
        public void* Platform_OpenInShellUserData;
        public IntPtr Platform_SetImeDataFn;
        public void* Platform_ImeUserData;
        public ushort Platform_LocaleDecimalPoint;
        public void* Renderer_RenderState;
        public IntPtr Platform_CreateWindow;
        public IntPtr Platform_DestroyWindow;
        public IntPtr Platform_ShowWindow;
        public IntPtr Platform_SetWindowPos;
        public IntPtr Platform_GetWindowPos;
        public IntPtr Platform_SetWindowSize;
        public IntPtr Platform_GetWindowSize;
        public IntPtr Platform_SetWindowFocus;
        public IntPtr Platform_GetWindowFocus;
        public IntPtr Platform_GetWindowMinimized;
        public IntPtr Platform_SetWindowTitle;
        public IntPtr Platform_SetWindowAlpha;
        public IntPtr Platform_UpdateWindow;
        public IntPtr Platform_RenderWindow;
        public IntPtr Platform_SwapBuffers;
        public IntPtr Platform_GetWindowDpiScale;
        public IntPtr Platform_OnChangedViewport;
        public IntPtr Platform_GetWindowWorkAreaInsets;
        public IntPtr Platform_CreateVkSurface;
        public IntPtr Renderer_CreateWindow;
        public IntPtr Renderer_DestroyWindow;
        public IntPtr Renderer_SetWindowSize;
        public IntPtr Renderer_RenderWindow;
        public IntPtr Renderer_SwapBuffers;
        public ImVector Monitors;
        public ImVector Viewports;
    }
    public unsafe partial struct ImGuiPlatformIOPtr
    {
        public ImGuiPlatformIO* NativePtr { get; }
        public ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiPlatformIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformIO*)nativePtr;
        public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => new ImGuiPlatformIOPtr(nativePtr);
        public static implicit operator ImGuiPlatformIO* (ImGuiPlatformIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPlatformIOPtr(IntPtr nativePtr) => new ImGuiPlatformIOPtr(nativePtr);
        public ref IntPtr Platform_GetClipboardTextFn => ref NativePtr->Platform_GetClipboardTextFn;
        public ref IntPtr Platform_SetClipboardTextFn => ref NativePtr->Platform_SetClipboardTextFn;
        public IntPtr Platform_ClipboardUserData { get => (IntPtr)NativePtr->Platform_ClipboardUserData; set => NativePtr->Platform_ClipboardUserData = (void*)value; }
        public ref IntPtr Platform_OpenInShellFn => ref NativePtr->Platform_OpenInShellFn;
        public IntPtr Platform_OpenInShellUserData { get => (IntPtr)NativePtr->Platform_OpenInShellUserData; set => NativePtr->Platform_OpenInShellUserData = (void*)value; }
        public ref IntPtr Platform_SetImeDataFn => ref NativePtr->Platform_SetImeDataFn;
        public IntPtr Platform_ImeUserData { get => (IntPtr)NativePtr->Platform_ImeUserData; set => NativePtr->Platform_ImeUserData = (void*)value; }
        public ref ushort Platform_LocaleDecimalPoint => ref NativePtr->Platform_LocaleDecimalPoint;
        public IntPtr Renderer_RenderState { get => (IntPtr)NativePtr->Renderer_RenderState; set => NativePtr->Renderer_RenderState = (void*)value; }
        public ref IntPtr Platform_CreateWindow => ref NativePtr->Platform_CreateWindow;
        public ref IntPtr Platform_DestroyWindow => ref NativePtr->Platform_DestroyWindow;
        public ref IntPtr Platform_ShowWindow => ref NativePtr->Platform_ShowWindow;
        public ref IntPtr Platform_SetWindowPos => ref NativePtr->Platform_SetWindowPos;
        public ref IntPtr Platform_GetWindowPos => ref NativePtr->Platform_GetWindowPos;
        public ref IntPtr Platform_SetWindowSize => ref NativePtr->Platform_SetWindowSize;
        public ref IntPtr Platform_GetWindowSize => ref NativePtr->Platform_GetWindowSize;
        public ref IntPtr Platform_SetWindowFocus => ref NativePtr->Platform_SetWindowFocus;
        public ref IntPtr Platform_GetWindowFocus => ref NativePtr->Platform_GetWindowFocus;
        public ref IntPtr Platform_GetWindowMinimized => ref NativePtr->Platform_GetWindowMinimized;
        public ref IntPtr Platform_SetWindowTitle => ref NativePtr->Platform_SetWindowTitle;
        public ref IntPtr Platform_SetWindowAlpha => ref NativePtr->Platform_SetWindowAlpha;
        public ref IntPtr Platform_UpdateWindow => ref NativePtr->Platform_UpdateWindow;
        public ref IntPtr Platform_RenderWindow => ref NativePtr->Platform_RenderWindow;
        public ref IntPtr Platform_SwapBuffers => ref NativePtr->Platform_SwapBuffers;
        public ref IntPtr Platform_GetWindowDpiScale => ref NativePtr->Platform_GetWindowDpiScale;
        public ref IntPtr Platform_OnChangedViewport => ref NativePtr->Platform_OnChangedViewport;
        public ref IntPtr Platform_GetWindowWorkAreaInsets => ref NativePtr->Platform_GetWindowWorkAreaInsets;
        public ref IntPtr Platform_CreateVkSurface => ref NativePtr->Platform_CreateVkSurface;
        public ref IntPtr Renderer_CreateWindow => ref NativePtr->Renderer_CreateWindow;
        public ref IntPtr Renderer_DestroyWindow => ref NativePtr->Renderer_DestroyWindow;
        public ref IntPtr Renderer_SetWindowSize => ref NativePtr->Renderer_SetWindowSize;
        public ref IntPtr Renderer_RenderWindow => ref NativePtr->Renderer_RenderWindow;
        public ref IntPtr Renderer_SwapBuffers => ref NativePtr->Renderer_SwapBuffers;
        public ImPtrVector<ImGuiPlatformMonitorPtr> Monitors => new ImPtrVector<ImGuiPlatformMonitorPtr>(NativePtr->Monitors, sizeof(ImGuiPlatformMonitor));
        public ImVector<ImGuiViewportPtr> Viewports => new ImVector<ImGuiViewportPtr>(NativePtr->Viewports);
        public void Destroy()
        {
            ImGuiNative.ImGuiPlatformIO_destroy((ImGuiPlatformIO*)(NativePtr));
        }
    }
}
