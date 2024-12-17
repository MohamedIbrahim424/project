using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Student
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Scoreone { get; set; }
        public double Scoretwo { get; set; }
        public double Average { get; set; }
        public string Rating { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Enter the number of students:");
            int studentnumber = int.Parse(Console.ReadLine());

            // enter student information
            for (int i = 1; i <= studentnumber ; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Enter details for student " + i + ":");

                Console.Write("number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("First Exam Score: ");
                int scoreone = Convert.ToInt32(Console.ReadLine());

                Console.Write("Second Exam Score: ");
                int scoretwo = Convert.ToInt32(Console.ReadLine());

                // Calculate the average
                int average = (scoreone + scoretwo) / 2;

                // Determine rating
                string rating = GetRating(average);

                // Add student to list
                students.Add(new Student
                {
                    Number = number,
                    Name = name,
                    Scoreone = scoreone,
                    Scoretwo = scoretwo,
                    Average = average,
                    Rating = rating
                });
            }

            // Sort students by final score
            var sortedStudents = students.OrderBy(s => s.Average).ToList();

            // Display results
            Console.WriteLine();
            Console.WriteLine(" Student's informations: ");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Number: " + student.Number + ", " + " Name: " + student.Name + ", " + " Scoreone: " + student.Scoreone + ", " + " Scoretwo: " + student.Scoretwo + ", " + " Average: " + student.Average + ", " + " Rating: " + student.Rating);
            }
        }

        // Method to determine rating
        static string GetRating(int score)
        {
            if (score < 50)
                return "fail";
            else if (score <= 70)
                return "good";
            else if (score <= 85)
                return "very good";
            else
                return "excellent";
        }
    }
}
