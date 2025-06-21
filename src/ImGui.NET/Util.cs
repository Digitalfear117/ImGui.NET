using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    internal static unsafe class Util
    {
        internal const int StackAllocationSizeLimit = 2048;

        public static string StringFromPtr(byte* ptr)
        {
            if (ptr == null) return string.Empty;
            int length = 0;
            while (ptr[length] != 0) length++;
            if (length == 0) return string.Empty;
            byte[] buffer = new byte[length];
            // copy from unmanaged memory
            Marshal.Copy((IntPtr)ptr, buffer, 0, length);
            return Encoding.UTF8.GetString(buffer, 0, length);
        }

        internal static bool AreStringsEqual(byte* a, int aLength, byte* b)
        {
            if (a == null || b == null) return false;
            for (int i = 0; i < aLength; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return b[aLength] == 0;
        }

        internal static byte* Allocate(int byteCount) => (byte*)Marshal.AllocHGlobal(byteCount);

        internal static void Free(byte* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

        // If you need CalcSizeInUtf8 or GetUtf8 on .NET 3.5, use managed buffers:
        internal static int CalcSizeInUtf8(string s, int start, int length)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (start < 0 || length < 0 || start + length > s.Length)
                throw new ArgumentOutOfRangeException();
            if (length == 0) return 0;
            // copy substring into char[]
            char[] chars = new char[length];
            s.CopyTo(start, chars, 0, length);
            return Encoding.UTF8.GetByteCount(chars, 0, length);
        }

        internal static int GetUtf8(string s, byte* utf8Bytes, int utf8ByteCount)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            int needed = Encoding.UTF8.GetByteCount(s);
            if (utf8ByteCount < needed) throw new ArgumentException("Buffer too small", nameof(utf8ByteCount));
            byte[] managed = new byte[needed];
            Encoding.UTF8.GetBytes(s, 0, s.Length, managed, 0);
            Marshal.Copy(managed, 0, (IntPtr)utf8Bytes, needed);
            return needed;
        }

        internal static int GetUtf8(string s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (start < 0 || length < 0 || start + length > s.Length)
                throw new ArgumentOutOfRangeException();
            if (length == 0) return 0;
            // copy substring
            char[] chars = new char[length];
            s.CopyTo(start, chars, 0, length);
            int needed = Encoding.UTF8.GetByteCount(chars, 0, length);
            if (utf8ByteCount < needed) throw new ArgumentException("Buffer too small", nameof(utf8ByteCount));
            byte[] managed = new byte[needed];
            Encoding.UTF8.GetBytes(chars, 0, length, managed, 0);
            Marshal.Copy(managed, 0, (IntPtr)utf8Bytes, needed);
            return needed;
        }
    }
}
