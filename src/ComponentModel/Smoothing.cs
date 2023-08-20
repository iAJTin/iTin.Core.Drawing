
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

using iTin.Core.Helpers;

namespace iTin.Core.Drawing.ComponentModel;

/// <summary>
/// Sets the smoothing quality of lines and curves for the graphic context specified in one of the values in the enumeration <see cref="SmoothingModeEx"/>.
/// </summary>
public class Smoothing : IDisposable
{
    #region private readonly members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Graphics _graphics;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly SmoothingMode _smoothingModePrev;
    #endregion

    #region private members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool _isDisposed;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="Smoothing"/> by setting the smoothing quality of the lines.
    /// </summary>
    /// <param name="canvas">Surface <see cref="Graphics"/> oriented on which to draw.</param>
    /// <param name="quality">One of the values in the enumeration <see cref="SmoothingModeEx"/> that represents the smoothing quality of the lines.</param>
    public Smoothing(Canvas canvas, SmoothingModeEx quality) : this(SentinelHelper.PassThroughNonNull(canvas).Graphics, quality)
    {
    }

    /// <summary>
    /// Initialize a new instance of the class <see cref="Smoothing"/> by setting the smoothing quality of the lines.
    /// </summary>
    /// <param name="graphics">Surface <see cref="Graphics"/> oriented on which to draw</param>
    /// <param name="quality">One of the values in the enumeration <see cref="SmoothingModeEx"/> that represents the smoothing quality of the lines.</param>
    public Smoothing(Graphics graphics, SmoothingModeEx quality)
    {
        Graphics safeGraphics = SentinelHelper.PassThroughNonNull(graphics);

        _graphics = safeGraphics;
        _smoothingModePrev = _graphics.SmoothingMode;
        _graphics.SmoothingMode = quality.ToSmoothingMode();
    }

    #endregion

    #region finalizer

    /// <summary>
    /// Finalizes an instance of the <see cref="Smoothing"/> class. Clean only unmanaged resources.
    /// </summary>
    ~Smoothing()
    {
        Dispose(false);
    }

    #endregion

    #region interfaces

    #region IDisposable

    #region public methods

    /// <summary>
    /// Free managed resources.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    #endregion

    #endregion

    #endregion

    #region protected virtual methods

    /// <summary>
    /// Cleans managed and unmanaged resources.
    /// </summary>
    /// <param name="disposing">
    /// If it is <b>true</b>, the method is invoked directly or indirectly from the user code.
    /// If it is <b>false</b>, the method is called the finalizer and only unmanaged resources are finalized.
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
        {
            return;
        }

        // free managed resources
        if (disposing)
        {
            // Restaurar la calidad original de alisado.
            _graphics.SmoothingMode = _smoothingModePrev;
        }

        // free native resources.
        // Nothing to do

        _isDisposed = true;
    }

    #endregion
}
