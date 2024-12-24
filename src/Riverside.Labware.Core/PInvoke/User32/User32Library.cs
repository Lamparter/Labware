using System;
using System.Runtime.InteropServices;

namespace Riverside.Labware.Core.PInvoke.User32
{
    public static partial class User32Library
    {
        private const string User32 = "user32.dll";
        [LibraryImport(User32, EntryPoint = "FindWindowExW", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
        public static partial nint FindWindowEx(nint hWndParent, nint hWndChildAfter, string lpszClass, string lpszWindow);
        [LibraryImport(User32, EntryPoint = "SendMessageW", SetLastError = false)]
        public static partial nint SendMessage(nint hWnd, WindowMessage wMsg, int wParam, nint lParam);
    }
}
