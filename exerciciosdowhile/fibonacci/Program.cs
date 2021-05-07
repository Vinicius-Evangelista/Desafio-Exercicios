using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for (var i = 0; i < 500; i++)
            {


                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(a);

            }
        }
    }
}
