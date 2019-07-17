namespace Curs2.App
{
    public class Calculations
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            var firstSum = Sum(a, b);

            return firstSum + c;
        }

        public int Sum(int a, int b, int c, int d)
        {
            var firstSum = Sum(a, b, c);

            return firstSum + d;
        }
    }
}
