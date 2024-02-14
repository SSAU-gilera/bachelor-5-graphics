using System;
using System.Drawing;
using System.Windows.Forms;

namespace Обработка_изображения
{
    public partial class Main_Form : Form
    {
        private int w;
        private int h;
        private int threshold;
        private int[,] mask = new int[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
        private Bitmap bmp;
        private Bitmap bmpGray;
        private Bitmap bmpContours;

        public Main_Form()
        {           
            InitializeComponent();

            bmp = new Bitmap("pic.jpg");
            w = bmp.Width;
            h = bmp.Height;
            pictureBox1.Width = w;
            pictureBox1.Height = h;
            pictureBox1.Image = bmp;

            buttonGray.Click += (s, e) => {
                GetGray();
                pictureBox1.Image = bmpGray;
            };

            buttonContrastEnhancement.Click += (s, e) => {
                if (bmpGray == null) GetGray();
                ContrastEnhancement contrastEnhancement = new ContrastEnhancement(bmpGray);
                contrastEnhancement.Convert(mask);
                pictureBox1.Image = contrastEnhancement.Bmp;
            };
        }

        private void GetGray()
        {
            bmpGray = (Bitmap)bmp.Clone();
            Color color;
            byte g;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    color = bmp.GetPixel(x, y);
                    g = (byte)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                    bmpGray.SetPixel(x, y, Color.FromArgb(g, g, g));
                }
            }
        }

        private void GetContours(object sender, EventArgs e)
        {
            if (!int.TryParse(maskedTextBoxContours.Text, out threshold)) return;
            if (bmpGray == null) GetGray();
            bmpContours = new Bitmap(bmpGray);
            for (int y = 0; y < h - 1; y++)
            {
                for (int x = 0; x < w - 1; x++)
                {
                    bmpContours.SetPixel(x, y, GetE(
                        bmpGray.GetPixel(x, y).A,
                        bmpGray.GetPixel(x, y).R,
                        bmpGray.GetPixel(x + 1, y).R,
                        bmpGray.GetPixel(x, y + 1).R));
                }
            }
           
            for (int x = 0; x < w - 1; x++)
            {
                bmpContours.SetPixel(x, h - 1, GetE(
                    bmpGray.GetPixel(x, h - 1).A,
                    bmpGray.GetPixel(x, h - 1).R,
                    bmpGray.GetPixel(x + 1, h - 1).R,
                    bmpGray.GetPixel(x, h - 1).R));
            }
            
            for (int y = 0; y < h - 1; y++)
            {
                bmpContours.SetPixel(w - 1, y, GetE(
                    bmpGray.GetPixel(w - 1, y).A,
                    bmpGray.GetPixel(w - 1, y).R,
                    bmpGray.GetPixel(w - 1, y).R,
                    bmpGray.GetPixel(w - 1, y + 1).R));
            }
            
            LumaSlice lumaSlice = new LumaSlice(bmpContours);
            lumaSlice.Convert((byte)threshold, 100);
            pictureBox1.Image = lumaSlice.Bmp;
        }

        private Color GetE(byte a, byte fCurr, byte fRight, byte fDown)
        {
            int e = (int)Math.Round(Math.Sqrt(Math.Pow(fRight - fCurr, 2) + Math.Pow(fDown - fCurr, 2)));
            if (e > 255) e = 255;
            return Color.FromArgb(a, e, e, e);
        }
    }
}