using Native;
using NStandard;
using System;
using System.Linq;
using System.Text;
using static NWin32.NativeConstants;
using static NWin32.NativeMethods;

namespace NWin32
{
    public class MemoryAccessor : IDisposable
    {
        public int TargetPointerLength { get; private set; }
        public IntPtr HProcess { get; private set; }
        public PointerEvaluator PointerEvaluator;

        public MemoryAccessor(uint pid, int targetPointerLength = 4, uint dwDesiredAccess = PROCESS_ALL_ACCESS | PROCESS_VM_READ | PROCESS_VM_WRITE)
        {
            if (new[] { 4, 8 }.Contains(targetPointerLength))
            {
                HProcess = OpenProcess(dwDesiredAccess, false, pid);
                TargetPointerLength = targetPointerLength;
                PointerEvaluator = new PointerEvaluator(this);
            }
            else throw new ArgumentException("The `TargetPointerLength` must be 4(x86) or 8(x64).");
        }

        public void Dispose() => CloseHandle(HProcess);

        private IntPtr GetTargetPtr(string lpBaseAddress) => new IntPtr((long)PointerEvaluator.Compile<Func<double>>(lpBaseAddress)());

        public TRet Read<TRet>(int lpBaseAddress, int readLength, Func<byte[], TRet> convert) => Read(new IntPtr(lpBaseAddress), readLength, convert);
        public TRet Read<TRet>(long lpBaseAddress, int readLength, Func<byte[], TRet> convert) => Read(new IntPtr(lpBaseAddress), readLength, convert);
        public TRet Read<TRet>(string lpBaseAddress, int readLength, Func<byte[], TRet> convert) => Read(GetTargetPtr(lpBaseAddress), readLength, convert);
        public unsafe TRet Read<TRet>(void* lpBaseAddress, int readLength, Func<byte[], TRet> convert) => Read(new IntPtr(lpBaseAddress), readLength, convert);
        public TRet Read<TRet>(IntPtr lpBaseAddress, int readLength, Func<byte[], TRet> convert)
        {
            using (var buffer = new AutoIntPtr<byte[]>(readLength))
            using (var numberOfBytesRead = new AutoIntPtr<int>())
            {
                ReadProcessMemory(HProcess, lpBaseAddress, buffer, (uint)readLength, numberOfBytesRead);
                return convert(buffer.Value);
            }
        }

        public void Write<TWrite>(int lpBaseAddress, TWrite value) => Write(new IntPtr(lpBaseAddress), value);
        public void Write<TWrite>(long lpBaseAddress, TWrite value) => Write(new IntPtr(lpBaseAddress), value);
        public void Write<TWrite>(string lpBaseAddress, TWrite value) => Write(GetTargetPtr(lpBaseAddress), value);
        public unsafe void Write<TWrite>(void* lpBaseAddress, TWrite value) => Write(new IntPtr(lpBaseAddress), value);
        public void Write<TWrite>(IntPtr lpBaseAddress, TWrite value)
        {
            AutoIntPtr<TWrite> buffer;

            if (typeof(TWrite).IsArray)
                buffer = new AutoIntPtr<TWrite>((value as Array).Length);
            else buffer = new AutoIntPtr<TWrite>();

            using (var numberOfBytesWritten = new AutoIntPtr<int>())
            {
                buffer.Value = value;
                WriteProcessMemory(HProcess, lpBaseAddress, buffer, (uint)buffer.Length, numberOfBytesWritten);
            }
        }

        public IntPtr this[int lpBaseAddress] => Ptr(lpBaseAddress);
        public IntPtr this[long lpBaseAddress] => Ptr(lpBaseAddress);
        public IntPtr this[string lpBaseAddress] => Ptr(lpBaseAddress);
        public unsafe IntPtr this[void* lpBaseAddress] => Ptr(lpBaseAddress);
        public IntPtr this[IntPtr lpBaseAddress] => Ptr(lpBaseAddress);

