using Native;
using NStandard;
using NWin32;
using System;
using System.Threading;
using static NWin32.NativeMethods;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var sweeper = new Sweeper();
            sweeper.Run();
        }
    }
}
