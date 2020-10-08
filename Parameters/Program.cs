using System;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(50, 50);
            ParamsString("tanel");
        }

        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        public static void ParamsString(string a)
        {
            Console.WriteLine(a);
        }
    }
}
