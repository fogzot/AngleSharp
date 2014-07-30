﻿namespace AngleSharp.DOM.Html
{
    /// <summary>
    /// Represents a noframes HTML element.
    /// </summary>
    sealed class HTMLNoFramesElement : HTMLElement
    {
        #region ctor

        internal HTMLNoFramesElement()
            : base(Tags.NoFrames, NodeFlags.Special | NodeFlags.LiteralText)
        { }

        #endregion
    }
}
