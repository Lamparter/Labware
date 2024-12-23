using System;
using System.Runtime.InteropServices;

namespace Labware.PInvoke.User32
{
    public static partial class User32Library
    {
        private const string User32 = "user32.dll";
        [LibraryImport(User32, EntryPoint = "FindWindowExW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);
        [LibraryImport(User32, EntryPoint = "SendMessageW", SetLastError = false)]
        public static partial IntPtr SendMessage(IntPtr hWnd, WindowMessage wMsg, int wParam, IntPtr lParam);
    }
}
