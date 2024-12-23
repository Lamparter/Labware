using System;
using Riverside.Labware.PInvoke.User32;

namespace Riverside.Labware.PInvoke.Comctl32
{
    public delegate IntPtr SUBCLASSPROC(IntPtr hWnd, WindowMessage uMsg, UIntPtr wParam, IntPtr lParam, uint uIdSubclass, IntPtr dwRefData);
}
