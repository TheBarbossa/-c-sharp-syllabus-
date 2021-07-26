using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] numuri1 = new int[10];
            int[] numuri2 = new int[10];
            for (int i = 0; i < numuri1.Length; i++) {
                numuri1[i] = rand.Next(1,101);
            }
            Array.Copy(numuri1,numuri2,10);
            numuri1[numuri1.Length - 1] = -7;
            Console.Write("Array 1: ");
            foreach (int i in numuri1) {
                Console.Write("{0} ", i);
            }
            Console.Write("\nArray 2: ");
            foreach (int i in numuri2) {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
