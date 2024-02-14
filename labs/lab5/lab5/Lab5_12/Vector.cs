using System;
using System.Windows.Forms;

namespace Graphics3DLab
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public Vector() { }
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}