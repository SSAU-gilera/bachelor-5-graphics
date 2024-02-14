using System.Drawing;

namespace Fractalization {

	class Painter {
		private const int paintWidth = 1000;
		private const int paintHeight = 1000;
		private Color paintColor = Color.Black;
		private const float paintPenWidth = 1f;

		private Bitmap bitmap;
		private Graphics graphics;
		private Pen pen;


		public Painter() {
			bitmap = new Bitmap(paintWidth, paintHeight);
			graphics = Graphics.FromImage(bitmap);
			pen = new Pen(paintColor, paintPenWidth);
		}

		public Bitmap Bitmap => bitmap; // Возвращает картинку, на которой производилось рисование.
             
        public void DrawLine(PointF startPoint, PointF endPoint) {
			graphics.DrawLine(pen, startPoint, endPoint);
		}

		public void Clear() {
			graphics.Clear(Color.Cornsilk);
		}
	}
}
