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
            AddBracketFunction(key, value => Memory.Ptr(new IntPtr((long)value)).ToInt64());
            Initialize();
        }

    }
}
