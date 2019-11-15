using System;

namespace WinMineSweeper
{
    class Program
    {
        public static IntPtr HWnd;
        public static uint ProcessId;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var sweeper = new Sweeper();
            sweeper.Run();
        }

    }
}
