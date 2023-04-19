using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double _r;
        private double _g;
        private double _b;

        public Pixel(double r, double g, double b)
        {
            _r = _g = _b = 0;
            R = r;
            G = g;
            B = b;
        }

        public double R
        {
            get { return _r; }
            private set
            {
                _r = Check(value);
            }
        }

        public double Check(double val)
        {
            if (val < 0 || val > 1)
                throw new ArgumentException();
            return val;
        }

        public static double Trim(double val)
        {
            if (val < 0) return 0;
            if (val > 1) return 1;
            return val;
        }

        public double G
        {
            get { return _g; }
            private set
            {
                _g = Check(value);
            }
        }

        public double B
        {
            get { return _b; }
            private set
            {
                _b = Check(value);
            }
        }

        public static Pixel operator *(Pixel p, double c)
        {
            return new Pixel(
                Trim(p.R * c),
                Trim(p.G * c),
                Trim(p.B * c));
        }
        
        public static Pixel operator *(double c, Pixel p)
        {
            return p * c;
        }
    }
}