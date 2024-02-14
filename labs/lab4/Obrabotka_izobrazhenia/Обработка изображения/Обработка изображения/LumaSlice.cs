using System.Drawing;

namespace Обработка_изображения
{
    class LumaSlice
    {
        private byte fMin;
        private byte fMax;
        private byte fLeft;
        private byte fRight;
        public Bitmap Bmp { get; }

        public LumaSlice(Bitmap bmpGray)
        {
            Bmp = new Bitmap(bmpGray);
        }

        public void Convert(byte fPercentLeft, byte fPercentRight)
        {
            DefineBrightnessLimits();
            fLeft = GetWorkingInterval(fPercentLeft);
            fRight = GetWorkingInterval(fPercentRight);
            for (int y = 0; y < Bmp.Height; y++)
            {
                for (int x = 0; x < Bmp.Width; x++)
                {
                    
                    Bmp.SetPixel(x, y, GetG(Bmp.GetPixel(x, y)));
                }
            }
        }

        private void DefineBrightnessLimits()
        {
            
            byte f;
            fMin = 255;
            fMax = 0;
            
            for (int y = 0; y < Bmp.Height; y++)
            {
                for (int x = 0; x < Bmp.Width; x++)
                {
                    f = Bmp.GetPixel(x, y).R;
                    if (f < fMin) fMin = f;
                    if (f > fMax) fMax = f;
                }
            }
        }

        private byte GetWorkingInterval(byte fPercent)
        {
            
            return (byte)(fMin + (fPercent * (fMax - fMin) / 100));
        }

        private Color GetG(Color gray)
        {
            byte g = GetG(gray.R);
            return Color.FromArgb(gray.A, g, g, g);
        }

        private byte GetG(byte f)
        {
            if (f < fLeft || f > fRight) return 0;
            else return 255;
        }
    }
}
