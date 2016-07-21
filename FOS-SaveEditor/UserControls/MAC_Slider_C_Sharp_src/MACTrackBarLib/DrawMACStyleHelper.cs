#region Copyright (c) 2002-2006 X-Component, All Rights Reserved
/* ---------------------------------------------------------------------*
*                           X-Component,                              *
*              Copyright (c) 2002-2006 All Rights reserved              *
*                                                                       *
*                                                                       *
* This file and its contents are protected by Vietnam and               *
* International copyright laws.  Unauthorized reproduction and/or       *
* distribution of all or any portion of the code contained herein       *
* is strictly prohibited and will result in severe civil and criminal   *
* penalties.  Any violations of this copyright will be prosecuted       *
* to the fullest extent possible under law.                             *
*                                                                       *
* THE SOURCE CODE CONTAINED HEREIN AND IN RELATED FILES IS PROVIDED     *
* TO THE REGISTERED DEVELOPER FOR THE PURPOSES OF EDUCATION AND         *
* TROUBLESHOOTING. UNDER NO CIRCUMSTANCES MAY ANY PORTION OF THE SOURCE *
* CODE BE DISTRIBUTED, DISCLOSED OR OTHERWISE MADE AVAILABLE TO ANY     *
* THIRD PARTY WITHOUT THE EXPRESS WRITTEN CONSENT OF ECONTECH JSC.,     *
*                                                                       *
* UNDER NO CIRCUMSTANCES MAY THE SOURCE CODE BE USED IN WHOLE OR IN     *
* PART, AS THE BASIS FOR CREATING A PRODUCT THAT PROVIDES THE SAME, OR  *
* SUBSTANTIALLY THE SAME, FUNCTIONALITY AS ANY ECONTECH JSC. PRODUCT.   *
*                                                                       *
* THE REGISTERED DEVELOPER ACKNOWLEDGES THAT THIS SOURCE CODE           *
* CONTAINS VALUABLE AND PROPRIETARY TRADE SECRETS OF ECONTECH JSC.,     *
* THE REGISTERED DEVELOPER AGREES TO EXPEND EVERY EFFORT TO             *
* INSURE ITS CONFIDENTIALITY.                                           *
*                                                                       *
* THE END USER LICENSE AGREEMENT (EULA) ACCOMPANYING THE PRODUCT        *
* PERMITS THE REGISTERED DEVELOPER TO REDISTRIBUTE THE PRODUCT IN       *
* EXECUTABLE FORM ONLY IN SUPPORT OF APPLICATIONS WRITTEN USING         *
* THE PRODUCT.  IT DOES NOT PROVIDE ANY RIGHTS REGARDING THE            *
* SOURCE CODE CONTAINED HEREIN.                                         *
*                                                                       *
* THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.              *
* --------------------------------------------------------------------- *
*/
#endregion Copyright (c) 2002-2006 X-Component, All Rights Reserved

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace XComponent.SliderBar
{
    /// <summary>
    /// Summary description for DrawMACStyleHelper.
    /// </summary>
    public sealed class DrawMACStyleHelper
    {
        /// <summary>
        /// The contructor 
        /// </summary>
        private DrawMACStyleHelper()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="drawRectF"></param>
        /// <param name="drawColor"></param>
        /// <param name="orientation"></param>
        public static void DrawAquaPill(Graphics g, RectangleF drawRectF, Color drawColor, Orientation orientation)

        {
            Color color1;
            Color color2;
            Color color3;
            Color color4;
            Color color5;
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush;
            System.Drawing.Drawing2D.ColorBlend colorBlend = new System.Drawing.Drawing2D.ColorBlend();

            color1 = ColorHelper.OpacityMix(Color.White, ColorHelper.SoftLightMix(drawColor, Color.Black, 100), 40);
            color2 = ColorHelper.OpacityMix(Color.White, ColorHelper.SoftLightMix(drawColor, ColorHelper.CreateColorFromRGB(64, 64, 64), 100), 20);
            color3 = ColorHelper.SoftLightMix(drawColor, ColorHelper.CreateColorFromRGB(128, 128, 128), 100);
            color4 = ColorHelper.SoftLightMix(drawColor, ColorHelper.CreateColorFromRGB(192, 192, 192), 100);
            color5 = ColorHelper.OverlayMix(ColorHelper.SoftLightMix(drawColor, Color.White, 100), Color.White, 75);

            //			
            colorBlend.Colors = new Color[] { color1, color2, color3, color4, color5 };
            colorBlend.Positions = new float[] { 0, 0.25f, 0.5f, 0.75f, 1 };
            if (orientation == Orientation.Horizontal)
                gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top - 1), new Point((int)drawRectF.Left, (int)drawRectF.Top + (int)drawRectF.Height + 1), color1, color5);
            else
                gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point((int)drawRectF.Left - 1, (int)drawRectF.Top), new Point((int)drawRectF.Left + (int)drawRectF.Width + 1, (int)drawRectF.Top), color1, color5);
            gradientBrush.InterpolationColors = colorBlend;
            FillPill(gradientBrush, drawRectF, g);

            //
            color2 = Color.White;
            colorBlend.Colors = new Color[] { color2, color3, color4, color5 };
            colorBlend.Positions = new float[] { 0, 0.5f, 0.75f, 1 };
            if (orientation == Orientation.Horizontal)
                gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point((int)drawRectF.Left + 1, (int)drawRectF.Top), new Point((int)drawRectF.Left + 1, (int)drawRectF.Top + (int)drawRectF.Height - 1), color2, color5);
            else
                gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point((int)drawRectF.Left, (int)drawRectF.Top + 1), new Point((int)drawRectF.Left + (int)drawRectF.Width - 1, (int)drawRectF.Top + 1), color2, color5);
            gradientBrush.InterpolationColors = colorBlend;
            FillPill(gradientBrush, RectangleF.Inflate(drawRectF, -3, -3), g);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="drawRectF"></param>
        /// <param name="trackerRectF"></param>
        /// <param name="drawColorMin"></param>
        /// <param name="drawColorMax"></param>
        /// <param name="orientation"></param>
        public static void DrawAquaPillSingleLayer(
            Graphics g, 
            RectangleF drawRectF,
            RectangleF trackerRectF,
            Color drawColorMin, 
            Color drawColorMax, 
            Orientation orientation)
        {
            RectangleF drawRectMinF;

            LinearGradientBrush gradientBrushMin;
            var colorBlendMin = new ColorBlend();

            LinearGradientBrush gradientBrushMax;
            var colorBlendMax = new ColorBlend();

            var color1Min = drawColorMin;
            var color2Min = ControlPaint.Light(color1Min);
            var color3Min = ControlPaint.Light(color2Min);
            var color4Min = ControlPaint.Light(color3Min);

            var color1Max = drawColorMax;
            var color2Max = ControlPaint.Light(color1Max);
            var color3Max = ControlPaint.Light(color2Max);
            var color4Max = ControlPaint.Light(color3Max);

            colorBlendMin.Colors = new[] { color1Min, color2Min, color3Min, color4Min };
            colorBlendMin.Positions = new[] { 0, 0.25f, 0.65f, 1 };

            colorBlendMax.Colors = new[] { color1Max, color2Max, color3Max, color4Max };
            colorBlendMax.Positions = new[] { 0, 0.25f, 0.65f, 1 };

            if (orientation == Orientation.Horizontal)
            {
                // Calculate the size of the rect for the area behind the tracker
                drawRectMinF = new RectangleF(
                    drawRectF.Left,
                    drawRectF.Top,
                    trackerRectF.Right - trackerRectF.Width / 2,
                    drawRectF.Height);

                gradientBrushMin =
                    new LinearGradientBrush(
                        new Point((int)drawRectF.Left, (int)trackerRectF.Top),
                        new Point((int)drawRectF.Left, (int)drawRectF.Top + (int)drawRectF.Height),
                        color1Min,
                        color4Min);

                gradientBrushMax =
                    new LinearGradientBrush(
                        new Point((int)drawRectF.Left, (int)drawRectF.Top),
                        new Point((int)drawRectF.Left, (int)drawRectF.Top + (int)drawRectF.Height),
                        color1Max,
                        color4Max);
            }
            else // Vertical
            {
                drawRectMinF = new RectangleF(
                    drawRectF.Left,
                    trackerRectF.Top,
                    drawRectF.Width,
                    drawRectF.Bottom - (trackerRectF.Top/* + (trackerRectF.Height / 2)*/));  // height of the rectangle

                // Min Color
                gradientBrushMin =
                    new LinearGradientBrush(
                        new Point((int)drawRectF.Left, (int)drawRectF.Top),
                        new Point((int)drawRectF.Left + (int)drawRectF.Width, (int)drawRectF.Top),
                        color1Min,
                        color4Min);

                // Max Color
                gradientBrushMax =
                    new LinearGradientBrush(
                        new Point((int)drawRectF.Left, (int)drawRectF.Top),
                        new Point((int)drawRectF.Left + (int)drawRectF.Width, (int)drawRectF.Top),
                        color1Max,
                        color4Max);
            }
            gradientBrushMin.InterpolationColors = colorBlendMin;
            gradientBrushMax.InterpolationColors = colorBlendMax;

            FillPill(gradientBrushMax, drawRectF, g);
            // Do this second so that we overlay it
            FillPill(gradientBrushMin, drawRectMinF, g);

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="rect"></param>
        /// <param name="g"></param>
        public static void FillPill(Brush b, RectangleF rect, Graphics g)
        {
            if (rect.Width > rect.Height)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillEllipse(b, new RectangleF(rect.Left, rect.Top, rect.Height, rect.Height));
                g.FillEllipse(b, new RectangleF(rect.Left + rect.Width - rect.Height, rect.Top, rect.Height, rect.Height));

                float w = rect.Width - rect.Height;
                float l = rect.Left + ((rect.Height) / 2);
                g.FillRectangle(b, new RectangleF(l, rect.Top, w, rect.Height));
                g.SmoothingMode = SmoothingMode.Default;
            }
            else if (rect.Width < rect.Height)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillEllipse(b, new RectangleF(rect.Left, rect.Top, rect.Width, rect.Width));
                g.FillEllipse(b, new RectangleF(rect.Left, rect.Top + rect.Height - rect.Width, rect.Width, rect.Width));

                float t = rect.Top + (rect.Width / 2);
                float h = rect.Height - rect.Width;
                g.FillRectangle(b, new RectangleF(rect.Left, t, rect.Width, h));
                g.SmoothingMode = SmoothingMode.Default;
            }
            else if (rect.Width == rect.Height)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillEllipse(b, rect);
                g.SmoothingMode = SmoothingMode.Default;
            }
        }

    }
}
