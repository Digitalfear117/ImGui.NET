using System;

public unsafe struct ImVector
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;

    public ImVector(int size, int capacity, IntPtr data)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
    }

    public ref T Ref<T>(int index) where T : unmanaged
    {
        if (index < 0 || index >= Size) throw new IndexOutOfRangeException();
        byte* basePtr = (byte*)Data;
        return ref *(T*)(basePtr + index * sizeof(T));
    }

    public IntPtr Address<T>(int index) where T : unmanaged
    {
        if (index < 0 || index >= Size) throw new IndexOutOfRangeException();
        byte* basePtr = (byte*)Data;
        return (IntPtr)(basePtr + index * sizeof(T));
    }
}

public unsafe struct ImVector<T> where T : unmanaged
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;

    public ImVector(ImVector vector)
    {
        Size = vector.Size;
        Capacity = vector.Capacity;
        Data = vector.Data;
    }

    public ImVector(int size, int capacity, IntPtr data)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
    }

    public ref T this[int index]
    {
        get
        {
            if (index < 0 || index >= Size) throw new IndexOutOfRangeException();
            byte* basePtr = (byte*)Data;
            return ref *(T*)(basePtr + index * sizeof(T));
        }
    }
}

public unsafe struct ImPtrVector<T> where T : unmanaged
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;
    private readonly int _stride;

    public ImPtrVector(ImVector vector, int stride)
        : this(vector.Size, vector.Capacity, vector.Data, stride)
    { }

    public ImPtrVector(int size, int capacity, IntPtr data, int stride)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
        _stride = stride;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Size) throw new IndexOutOfRangeException();
            byte* address = (byte*)Data + index * _stride;
            return *(T*)address;
        }
    }
}
