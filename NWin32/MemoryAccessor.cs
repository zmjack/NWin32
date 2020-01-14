using NMarshal;
using System;
using System.Linq;
using static NWin32.NativeConstants;
using static NWin32.NativeMethods;

namespace NWin32
{
    public class MemoryAccessor : IDisposable
    {
        public int TargetPointerLength { get; private set; }
        public IntPtr HProcess { get; private set; }

        public MemoryAccessor(uint pid, int targetPointerLength = 4, uint dwDesiredAccess = PROCESS_ALL_ACCESS | PROCESS_VM_READ | PROCESS_VM_WRITE)
        {
            if (new[] { 4, 8 }.Contains(targetPointerLength))
            {
                HProcess = OpenProcess(dwDesiredAccess, false, pid);
                TargetPointerLength = targetPointerLength;
            }
            else throw new ArgumentException("The `TargetPointerLength` must be 4(x86) or 8(x64).");
        }

        public void Dispose() => CloseHandle(HProcess);

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
        public unsafe IntPtr this[void* lpBaseAddress] => Ptr(lpBaseAddress);
        public IntPtr this[IntPtr lpBaseAddress] => Ptr(lpBaseAddress);

        public IntPtr Ptr(int lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public IntPtr Ptr(long lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public unsafe IntPtr Ptr(void* lpBaseAddress) => Ptr(new IntPtr(lpBaseAddress));
        public IntPtr Ptr(IntPtr lpBaseAddress) => Read(lpBaseAddress, TargetPointerLength, (bytes) => new IntPtr(BitConverter.ToInt32(bytes, 0)));

        public byte B(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public byte B(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public unsafe byte B(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(byte), (bytes) => bytes[0]);
        public byte B(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(byte), (bytes) => bytes[0]);

        public sbyte SB(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public sbyte SB(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public unsafe sbyte SB(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(sbyte), (bytes) => (sbyte)bytes[0]);
        public sbyte SB(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(sbyte), (bytes) => (sbyte)bytes[0]);

        public char C(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public char C(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public unsafe char C(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));
        public char C(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(char), (bytes) => BitConverter.ToChar(bytes, 0));

        public short I2(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public short I2(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public unsafe short I2(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));
        public short I2(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(short), (bytes) => BitConverter.ToInt16(bytes, 0));

        public uint U2(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public uint U2(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public unsafe uint U2(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));
        public uint U2(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(ushort), (bytes) => BitConverter.ToUInt16(bytes, 0));

        public int I4(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public int I4(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public unsafe int I4(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));
        public int I4(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(int), (bytes) => BitConverter.ToInt32(bytes, 0));

        public uint U4(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public uint U4(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public unsafe uint U4(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));
        public uint U4(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(uint), (bytes) => BitConverter.ToUInt32(bytes, 0));

        public long I8(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public long I8(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public unsafe long I8(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));
        public long I8(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(long), (bytes) => BitConverter.ToInt64(bytes, 0));

        public ulong U8(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public ulong U8(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public unsafe ulong U8(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));
        public ulong U8(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(ulong), (bytes) => BitConverter.ToUInt64(bytes, 0));

        public float F(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public float F(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public unsafe float F(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));
        public float F(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(float), (bytes) => BitConverter.ToSingle(bytes, 0));

        public double D(int lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public double D(long lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public unsafe double D(void* lpBaseAddress) => Read(new IntPtr(lpBaseAddress), sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));
        public double D(IntPtr lpBaseAddress) => Read(lpBaseAddress, sizeof(double), (bytes) => BitConverter.ToDouble(bytes, 0));

        private byte[] BufferConvert(byte[] bytes)
        {
            var ret = new byte[bytes.Length];
            Array.Copy(bytes, ret, ret.Length);
            return ret;
        }
        public byte[] Buffer(int lpBaseAddress, int readLength) => Read(new IntPtr(lpBaseAddress), readLength, BufferConvert);
        public byte[] Buffer(long lpBaseAddress, int readLength) => Read(new IntPtr(lpBaseAddress), readLength, BufferConvert);
        public unsafe byte[] Buffer(void* lpBaseAddress, int readLength) => Read(new IntPtr(lpBaseAddress), readLength, BufferConvert);
        public byte[] Buffer(IntPtr lpBaseAddress, int readLength) => Read(lpBaseAddress, readLength, BufferConvert);

    }
}
