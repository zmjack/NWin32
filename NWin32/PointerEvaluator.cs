using NStandard;
using NWin32.NativeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace NWin32
{
    public class PointerEvaluator : NumericalEvaluator
    {
        protected MemoryAccessor Memory;

        public PointerEvaluator(MemoryAccessor memoryAccessor)
        {
            Memory = memoryAccessor;
#if NET35 || NET40 || NET45 || NET451 || NET46
            var key = Tuple.Create("[", "]");
#else
            var key = ("[", "]");
#endif
            BracketFunctions.Add(key, inExp => Expression.Call(Expression.Constant(this), ResolvePointerMethod, inExp));
        }

        private readonly MethodInfo ResolvePointerMethod = typeof(PointerEvaluator).GetDeclaredMethod(nameof(ResolvePointer));
        private double ResolvePointer(double ptr)
        {
            var value = Memory.TargetPointerLength == 8 ? Memory.I8(new IntPtr((long)ptr))
                      : Memory.TargetPointerLength == 4 ? Memory.I4(new IntPtr((int)ptr))
                      : 0d;
            return value;
        }

    }
}
