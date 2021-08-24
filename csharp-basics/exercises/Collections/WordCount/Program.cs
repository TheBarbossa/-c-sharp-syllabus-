using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name = "\\lear.txt";
            file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + file_name;
            System.IO.StreamReader objReader = new System.IO.StreamReader(file_name);

            int CharCount, LinesCount, WordCount, index;
            CharCount = LinesCount = WordCount = index = 0;
            string FileText = new System.IO.StreamReader(file_name).ReadToEnd();

            CharCount = FileText.Length;
            LinesCount = FileText.Split(new char[] { '\n' }).Length;

            while (index < FileText.Length)
            {
                while (index < FileText.Length && !char.IsWhiteSpace(FileText[index]) && FileText[index]!='\'')
                    index++;

                WordCount++;

                while (index < FileText.Length && FileText[index] == '\'')
                    index++;
                while (index < FileText.Length && char.IsWhiteSpace(FileText[index]))
                    index++;
            }
            Console.WriteLine($"Lines = {LinesCount}");
            Console.WriteLine($"Words = {WordCount}");
            Console.WriteLine($"Chars = {CharCount}");
            objReader.Close();
            Console.ReadKey();
        }
    }
}
