
using System.Drawing.Drawing2D;

using iTin.Core.Drawing.ComponentModel;

namespace iTin.Core.Drawing;

/// <summary>
/// Static class than contains extension methods for structures of type <see cref="ImageStyle"/>.
/// </summary> 
public static class ImageStyleExtensions
{
    /// <summary>
    /// Equivalence between the types <see cref="ImageStyle"/> and <see cref="WrapMode"/>.
    /// </summary>
    /// <param name="style">One of the values of the enumeration <see cref="ImageStyle"/> that represents the alignment of the images on the surface of the control.</param>
    /// <returns>
    /// Equivalent style
    /// </returns>
    public static WrapMode ToWrapMode(this ImageStyle style) =>
        style switch
        {
            ImageStyle.Tile => WrapMode.Tile,
            ImageStyle.TileFlipX => WrapMode.TileFlipX,
            ImageStyle.TileFlipY => WrapMode.TileFlipY,
            ImageStyle.TileFlipXY => WrapMode.TileFlipXY,
            _ => WrapMode.Clamp
        };
}
