using System;

namespace NWin32
{
    public partial class NativeMacros
    {
        public static IntPtr MAKELPARAM(int l, int h) => new IntPtr(((h << 16) + l));

    }
}
