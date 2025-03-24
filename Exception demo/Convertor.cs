using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_demo
{
    internal static class Convertor // static - не можна створити обєкт класу, усі елементи повинні бути статичними 
    {
        public const double inches = 2.54;
        public static double ToInches(double cm)
        {
            if (cm < 0)
                throw new Exception("Cm should be >=0");
            return cm / inches;
        }
        public static double ToCm(double inch)
        {
            if (inch < 0)
                throw new Exception("Inches should be >=0");
            return  inch * inches;
        }
    }
}
