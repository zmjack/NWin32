using Native;
using NStandard;
using NWin32.NativeTypes;
using System;
using System.Collections.Generic;

namespace NWin32
{
    public class WindowInspector
    {
        private WindowInspector WrapWindowInspector(IntPtr hWnd) => hWnd == IntPtr.Zero ? null : new WindowInspector(hWnd);

        public IntPtr Handle { get; protected set; }

        public string Caption => GetCaption();
        public string ClassName => GetClassName();
        public tagRECT Rectangle => GetRectangle();
        public int Width
        {
            get
            {
                var rect = Rectangle;
                return rect.right - rect.left;
            }
        }
        public int Height
        {
            get
            {
                var rect = Rectangle;
                return rect.bottom - rect.top;
            }
        }
        public uint ProcessId => GetProcessId();
        public WindowInspector FirstWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 0));
        public WindowInspector LastWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 1));
        public WindowInspector NextWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 2));
        public WindowInspector PreviousWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 3));
        public WindowInspector OwnerWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 4));
        public WindowInspector FirstChildWindow => WrapWindowInspector(NativeMethods.GetWindow(Handle, 5));
        public bool IsIconic => NativeMethods.IsIconic(Handle);
        public bool IsForeground => NativeMethods.GetForegroundWindow() == Handle;

        public WindowInspector[] GetChildWindows()
        {
            var list = new List<WindowInspector>();
            for (var window = FirstChildWindow; window != null; window = window.NextWindow)
                list.Add(window);
            return list.ToArray();
        }

        public void Focus() => NativeMethods.SetForegroundWindow(Handle);

        public WindowInspector(IntPtr windowHandle)
        {
            if (windowHandle == IntPtr.Zero) throw new ArgumentException("The window handle can not be zero.");

            Handle = windowHandle;
        }

        protected string GetCaption()
        {
            var autoWindowText = new AutoCharPtr(255);
            NativeMethods.GetWindowTextW(Handle, autoWindowText, autoWindowText.Length);
            return autoWindowText.Value;
        }
        protected string GetClassName()
        {
            var autoWindowText = new AutoCharPtr(255);
            NativeMethods.GetClassNameW(Handle, autoWindowText, autoWindowText.Length);
            return autoWindowText.Value;
        }
        protected tagRECT GetRectangle()
        {
            NativeMethods.GetWindowRect(Handle, out var rectangle);
            return rectangle;
        }
        protected uint GetProcessId()
        {
            var autoPid = new AutoIntPtr<uint>();
            NativeMethods.GetWindowThreadProcessId(Handle, autoPid);
            return autoPid.Value;
        }

    }
}
