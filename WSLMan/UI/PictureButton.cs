using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.UI
{
    public class PictureButton : Button
    {
        private bool _isOver = false;

        public PictureButton() 
        {
            FlatStyle =     FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Cursor = Cursors.Hand;
            _isOver = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Cursor = Cursors.Default;
            _isOver = false;
            base.OnMouseLeave(e);
        }

        private Image GrayScaleImg(Image originalImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][]
                {
                new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
                });

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(grayImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                            0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return grayImage;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Image img;
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

            if (Image != null)
            {
                int x = (this.Width - Image.Width) / 2;
                int y = (this.Height - Image.Height) / 2;

                if (Enabled)
                    img = Image;
                else
                    img = GrayScaleImg(Image);

                if (_isOver)
                    e.Graphics.DrawImage(img, x + 1, y + 1, img.Width, img.Height);
                else
                    e.Graphics.DrawImage(img, x, y, img.Width, img.Height);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, ClientRectangle);
        }


    }
}