        public IntPtr Ptr(int lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public IntPtr Ptr(long lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public IntPtr Ptr(string lpBaseAddress) => Ptr(GetTargetPtr(lpBaseAddress));
        public unsafe IntPtr Ptr(void* lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public IntPtr Ptr(IntPtr lpBaseAddress)
        {
            return TargetPointerLength switch
            {
                8 => Read(lpBaseAddress, TargetPointerLength, (bytes) => new IntPtr(BitConverter.ToInt64(bytes, 0))),
                4 => Read(lpBaseAddress, TargetPointerLength, (bytes) => new IntPtr(BitConverter.ToInt32(bytes, 0))),
                _ => throw new NotSupportedException(),
            };
        }

        public byte B(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public byte B(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public byte B(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public unsafe byte B(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public byte B(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(byte), (bytes) => bytes[0]);

        public sbyte SB(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public sbyte SB(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public sbyte SB(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public unsafe sbyte SB(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public sbyte SB(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(sbyte), (bytes) => (sbyte)bytes[0]);

        public char C(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public char C(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public char C(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public unsafe char C(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public char C(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));

        public short I2(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public short I2(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public short I2(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public unsafe short I2(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public short I2(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));

        public uint U2(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public uint U2(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public uint U2(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public unsafe uint U2(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public uint U2(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));

        public int I4(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public int I4(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public int I4(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public unsafe int I4(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public int I4(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));

        public uint U4(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public uint U4(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public uint U4(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public unsafe uint U4(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public uint U4(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));

        public long I8(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public long I8(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public long I8(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public unsafe long I8(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public long I8(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));

        public ulong U8(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public ulong U8(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public ulong U8(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public unsafe ulong U8(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public ulong U8(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));

        public float F(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public float F(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public float F(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public unsafe float F(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public float F(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));

        public double D(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public double D(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public double D(string lpBaseAddress) => Read(GetTargetPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public unsafe double D(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public double D(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));

        public string String(int lpBaseAddress, int length, Encoding encoding) => Read(new IntPtr(lpBaseAddress), length, (bytes) => BufferConvertToString(bytes, encoding));
        public string String(long lpBaseAddress, int length, Encoding encoding) => Read(new IntPtr(lpBaseAddress), length, (bytes) => BufferConvertToString(bytes, encoding));
        public string String(string lpBaseAddress, int length, Encoding encoding) => Read(GetTargetPtr(lpBaseAddress), length, (bytes) => BufferConvertToString(bytes, encoding));
        public unsafe string String(void* lpBaseAddress, int length, Encoding encoding) => Read(new IntPtr(lpBaseAddress), length, (bytes) => BufferConvertToString(bytes, encoding));
        public string String(IntPtr lpBaseAddress, int length, Encoding encoding) => Read(lpBaseAddress, length, (bytes) => BufferConvertToString(bytes, encoding));

        public byte[] Buffer(int lpBaseAddress, int length) => Read(new IntPtr(lpBaseAddress), length, BufferConvert);
        public byte[] Buffer(long lpBaseAddress, int length) => Read(new IntPtr(lpBaseAddress), length, BufferConvert);
        public byte[] Buffer(string lpBaseAddress, int length) => Read(GetTargetPtr(lpBaseAddress), length, BufferConvert);
        public unsafe byte[] Buffer(void* lpBaseAddress, int length) => Read(new IntPtr(lpBaseAddress), length, BufferConvert);
        public byte[] Buffer(IntPtr lpBaseAddress, int length) => Read(lpBaseAddress, length, BufferConvert);

        private byte[] BufferConvert(byte[] bytes)
        {
            var ret = new byte[bytes.Length];
            Array.Copy(bytes, ret, ret.Length);
            return ret;
        }

        private string BufferConvertToString(byte[] bytes, Encoding encoding)
        {
            return encoding.GetString(bytes);
        }

    }
}
