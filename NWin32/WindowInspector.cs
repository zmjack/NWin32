using NMarshal;
using NStandard;
using NWin32.NativeTypes;
using System;

namespace NWin32
{
    public class WindowInspector
    {
        public IntPtr Handle { get; protected set; }
        public string Caption => Handle == IntPtr.Zero ? default : GetCaption();
        public string ClassName => Handle == IntPtr.Zero ? default : GetClassName();
        public tagRECT Rectangle => Handle == IntPtr.Zero ? default : GetRectangle();
        public uint ProcessId => Handle == IntPtr.Zero ? default : GetProcessId();
        public WindowInspector FirstWindow => NativeMethods.GetWindow(Handle, 0).For(WrapWindowInspector);
        public WindowInspector LastWindow => NativeMethods.GetWindow(Handle, 1).For(WrapWindowInspector);
        public WindowInspector NextWindow => NativeMethods.GetWindow(Handle, 2).For(WrapWindowInspector);
        public WindowInspector PreviousWindow => NativeMethods.GetWindow(Handle, 3).For(WrapWindowInspector);
        public WindowInspector OwnerWindow => NativeMethods.GetWindow(Handle, 4).For(WrapWindowInspector);
        public WindowInspector FirstChildWindow => NativeMethods.GetWindow(Handle, 5).For(WrapWindowInspector);

        private WindowInspector WrapWindowInspector(IntPtr hWnd) => hWnd == IntPtr.Zero ? null : new WindowInspector(hWnd);

        public WindowInspector(IntPtr windowHandle)
        {
            if (windowHandle == IntPtr.Zero) throw new ArgumentException("The window handle can not be zero.");

            Handle = windowHandle;
        }

        public string GetCaption()
        {
            var autoWindowText = new AutoCharPtr(255);
            NativeMethods.GetWindowTextW(Handle, autoWindowText, autoWindowText.Length);
            return autoWindowText.Value;
        }
        public string GetClassName()
        {
            var autoWindowText = new AutoCharPtr(255);
            NativeMethods.GetClassNameW(Handle, autoWindowText, autoWindowText.Length);
            return autoWindowText.Value;
        }
        public tagRECT GetRectangle()
        {
            NativeMethods.GetWindowRect(Handle, out var rectangle);
            return rectangle;
        }
        public uint GetProcessId()
        {
            var autoPid = new AutoIntPtr<uint>();
            NativeMethods.GetWindowThreadProcessId(Handle, autoPid);
            return autoPid.Value;
        }

    }
}
