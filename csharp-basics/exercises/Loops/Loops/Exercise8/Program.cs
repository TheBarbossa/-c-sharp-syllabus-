using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            int sk, sk2, sk3;
            Console.Write("Please enter your figures size: ");
            sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            sk2 = sk;
            sk3 = 1;

            for (int i = 0; i < 4 * (sk - 1); i++)
            {
                Console.Write("/");
            }
            for (int i = 0; i < 4 * (sk - 1); i++)
            {
                Console.Write("\\");
            }
            Console.Write('\n');

            do
            {
                for (int i = 0; i < 4 * (sk2 - 2); i++)
                {
                    Console.Write("/");
                }
                for (int i = 0; i < 8 * sk3; i++)
                {
                    Console.Write("*");
                }

                for (int i = 0; i < 4 * (sk2 - 2); i++)
                {
                    Console.Write("\\");
                }
                Console.Write('\n');
                sk3++;
                sk2--;
            } while (sk2 > 1);
        }
    }
}