using System.Text;

namespace ImGuiNET
{
    public unsafe struct NullTerminatedString
    {
        public readonly byte* Data;

        public NullTerminatedString(byte* data)
        {
            Data = data;
        }

        public override string ToString()
        {
            if (Data == null) return string.Empty;
            int length = 0;
            byte* ptr = Data;
            while (*ptr != 0)
            {
                length++;
                ptr++;
            }
            byte[] buffer = new byte[length];
            for (int i = 0; i < length; i++)
            {
                buffer[i] = Data[i];
            }
            return Encoding.ASCII.GetString(buffer);
        }

        public static implicit operator string(NullTerminatedString nts) => nts.ToString();
    }
}
