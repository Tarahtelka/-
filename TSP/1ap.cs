namespace AP
{
    /********************************************************************
    Class defining a complex number with double precision.
    ********************************************************************/
    public struct Complexx
    {
        public double x;
        public double y;

        public Complexx(double _x)
        {
            x = _x;
            y = 0;
        }
        public Complexx(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public static implicit operator Complexx(double _x)
        {
            return new Complexx(_x);
        }
        //public static bool operator==(Complexx lhs, Complexx rhs)
        //{
        //    return (lhs.x==rhs.x) & (lhs.y==rhs.y);
        //}
        //public static bool operator!=(Complexx lhs, Complexx rhs)
        //{
        //    return (lhs.x!=rhs.x) | (lhs.y!=rhs.y);
        //}
        public static Complexx operator+(Complexx lhs)
        {
            return lhs;
        }
        public static Complexx operator-(Complexx lhs)
        {
            return new Complexx(-lhs.x,-lhs.y);
        }
        public static Complexx operator+(Complexx lhs, Complexx rhs)
        {
            return new Complexx(lhs.x+rhs.x,lhs.y+rhs.y);
        }
        public static Complexx operator-(Complexx lhs, Complexx rhs)
        {
            return new Complexx(lhs.x-rhs.x,lhs.y-rhs.y);
        }
        public static Complexx operator*(Complexx lhs, Complexx rhs)
        { 
            return new Complexx(lhs.x*rhs.x-lhs.y*rhs.y, lhs.x*rhs.y+lhs.y*rhs.x);
        }
        public static Complexx operator/(Complexx lhs, Complexx rhs)
        {
            Complexx result;
            double e;
            double f;
            if( System.Math.Abs(rhs.y)<System.Math.Abs(rhs.x) )
            {
                e = rhs.y/rhs.x;
                f = rhs.x+rhs.y*e;
                result.x = (lhs.x+lhs.y*e)/f;
                result.y = (lhs.y-lhs.x*e)/f;
            }
            else
            {
                e = rhs.x/rhs.y;
                f = rhs.y+rhs.x*e;
                result.x = (lhs.y+lhs.x*e)/f;
                result.y = (-lhs.x+lhs.y*e)/f;
            }
            return result;
        }
    }    
    
    /********************************************************************
    AP math namespace
    ********************************************************************/
    public class Math
    {
        private static System.Random RndObject = new System.Random();

        public const double MachineEpsilon = 5E-16;
        public const double MaxRealNumber = 1E300;
        public const double MinRealNumber = 1E-300;
        
        public static double RandomReal()
        {
            return RndObject.NextDouble();
        }
        public static int RandomInteger(int N)
        {
            return RndObject.Next(N);
        }
        public static double Sqr(double X)
        {
            return X*X;
        }        
        public static double AbsComplex(Complexx z)
        {
            double w;
            double xabs;
            double yabs;
            double v;
    
            xabs = System.Math.Abs(z.x);
            yabs = System.Math.Abs(z.y);
            w = xabs>yabs ? xabs : yabs;
            v = xabs<yabs ? xabs : yabs; 
            if( v==0 )
                return w;
            else
            {
                double t = v/w;
                return w*System.Math.Sqrt(1+t*t);
            }
        }
        public static Complexx Conj(Complexx z)
        {
            return new Complexx(z.x, -z.y); 
        }    
        public static Complexx CSqr(Complexx z)
        {
            return new Complexx(z.x*z.x-z.y*z.y, 2*z.x*z.y); 
        }

    }
}
