using System;
using System.Text;

namespace NameCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"D:\vswork\PU-IntroCSharp-2018-1801681078\PUIntroHomeworks\PUIntroHomeworkWeek2\students.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of students.txt = ");
            int tStudents = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string firstName = elements[1];
                string name = $"{ firstName} {elements[3]}";

                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }

                if (sum > 10500)
                {
                    tStudents += 1;
                    Console.WriteLine($"{name} => {(char)0x263A}");

                }
            }

        }
    }
}
