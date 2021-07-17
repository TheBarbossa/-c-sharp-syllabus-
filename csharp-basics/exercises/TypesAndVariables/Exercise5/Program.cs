using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            string[] subjects =
            {
                "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II",
                "AP US History", "Business Computer Information Systems"
            };
            string[] subjectTeachers =
            {
                "Ms.Lapan", "Mrs.Gideon", "Mr.Davis", "Ms.Palmer", "Ms.Garcia", "Mrs.Barnett", "Ms.Johannessen",
                "Mr.James"
            };

            Console.Write("+------------------------------------------------------------+");

            String data = String.Format("{0,-5} {1,-40} {2,-15} \n\n",
                "Nr.", "Subject", "Teacher");

            for (int n = 0; n < subjects.Length; n++){
                data += String.Format("{0,-5} {1,-40} {2,-15} \n",
                    num, subjects[n], subjectTeachers[n]);
            num++;
            }

            Console.WriteLine($"\n{data}");
            
            Console.Write("+------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}
