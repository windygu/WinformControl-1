using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using CtrlControls.Enum;

namespace CtrlControls.Helper
{
    class DrawHelper
    {
        /// <summary>
        /// 渲染按钮控件的边框和背景图片，使背景图片不失真
        /// </summary>
        /// <param name="descG">要绘制的图像</param>
        /// <param name="descRect">控件的大小</param>
        /// <param name="srcBgImage">把这个图片绘制到g里面</param>
        /// <param name="method">绘制图片的方式：true表示自适应绘制图片内容，false表示等比例绘制图片内容</param>
        public static void RenderButtonBorderBackground(Graphics descG, Rectangle descRect, Image srcBgImage, bool method = false)
        {
            if (method)
            {
                //左上角
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y, 5, 5), 0, 0, 5, 5, GraphicsUnit.Pixel);
                //上边
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y, descRect.Width - 10, 5), 5, 0, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
                //右上角
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y, 5, 5), srcBgImage.Width - 5, 0, 5, 5, GraphicsUnit.Pixel);
                //左边
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + 5, 5, descRect.Height - 10), 0, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
                //左下角
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + descRect.Height - 5, 5, 5), 0, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
                //右边
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + 5, 5, descRect.Height - 10), srcBgImage.Width - 5, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
                //右下角
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + descRect.Height - 5, 5, 5), srcBgImage.Width - 5, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
                //下边
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + descRect.Height - 5, descRect.Width - 10, 5), 5, srcBgImage.Height - 5, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
                //平铺中间块
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + 5, descRect.Width - 10, descRect.Height - 10), 5, 5, srcBgImage.Width - 10, srcBgImage.Height - 10, GraphicsUnit.Pixel);
            }
            else
            {
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + 0, descRect.Y, 5, descRect.Height), 0, 0, 5, srcBgImage.Height, GraphicsUnit.Pixel);
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y, descRect.Width - 10, descRect.Height), 5, 0, srcBgImage.Width - 10, srcBgImage.Height, GraphicsUnit.Pixel);
                descG.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y, 5, descRect.Height), srcBgImage.Width - 5, 0, 5, srcBgImage.Height, GraphicsUnit.Pixel);

            }
        }
        /// <summary>
        /// 渲染窗体控件的边框图片，使背景图片不失真
        /// </summary>
        /// <param name="descG"></param>
        /// <param name="descRect"></param>
        /// <param name="srcBgImage"></param>
        public static void RenderFormBorder(Graphics g, Rectangle descRect, Image srcBgImage)
        {
            //左上角
            g.DrawImage(srcBgImage, new Rectangle(0, 0, 10, 10), 5, 5, 10, 10, GraphicsUnit.Pixel);
            //左边
            g.DrawImage(srcBgImage, new Rectangle(0, 10, 10, descRect.Height - 20), 5, 15, 10, srcBgImage.Height - 30, GraphicsUnit.Pixel);
            //左下角
            g.DrawImage(srcBgImage, new Rectangle(0, descRect.Height - 10, 10, 10), 5, srcBgImage.Height - 15, 10, 10, GraphicsUnit.Pixel);
            //右上角
            g.DrawImage(srcBgImage, new Rectangle(descRect.Width - 10, 0, 10, 10), srcBgImage.Width - 15, 5, 10, 10, GraphicsUnit.Pixel);
            //右边
            g.DrawImage(srcBgImage, new Rectangle(descRect.Width - 10, 10, 10, descRect.Height - 20), srcBgImage.Width - 15, 15, 10, srcBgImage.Height - 30, GraphicsUnit.Pixel);
            //右下角
            g.DrawImage(srcBgImage, new Rectangle(descRect.Width - 10, descRect.Height - 10, 10, 10), srcBgImage.Width - 15, srcBgImage.Height - 15, 10, 10, GraphicsUnit.Pixel);
            //上边
            g.DrawImage(srcBgImage, new Rectangle(10, 0, descRect.Width - 20, 10), srcBgImage.Width - 15, 5, srcBgImage.Width - 30, 10, GraphicsUnit.Pixel);
            //下边
            g.DrawImage(srcBgImage, new Rectangle(10, descRect.Height - 1, descRect.Width - 20, 10), srcBgImage.Width - 15, srcBgImage.Height - 6, srcBgImage.Width - 30, 5, GraphicsUnit.Pixel);
        }
        /// <summary>
        /// 渲染文本框控件的边框和背景图片，使背景图片不失真
        /// </summary>
        /// <param name="g"></param>
        /// <param name="descRect"></param>
        /// <param name="srcBgImage"></param>
        public static void RendererTextBoxBorderBackground(Graphics g, Rectangle descRect, Image srcBgImage)
        {
            //左上角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y, 5, 5), 0, 0, 5, 5, GraphicsUnit.Pixel);
            //上边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y, descRect.Width - 10, 5), 5, 0, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
            //右上角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y, 5, 5), srcBgImage.Width - 5, 0, 5, 5, GraphicsUnit.Pixel);
            //左边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + 5, 5, descRect.Height - 10), 0, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
            //左下角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + descRect.Height - 5, 5, 5), 0, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
            //右边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + 5, 5, descRect.Height - 10), srcBgImage.Width - 5, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
            //右下角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + descRect.Height - 5, 5, 5), srcBgImage.Width - 5, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
            //下边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + descRect.Height - 5, descRect.Width - 10, 5), 5, srcBgImage.Height - 5, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
            //平铺中间块
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + 5, descRect.Width - 10, descRect.Height - 10), 5, 5, srcBgImage.Width - 10, srcBgImage.Height - 10, GraphicsUnit.Pixel);
        }
        /// <summary>
        /// 渲染文本框控件的边框图片，使背景图片不失真
        /// </summary>
        /// <param name="g"></param>
        /// <param name="descRect"></param>
        /// <param name="srcBgImage"></param>
        public static void RendererTextBoxBorder(Graphics g, Rectangle descRect, Image srcBgImage)
        {
            //左上角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y, 5, 5), 0, 0, 5, 5, GraphicsUnit.Pixel);
            //上边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y, descRect.Width - 10, 5), 5, 0, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
            //右上角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y, 5, 5), srcBgImage.Width - 5, 0, 5, 5, GraphicsUnit.Pixel);
            //左边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + 5, 5, descRect.Height - 10), 0, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
            //左下角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X, descRect.Y + descRect.Height - 5, 5, 5), 0, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
            //右边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + 5, 5, descRect.Height - 10), srcBgImage.Width - 5, 5, 5, srcBgImage.Height - 10, GraphicsUnit.Pixel);
            //右下角
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + descRect.Width - 5, descRect.Y + descRect.Height - 5, 5, 5), srcBgImage.Width - 5, srcBgImage.Height - 5, 5, 5, GraphicsUnit.Pixel);
            //下边
            g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + descRect.Height - 5, descRect.Width - 10, 5), 5, srcBgImage.Height - 5, srcBgImage.Width - 10, 5, GraphicsUnit.Pixel);
            //平铺中间块
            //g.DrawImage(srcBgImage, new Rectangle(descRect.X + 5, descRect.Y + 5, descRect.Width - 10, descRect.Height - 10), 5, 5, srcBgImage.Width - 10, srcBgImage.Height - 10, GraphicsUnit.Pixel);
        }

        /// <summary>
        /// 绘制进度条
        /// </summary>
        /// <param name="g">画板</param>
        /// <param name="rect">需要绘制的矩形区域</param>
        /// <param name="backgroundColor">进度条的背景颜色</param>
        /// <param name="borderColor">边框颜色</param>
        /// <param name="innerBorderColor">内边框颜色</param>
        /// <param name="roundStyle">绘制圆角的样式</param>
        /// <param name="roundWidth">圆角宽度</param>
        /// <param name="alphaPosition">透明度位置</param>
        /// <param name="drawBorder">是否绘制边框</param>
        /// <param name="drawGlass">是否绘制进度传输的颜色</param>
        /// <param name="mode">指定渐变颜色的方向</param>
        public static void RenderProgressBarBackground(Graphics g, Rectangle rect, Color backgroundColor, Color borderColor, ERoundStyle roundStyle, int roundWidth, float alphaPosition, bool drawBorder, bool drawGlass, LinearGradientMode mode)
        {
            if (drawBorder)
            {
                rect.Width--;
                rect.Height--;
            }
            if (rect.Width <= 0 || rect.Height <= 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, mode))
            {
                Color[] colors = new Color[4];
                colors[0] = ColorHelper.GetColor(backgroundColor, 0, 35, 24, 9);
                colors[1] = ColorHelper.GetColor(backgroundColor, 0, 13, 8, 3);
                colors[2] = backgroundColor;
                colors[3] = ColorHelper.GetColor(backgroundColor, 0, 68, 69, 54);

                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, alphaPosition, alphaPosition + 0.05f, 1.0f };
                blend.Colors = colors;
                brush.InterpolationColors = blend;
                if (roundStyle != ERoundStyle.None)
                {
                    using (GraphicsPath path = GraphicsPathHelper.CreatePath(rect, roundWidth, roundStyle, false))
                    {
                        g.FillPath(brush, path);
                    }
                    if (drawBorder)
                    {
                        using (GraphicsPath path = GraphicsPathHelper.CreatePath(rect, roundWidth, roundStyle, false))
                        {
                            using (Pen pen = new Pen(borderColor))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                    }
                }
                else
                {
                    g.FillRectangle(brush, rect);
                    if (backgroundColor.A > 80)
                    {
                        Rectangle rectTop = rect;
                        if (mode == LinearGradientMode.Vertical)
                            rectTop.Height = (int)(rectTop.Height * alphaPosition);
                        else
                            rectTop.Width = (int)(rect.Width * alphaPosition);
                        using (SolidBrush brushAlpha = new SolidBrush(Color.FromArgb(80, 255, 255, 255)))
                        {
                            g.FillRectangle(brushAlpha, rectTop);
                        }
                    }
                    if (drawGlass)
                    {
                        RectangleF glassRect = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            glassRect.Y = rect.Y + rect.Height * alphaPosition;
                            glassRect.Height = (rect.Height - rect.Height * alphaPosition) * 2;
                        }
                        else
                        {
                            glassRect.X = rect.X + rect.Width * alphaPosition;
                            glassRect.Width = (rect.Width - rect.Width * alphaPosition) * 2;
                        }
                        DrawGlass(g, glassRect, 200, 0);
                    }
                    if (drawBorder)
                    {
                        using (Pen pen = new Pen(borderColor))
                        {
                            g.DrawRectangle(pen, rect);
                        }
                    }
                }
            }
        }
        public static void DrawGlass(Graphics g, RectangleF glassRect, int alphaCenter, int alphaSurround)
        {
            DrawGlass(g, glassRect, Color.White, alphaCenter, alphaSurround);
        }
        public static void DrawGlass(Graphics g, RectangleF glassRect, Color glassColor, int alphaCenter, int alphaSurround)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(glassRect);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(alphaCenter, glassColor);
                    brush.SurroundColors = new Color[] { Color.FromArgb(alphaSurround, glassColor) };
                    brush.CenterPoint = new PointF(
                        glassRect.X + glassRect.Width / 2,
                        glassRect.Y + glassRect.Height / 2);
                    g.FillPath(brush, path);
                }
            }
        }
        public static Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;

            if (a + a0 > 255) { a = 255; } else { a = Math.Max(a + a0, 0); }
            if (r + r0 > 255) { r = 255; } else { r = Math.Max(r + r0, 0); }
            if (g + g0 > 255) { g = 255; } else { g = Math.Max(g + g0, 0); }
            if (b + b0 > 255) { b = 255; } else { b = Math.Max(b + b0, 0); }

            return Color.FromArgb(a, r, g, b);
        }
        public static void RenderListViewBackground(Graphics g, Rectangle rect, Color baseColor, Color borderColor, Color innerBorderColor, bool drawBorder, LinearGradientMode mode)
        {
            if (drawBorder)
            {
                rect.Width--;
                rect.Height--;
            }
            if (rect.Width <= 0 || rect.Height <= 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, mode))
            {
                Color[] colors = new Color[2];
                colors[0] = baseColor;
                colors[1] = GetColor(baseColor, 0, 11, 6, 4);

                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, 1.0f };
                blend.Colors = colors;
                brush.InterpolationColors = blend;
                g.FillRectangle(brush, rect);
            }
            if (drawBorder)
            {
                using (Pen pen = new Pen(Color.FromArgb(123, 178, 217)))
                {
                    g.DrawRectangle(pen, rect);
                }
                rect.Inflate(-1, -1);
                using (Pen pen = new Pen(innerBorderColor))
                {
                    g.DrawRectangle(pen, rect);
                }
            }
        }
        /// <summary>
        /// 画ComboBox下拉按钮图片
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="image"></param>
        /// <param name="g"></param>
        public static void DrawComboBoxArrowButtonBorderBackground(Rectangle rectangle, Image image, Graphics g)
        {
            //左上角
            g.DrawImage(image, new Rectangle(rectangle.X, rectangle.Y, 5, 5), new Rectangle(0, 0, 5, 5), GraphicsUnit.Pixel);
            //上边
            g.DrawImage(image, new Rectangle(rectangle.X + 5, rectangle.Y, rectangle.Width - 10, 5), new Rectangle(5, 0, image.Width - 10, 5), GraphicsUnit.Pixel);
            //右上角
            g.DrawImage(image, new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y, 5, 5), new Rectangle(image.Width - 5, 0, 5, 5), GraphicsUnit.Pixel);
            //左边
            g.DrawImage(image, new Rectangle(rectangle.X, rectangle.Y + 5, 5, rectangle.Height - 10), new Rectangle(0, 5, 5, image.Height - 10), GraphicsUnit.Pixel);
            //中间
            g.DrawImage(image, new Rectangle(rectangle.X + 5, rectangle.Y + 5, rectangle.Width - 10, rectangle.Height - 10), new Rectangle(5, 5, image.Width - 10, image.Height - 10), GraphicsUnit.Pixel);
            //右边
            g.DrawImage(image, new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y + 5, 5, rectangle.Height - 10), new Rectangle(image.Width - 5, 5, 5, image.Height - 10), GraphicsUnit.Pixel);
            //左下角
            g.DrawImage(image, new Rectangle(rectangle.X, rectangle.Y + rectangle.Height - 5, 5, 5), new Rectangle(0, image.Height - 5, 5, 5), GraphicsUnit.Pixel);
            //下边
            g.DrawImage(image, new Rectangle(rectangle.X + 5, rectangle.Y + rectangle.Height - 5, rectangle.Width - 10, 5), new Rectangle(5, image.Height - 5, image.Width - 10, 5), GraphicsUnit.Pixel);
            //右下角
            g.DrawImage(image, new Rectangle(rectangle.X + rectangle.Width - 5, rectangle.Y + rectangle.Height - 5, 5, 5), new Rectangle(image.Width - 5, image.Height - 5, 5, 5), GraphicsUnit.Pixel);
        }
    }
}
