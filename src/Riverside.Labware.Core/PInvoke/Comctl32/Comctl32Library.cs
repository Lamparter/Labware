using Riverside.Labware.Core.PInvoke.User32;
using System;
using System.Runtime.InteropServices;

namespace Riverside.Labware.Core.PInvoke.Comctl32
{
    public static partial class Comctl32Library
    {
        private const string Comctl32 = "comctl32.dll";
        [LibraryImport(Comctl32, EntryPoint = "SetWindowSubclass", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool SetWindowSubclass(nint hWnd, nint pfnSubclass, uint uIdSubclass, nint dwRefData);
        [LibraryImport(Comctl32, EntryPoint = "DefSubclassProc", SetLastError = false)]
        public static partial nint DefSubclassProc(nint hWnd, WindowMessage uMsg, UIntPtr wParam, nint lParam);
    }
}