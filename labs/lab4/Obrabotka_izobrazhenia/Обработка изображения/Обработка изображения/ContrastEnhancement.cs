using System.Drawing;

namespace Обработка_изображения
{
    class ContrastEnhancement
    {
        private delegate Color GetGray();
        private readonly Bitmap bmpGray;
        private int[,] mask;
        public Bitmap Bmp { get; }

        public ContrastEnhancement(Bitmap bmpGray)
        {
            this.bmpGray = new Bitmap(bmpGray);
            Bmp = new Bitmap(bmpGray);
        }

        public void Convert(int[,] mask)
        {
            this.mask = mask;
            for (int y = 1; y <= Bmp.Height - 2; y++)
            {
                for (int x = 1; x <= Bmp.Width - 2; x++)
                {                    
                    Bmp.SetPixel(x, y, GetColor(() =>
                    {
                        
                        int g = 0;
                        for (int i = 0; i <= 2; i++)
                        {
                            for (int j = 0; j <= 2; j++)
                            {
                                
                                g += bmpGray.GetPixel(x + j - 1, y + i - 1).R * mask[i, j];
                            }
                        }
                        if (g < 0) g = 0;
                        else if (g > 255) g = 255;
                        return Color.FromArgb(bmpGray.GetPixel(x, y).A, g, g, g);
                    }));
                }
            }
            DrawBorders();
        }

        private Color GetColor(GetGray del)
        {
            return del();
        }

        private void DrawBorders()
        {
            int w = Bmp.Width;
            int h = Bmp.Height;
            
            DrawBorderLine(1, w - 2, 0, 0);
            DrawBorderLine(1, w - 2, h - 1, h - 1);
            
            DrawBorderLine(0, 0, 1, h - 2);
            DrawBorderLine(w - 1, w - 1, 1, h - 2);
            
            DrawBorderLine(0, 0, 0, 0);
            DrawBorderLine(w - 1, w - 1, 0, 0);
            DrawBorderLine(0, 0, h - 1, h - 1);
            DrawBorderLine(w - 1, w - 1, h - 1, h - 1);
            
            CalculateMask(0, 2, 0, 2);
        }

        private void DrawBorderLine(int x1, int x2, int y1, int y2)
        {
            int i1 = 0;
            int i2 = 0;
            int j1 = 0;
            int j2 = 0;
            
            if (y1 == 1 && y2 == Bmp.Height - 2)
            {
                i1 = 0;
                i2 = 2;
            }
            else
            {
                
                if (y1 == 0)
                {
                    i1 = 1;
                    i2 = 2;
                }
                
                if (y2 == Bmp.Height - 1)
                {
                    i1 = 0;
                    i2 = 1;
                }
            }
            
            if (x1 == 1 && x2 == Bmp.Width - 2)
            {
                j1 = 0;
                j2 = 2;
            }
            else
            {
                
                if (x1 == 0)
                {
                    j1 = 1;
                    j2 = 2;
                }
                
                if (x2 == Bmp.Width - 1)
                {
                    j1 = 0;
                    j2 = 1;
                }
            }
            
            CalculateMask(i1, i2, j1, j2);

            for (int y = y1; y <= y2; y++)
            {
                for (int x = x1; x <= x2; x++)
                {
                    Bmp.SetPixel(x, y, GetColor(() =>
                    {
                        int rgb = 0;
                        for (int i = i1; i <= i2; i++)
                        {
                            for (int j = j1; j <= j2; j++)
                            {
                                rgb += bmpGray.GetPixel(x + j - 1, y + i - 1).R * mask[i, j];
                            }
                        }
                        if (rgb < 0) rgb = 0;
                        else if (rgb > 255) rgb = 255;
                        return Color.FromArgb(bmpGray.GetPixel(x, y).A, rgb, rgb, rgb);
                    }));
                }
            }
        }

        private void CalculateMask(int i1, int i2, int j1, int j2)
        {
            int sum = 0;
            for (int i = i1; i <= i2; i++)
            {
                for (int j = j1; j <= j2; j++)
                {
                    if (i == 1 && j == 1) continue;
                    sum -= mask[i, j];
                }
            }
            mask[1, 1] = sum + 1;
        }
    }
}
