using System;

namespace WinMineSweeper
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
