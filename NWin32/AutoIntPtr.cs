using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace NWin32
{
    public sealed class AutoIntPtr<T> : IDisposable
    {
        public IntPtr Ptr { get; private set; }
        public int Length { get; private set; }

        private string[] SupportedTypes = new[]
        {
            "System.Boolean",
            "System.Byte",
            "System.SByte",
            "System.Char",
            "System.Int16",
            "System.UInt16",
            "System.Int32",
            "System.UInt32",
            "System.Int64",
            "System.UInt64",
            "System.Single",
            "System.Double",
            "System.Byte[]",
        };
        public bool IsSupportedType => SupportedTypes.Contains(TypeFullName);
        public string TypeFullName => typeof(T).FullName;

        public AutoIntPtr() : this(0) { }
        public AutoIntPtr(int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException($"The argument(`length`) must be greater than 0.");
            if (!IsSupportedType) throw new TypeLoadException($"The type {TypeFullName} is not supported.");

            if (TypeFullName == "System.Byte[]") Length = length;
            else Length = Marshal.SizeOf(typeof(T));

            Ptr = Marshal.AllocHGlobal(Length);
        }

        public void Dispose() => Marshal.FreeHGlobal(Ptr);

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static implicit operator IntPtr(AutoIntPtr<T> @this) => @this.Ptr;

        public T Value
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                var buffer = new byte[Length];
                Marshal.Copy(Ptr, buffer, 0, buffer.Length);

                switch (TypeFullName)
                {
                    case "System.Boolean": return (T)(object)BitConverter.ToBoolean(buffer, 0);
                    case "System.Byte": return (T)(object)buffer[0];
                    case "System.SByte": return (T)(object)(sbyte)buffer[0];
                    case "System.Char": return (T)(object)BitConverter.ToChar(buffer, 0);
                    case "System.Int16": return (T)(object)BitConverter.ToInt16(buffer, 0);
                    case "System.UInt16": return (T)(object)BitConverter.ToUInt16(buffer, 0);
                    case "System.Int32": return (T)(object)BitConverter.ToInt32(buffer, 0);
                    case "System.UInt32": return (T)(object)BitConverter.ToUInt32(buffer, 0);
                    case "System.Int64": return (T)(object)BitConverter.ToInt64(buffer, 0);
                    case "System.UInt64": return (T)(object)BitConverter.ToUInt64(buffer, 0);
                    case "System.Single": return (T)(object)BitConverter.ToSingle(buffer, 0);
                    case "System.Double": return (T)(object)BitConverter.ToDouble(buffer, 0);
                    case "System.Byte[]": return (T)(object)buffer;
                    default: throw new TypeLoadException($"The generic type {TypeFullName} is not supported.");
                }
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                byte[] buffer;

                switch (TypeFullName)
                {
                    case "System.Boolean": buffer = BitConverter.GetBytes((bool)(object)value); break;
                    case "System.Byte": buffer = BitConverter.GetBytes((byte)(object)value); break;
                    case "System.SByte": buffer = BitConverter.GetBytes((sbyte)(object)value); break;
                    case "System.Char": buffer = BitConverter.GetBytes((char)(object)value); break;
                    case "System.Int16": buffer = BitConverter.GetBytes((short)(object)value); break;
                    case "System.UInt16": buffer = BitConverter.GetBytes((ushort)(object)value); break;
                    case "System.Int32": buffer = BitConverter.GetBytes((int)(object)value); break;
                    case "System.UInt32": buffer = BitConverter.GetBytes((uint)(object)value); break;
                    case "System.Int64": buffer = BitConverter.GetBytes((long)(object)value); break;
                    case "System.UInt64": buffer = BitConverter.GetBytes((ulong)(object)value); break;
                    case "System.Single": buffer = BitConverter.GetBytes((float)(object)value); break;
                    case "System.Double": buffer = BitConverter.GetBytes((double)(object)value); break;
                    case "System.Byte[]": buffer = (byte[])(object)value; break;
                    default: throw new TypeLoadException($"The generic type {TypeFullName} is not supported.");
                }
                Marshal.Copy(buffer, 0, Ptr, Length);
            }
        }

    }
}
