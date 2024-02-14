using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractalization {
	class Fractal {
		private PointF Position;
		private double Angle;
		private Painter painter;
		
		public Fractal(Painter painter) {
			this.painter = painter;
			Reset();
		}

		public string Axioma = "F+F+F+F++F-F-F-F"; //аксиома 
		public int Step { get; set; } = 20; //шаг h
        public PointF StartPoint { get; set; } = new PointF(200, 200); //начальная точка 

		public void Reset() {
			Position = StartPoint;
			Angle = 0d;
			painter.Clear();
		}

        public void СheckString(string controlString) //просматриваем посимвольно строку 
		{
			Reset();
			foreach (char c in controlString) Check(c);
		}

		private void Check(char с) //в зависимости от символа выбираем действие 
		{
			switch (с) 
			{
				case '+':							
					Angle += Math.PI / 2; 
					break;

				case '-':							
					Angle -= Math.PI / 2; 
					break;

				case 'F':										 
					PointF nextPoint = NextPoint(Position); 
					painter.DrawLine(Position, nextPoint);
					Position = nextPoint; 
					break;
			}
		}

		private PointF NextPoint(PointF point) {
			return new PointF((float)(point.X + Step * Math.Cos(Angle)), (float)(point.Y + Step * Math.Sin(Angle))); //новая точка
		}
	}
}
