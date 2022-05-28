using Native;
using NStandard;
using NWin32;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using static NWin32.NativeConstants;
using static NWin32.NativeMacros;
using static NWin32.NativeMethods;

namespace MineSweeper
{
    public class Sweeper
    {
        private readonly AutoIntPtr<uint> Pid = new AutoIntPtr<uint>();
        private readonly IntPtr HWnd;

        private const int WBASE = 0x01000000;
        private readonly int AddrRemaining = WBASE + 0x5194;
        private readonly int AddrWidth = WBASE + 0x5334;
        private readonly int AddrHeight = WBASE + 0x5338;
        private readonly int AddrTime = WBASE + 0x579C;
        private readonly int AddrMine = WBASE + 0x5340;
        private int Remaining, Width, Height, Time;
        private byte[] Mines = new byte[832];
        private bool Valid;

        public Sweeper()
        {
            while ((HWnd = FindWindowW("Minesweeper", "Minesweeper")) == IntPtr.Zero)
            {
                Process.Start("winmine.exe");
                Thread.Sleep(1000);
            }
            GetWindowThreadProcessId(HWnd, Pid);
        }

        public void ReadMemory()
        {
            using var memory = new MemoryAccessor(Pid.Value);

            Remaining = memory.I4(AddrRemaining);
            Width = memory.I4(AddrWidth);
            Height = memory.I4(AddrHeight);
            Time = memory.I4(AddrTime);

            if ((Width * Height).For(n => 0 < n && n <= Mines.Length))
            {
                Mines = memory.Buffer(AddrMine, Mines.Length);
                Valid = true;
            }
            else Valid = false;
        }

        public void Print()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Remaining: {Remaining:000}\tPassed time: {Time:000}");
            for (int i = 0; i <= Height + 1; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j <= Width + 1; j++) sb.Append($"{CellFormat(Mines[i * 0x20 + j])} ");
                for (int j = Width + 2; j <= 30 + 1; j++) sb.Append($"  ");
                Console.WriteLine(sb);
            }

            for (int i = Height + 2; i <= 16 + 1; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j <= 30 + 1; j++) sb.Append($"  ");
                Console.WriteLine(sb);
            }

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to sweep...");
        }

        public char CellFormat(byte n)
        {
            switch (n)
            {
                case 13: return '?';        // ? empty
                case 14: return 'e';        // Flag empty
                case 15: return '_';        // Cell
                case 16: return (char)n;    // Wall
                case 64: return ' ';
                case 65: return '1';
                case 66: return '2';
                case 67: return '3';
                case 68: return '4';
                case 69: return '5';
                case 70: return '6';
                case 71: return '7';
                case 72: return '8';
                case 204: return 'B';       // Boom
                case 143: return '*';       // Mine(Invisible)
                case 142: return '.';       // Flag mine
                case 141: return '+';       // ? mine
                case 138: return '@';       // Mine(Visible)
                default: return '#';
            }
        }

        public void Sweep()
        {
            int i, j;
            for (i = 1; i <= Height; i++)
            {
                for (j = 1; j <= Width; j++)
                {
                    if (Mines[i * 0x20 + j] == 15)
                    {
                        int posX, posY;
                        posX = 20 + 16 * (j - 1);
                        posY = 60 + 16 * (i - 1);
                        PostMessageW(HWnd, WM_LBUTTONDOWN, new UIntPtr(1), MAKELPARAM(posX, posY));
                        PostMessageW(HWnd, WM_LBUTTONUP, new UIntPtr(0), MAKELPARAM(posX, posY));
                    }
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                ReadMemory();
                if (Valid)
                {
                    Print();
                    Sleep(50);
                }
            }
        }

    }
}
