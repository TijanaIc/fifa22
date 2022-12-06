using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22.Library
{
    public class Helper
    {
        public static int Presek<T>(T[] x, T[] y)
        {
            int counter = 0;
            foreach (T x1 in x)
            {
                foreach (T y1 in y)
                {
                    if (y1.Equals(y1))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        } 
    }
}
