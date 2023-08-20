
using System.Drawing;

using iTin.Core.Drawing.ComponentModel;

namespace iTin.Core.Drawing;

/// <summary>
/// Static class than contains extension methods for structures of type <see cref="ContentAlignment"/>.
/// </summary> 
public static class ContentAlignmentExtensions
{
    /// <summary>
    /// Equivalence between the types <see cref="ContentAlignment" /> and <see cref="ImageStyle"/>.
    /// </summary>
    /// <param name="alignment">One of the values in the enumeration <see cref="ContentAlignment"/> that represents the type of alignment.</param>
    /// <returns>
    /// Equivalent style.
    /// </returns>
    public static ImageStyle ToImageStyle(this ContentAlignment alignment) =>
        alignment switch
        {
            ContentAlignment.TopLeft => ImageStyle.TopLeft,
            ContentAlignment.TopCenter => ImageStyle.TopMiddle,
            ContentAlignment.TopRight => ImageStyle.TopRight,
            ContentAlignment.MiddleLeft => ImageStyle.CenterLeft,
            ContentAlignment.MiddleCenter => ImageStyle.CenterMiddle,
            ContentAlignment.MiddleRight => ImageStyle.CenterRight,
            ContentAlignment.BottomLeft => ImageStyle.BottomLeft,
            ContentAlignment.BottomCenter => ImageStyle.BottomMiddle,
            ContentAlignment.BottomRight => ImageStyle.BottomRight,
            _ => ImageStyle.CenterMiddle
        };

    /// <summary>
    /// Equivalence of the horizontal component of the type <see cref="ContentAlignment"/> and <see cref="StringAlignment"/>.
    /// </summary>
    /// <param name="alignment">One of the values in the enumeration <see cref="ContentAlignment"/> that represents the type of alignment.</param>
    /// <returns>
    /// Equivalent style of the horizontal component.
    /// </returns>
    public static StringAlignment ToHorizontalAlignment(this ContentAlignment alignment) =>
        alignment switch
        {
            ContentAlignment.TopCenter => StringAlignment.Center,
            ContentAlignment.MiddleCenter => StringAlignment.Center,
            ContentAlignment.BottomCenter => StringAlignment.Center,
            ContentAlignment.TopRight => StringAlignment.Far,
            ContentAlignment.MiddleRight => StringAlignment.Far,
            ContentAlignment.BottomRight => StringAlignment.Far,
            _ => StringAlignment.Near
        };

    /// <summary>
    /// Equivalence of the vertical component of the type <see cref="ContentAlignment"/> and <see cref="StringAlignment"/>.
    /// </summary>
    /// <param name="alignment">One of the values in the enumeration <see cref="ContentAlignment"/> that represents the type of alignment.</param>
    /// <returns>
    /// Equivalent style of the vertical component.
    /// </returns>
    public static StringAlignment ToStringVerticalAlignment(this ContentAlignment alignment) =>
        alignment switch
        {
            ContentAlignment.MiddleLeft => StringAlignment.Center,
            ContentAlignment.MiddleCenter => StringAlignment.Center,
            ContentAlignment.MiddleRight => StringAlignment.Center,
            ContentAlignment.BottomLeft => StringAlignment.Far,
            ContentAlignment.BottomCenter => StringAlignment.Far,
            ContentAlignment.BottomRight => StringAlignment.Far,
            _ => StringAlignment.Near
        };
}
