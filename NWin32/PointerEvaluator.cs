using NStandard;
using NStandard.Evaluators;
using System;
using System.Linq.Expressions;
using System.Reflection;

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
            AddBracketFunction(key, value => ResolvePointer(value));
            Initialize();
        }

        private double ResolvePointer(double ptr)
        {
            var value = Memory.TargetPointerLength == 8 ? Memory.I8(new IntPtr((long)ptr))
                      : Memory.TargetPointerLength == 4 ? Memory.I4(new IntPtr((int)ptr))
                      : 0d;
            return value;
        }

    }
}
