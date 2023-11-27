using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.UI
{
    public class SimpleGroupBox : GroupBox
    {

        [Localizable(true)]
        [Category("Extra Properties")]
        [Description("Custom Visual Style")]
        [Browsable(true)]
        public CustomStyle CStyle
        {
            get { return _customStyle; }
            set { _customStyle = value; Invalidate(); }
        }

        [Localizable(true)]
        [Category("Extra Properties")]
        [Description("Border Color")]
        [Browsable(true)]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        [Localizable(true)]
        [Category("Extra Properties")]
        [Description("Border Size")]
        [Browsable(true)]
        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = value; Invalidate(); }
        }

        public enum CustomStyle
        {
            NORMAL,
            SOLID,
            SOLID_NO_BORDERS,
        }

        private CustomStyle _customStyle = CustomStyle.NORMAL;
        private Color _borderColor = Color.DarkGray;
        private int _borderSize = 1;


        protected override void OnPaint(PaintEventArgs e)
        {

            if (_customStyle == CustomStyle.NORMAL)
            {
                base.OnPaint(e);
            }
            else if (_customStyle == CustomStyle.SOLID)
            {
                int textPosXOffset = 8;
                int textHeight = 12;

                // Draw Rectangle
                if (this.Text == "")
                {
                    // fill all client area
                    e.Graphics.FillRectangle(new SolidBrush(_borderColor), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(_borderSize, _borderSize, Width - (_borderSize * 2), Height - (_borderSize * 2)));
                }
                else
                {
                    // fill part of client area and leave some space at the top for the text
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
                    e.Graphics.FillRectangle(new SolidBrush(_borderColor), new Rectangle(0, textHeight, ClientRectangle.Width, ClientRectangle.Height - textHeight));
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(_borderSize, _borderSize + textHeight, Width - (_borderSize * 2), Height - (_borderSize * 2) - textHeight));
                }


                // Draw Text
                int textPosX = _borderSize + textPosXOffset;
                Size textSize =         TextRenderer.MeasureText(Text, Font);
                Rectangle textBounds =  new Rectangle(textPosX, 0, textSize.Width, textSize.Height);

                e.Graphics.FillRectangle(new SolidBrush(BackColor), textBounds);
                TextRenderer.DrawText(e.Graphics, Text, Font, new Point(textPosX, 0), ForeColor);
            }
            else if (_customStyle == CustomStyle.SOLID_NO_BORDERS)
            {
                e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
                //TextRenderer.DrawText(e.Graphics, Text, Font, new Point(0, 0), ForeColor);
            }

        }

    }
}
