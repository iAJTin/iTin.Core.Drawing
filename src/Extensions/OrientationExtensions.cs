
using iTin.Core.Drawing.ComponentModel;

namespace iTin.Core.Drawing;

/// <summary>
/// Static class than contains extension methods for type <see cref="Orientation"/>.
/// </summary> 
public static class OrientationExtensions
{
    /// <summary>
    /// Returns a value that indicates whether the orientation is vertical.
    /// </summary>
    /// <param name="orientation">Orientation to check</param>
    /// <returns>
    /// <b>true</b> if orientation is vertical; otherwise, <b>false</b>.
    /// </returns>
    public static bool IsVerticalOrientation(this Orientation orientation) => orientation is Orientation.Top or Orientation.Bottom;

    /// <summary>
    /// Gets the angle of rotation in degrees for the specified orientation.
    /// </summary>
    /// <param name="orientation">One of the values in the enumeration <see cref="Orientation"/> that represents the orientation of the brush.</param>
    /// <returns>
    /// Angle of rotation in degrees for the specified orientation.
    /// </returns>
    public static float ToAngle(this Orientation orientation) =>
        orientation switch
        {
            Orientation.Left => 0.0f,
            Orientation.Bottom => 270.0f,
            Orientation.Right => 180.0f,
            _ => 90.0f
        };
}
