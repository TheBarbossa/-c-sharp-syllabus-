using System;
using System.Text.RegularExpressions;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Welcome, please enter your string:");
            var input = Console.ReadLine().ToLower();
            if (ValidString(input)) {
                char[] charArr = input.ToCharArray();
                foreach (char ch in charArr) {
                    switch (ch) {
                        case 'a':
                        case 'b':
                        case 'c':
                            Console.Write(2);
                            break;
                        case 'd':
                        case 'e':
                        case 'f':
                            Console.Write(3);
                            break; //return also works
                        case 'g':
                        case 'h':
                        case 'i':
                            Console.Write(4);
                            break;
                        case 'j':
                        case 'k':
                        case 'l':
                            Console.Write(5);
                            break;
                        case 'm':
                        case 'n':
                        case 'o':
                            Console.Write(6);
                            break;
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            Console.Write(7);
                            break;
                        case 't':
                        case 'u':
                        case 'v':
                            Console.Write(8);
                            break;
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            Console.Write(9);
                            break;
                    }
                }
            }
            else {
                Console.WriteLine("Not a valid string.");
            }
            Console.ReadKey();
        }
        public static bool ValidString(string inputString) {
            string strRegex = @"(^[a-zA-Z]+$)";
            Regex reg = new Regex(strRegex);
            return reg.IsMatch(inputString) ? true : false;
        }
    }
}
