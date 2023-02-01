namespace Fifa22.Common
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
