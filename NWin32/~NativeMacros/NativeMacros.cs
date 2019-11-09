using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWin32
{
    public partial class NativeMacros
    {
        public static IntPtr MAKELPARAM(int l, int h) => new IntPtr(((h << 16) + l));

    }
}
