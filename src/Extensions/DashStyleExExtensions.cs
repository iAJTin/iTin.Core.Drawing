
using System.Drawing.Drawing2D;

using iTin.Core.Drawing.ComponentModel;

namespace iTin.Core.Drawing;

/// <summary>
/// Static class than contains extension methods for type <see cref="DashStyleEx"/>.
/// </summary> 
public static class DashStyleExExtensions
{
    /// <summary>
    /// Equivalence between the types <see cref="DashStyleEx"/> and <see cref="DashStyle"/>.
    /// </summary>
    /// <param name="style">One of the values in the enumeration <see cref="DashStyleEx"/> that represents style of dashed lines.</param>
    /// <returns>
    /// Equivalent value.
    /// </returns>
    public static DashStyle ToDashStyle(this DashStyleEx style) =>
        style switch
        {
            DashStyleEx.Dash => DashStyle.Dash,
            DashStyleEx.DashDot => DashStyle.DashDot,
            DashStyleEx.DashDotDot => DashStyle.DashDotDot,
            DashStyleEx.Dot => DashStyle.Dot,
            _ => DashStyle.Solid
        };
}
