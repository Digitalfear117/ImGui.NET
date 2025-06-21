using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct RangeAccessor<T> where T : struct
    {
        private static readonly int s_sizeOfT = Marshal.SizeOf(typeof(T));

        public readonly void* Data;
        public readonly int Count;

        public RangeAccessor(IntPtr data, int count) : this(data.ToPointer(), count) { }
        public RangeAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public ref T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                byte* basePtr = (byte*)Data;
                T* elementPtr = (T*)(basePtr + s_sizeOfT * index);
                return ref *elementPtr;
            }
        }
    }

    public unsafe struct RangePtrAccessor<T> where T : struct
    {
        private static readonly int s_sizeOfT = Marshal.SizeOf(typeof(T));

        public readonly void* Data;
        public readonly int Count;

        public RangePtrAccessor(IntPtr data, int count) : this(data.ToPointer(), count) { }
        public RangePtrAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                // If Data is pointer to contiguous array of T:
                byte* basePtr = (byte*)Data;
                T* elementPtr = (T*)(basePtr + s_sizeOfT * index);
                return *elementPtr;

                // If Data is pointer to array of pointers to T, use:
                // void** ptrs = (void**)Data;
                // void* addr = ptrs[index];
                // return *(T*)addr;
            }
        }
    }

    public static class RangeAccessorExtensions
    {
        public static unsafe string GetStringASCII(this RangeAccessor<byte> stringAccessor)
        {
            if (stringAccessor.Data == null || stringAccessor.Count <= 0)
                return string.Empty;
            int len = stringAccessor.Count;
            byte[] buffer = new byte[len];
            // copy from unmanaged pointer to managed array
            Marshal.Copy((IntPtr)stringAccessor.Data, buffer, 0, len);
            return Encoding.ASCII.GetString(buffer);
        }
    }
}
