using Riverside.Labware.Core.PInvoke.User32;
using System;

namespace Riverside.Labware.Core.PInvoke.Comctl32
{
    public delegate IntPtr SUBCLASSPROC(IntPtr hWnd, WindowMessage uMsg, UIntPtr wParam, IntPtr lParam, uint uIdSubclass, IntPtr dwRefData);
}
