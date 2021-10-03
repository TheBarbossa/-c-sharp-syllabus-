namespace Arithmetics6
{
    public class Arithmetics6Extension
    {
        public static string PrintNumber(int i)
        {
            return (i % 3 != 0 & i % 5 != 0 & i % 7 != 0) ? $"{i}" :"";
        }
        public static string PrintCoza(int i)
        {
            return (i % 3 == 0) ? "Coza" : "";
        }
        public static string PrintLoza(int i)
        {
            return (i % 5 == 0) ? "Loza" : "";
        }
        public static string PrintWoza(int i)
        {
            return (i % 7 == 0) ? "Woza" : "";
        }
    }
}