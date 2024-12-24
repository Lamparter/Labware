using Riverside.Labware.Core.PInvoke.User32;
using System;

namespace Riverside.Labware.Core.PInvoke.Comctl32
{
    public delegate nint SUBCLASSPROC(nint hWnd, WindowMessage uMsg, UIntPtr wParam, nint lParam, uint uIdSubclass, nint dwRefData);
}
