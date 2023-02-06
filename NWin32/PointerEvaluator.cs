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
            AddBracketFunction(new("[", "]"), value => Memory.Ptr(new IntPtr((long)value)).ToInt64());
            Initialize();
        }

    }
}
