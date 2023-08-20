
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

using iTin.Core.Helpers;

namespace iTin.Core.Drawing.ComponentModel;

/// <summary>
/// Set the smoothing quality of lines and curves for the graphic context in <see cref="AntiAlias"/> and the interpolation mode in <see cref="HighQualityBicubicInterpolation"/>.
/// </summary>
public class HighQualityGraphics : AntiAlias
{
    #region private readonly members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Graphics _graphics;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly InterpolationMode _interpolationModePrev;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="HighQualityGraphics"/> class by setting the smoothing quality to <see cref="SmoothingModeEx.HighQuality"/>.
    /// </summary>
    /// <param name="graphics">A <see cref="Graphics"/> reference used to draw.</param>
    public HighQualityGraphics(Graphics graphics) : base(graphics)
    {
        SentinelHelper.ArgumentNull(graphics, nameof(graphics));

        _graphics = graphics;
        _interpolationModePrev = _graphics.InterpolationMode;
        _graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
    }

    #endregion

    #region finalizer

    /// <summary>
    /// Finalizes an instance of the <see cref="HighQualityGraphics"/> class. Clean only unmanaged resources.
    /// </summary>
    ~HighQualityGraphics()
    {
        Dispose(false);
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Cleans managed and unmanaged resources.
    /// </summary>
    /// <param name="disposing">
    /// If it is <b>true</b>, the method is invoked directly or indirectly from the user code.
    /// If it is <b>false</b>, the method is called the finalizer and only unmanaged resources are finalized.
    /// </param>
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        // free managed resources
        if (disposing)
        {
            // Restaurar la calidad original de alisado.
            _graphics.InterpolationMode = _interpolationModePrev;
        }

        // free native resources.
        // Nothing to do
    }

    #endregion
}
