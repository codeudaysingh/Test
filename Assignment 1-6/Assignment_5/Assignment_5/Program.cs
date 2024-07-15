using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
        static void Main(string[] args)
        {

        Dictionary<string, List<int>> student_record = new Dictionary<string, List<int>>()

            {
            {"Uday", new List<int>() {99,78 } },
            { "Harsh", new List<int>() { 69, 87 } },
            { "Dev", new List<int>() { 78, 60 } }
            };


        foreach (var student in student_record)
            {
               
                Console.WriteLine($"{student.Key}:{string.Join(",", student.Value)}");
            }

            Console.WriteLine();


            Dictionary<string, double> studentAverages = new Dictionary<string, double>();
            foreach (var student in student_record)
            {
                double avg_s = student.Value.Average();
                studentAverages.Add(student.Key, avg_s);
                Console.WriteLine($"Student: {student.Key}, Average Score: {avg_s}");
            }

            Console.WriteLine();


            var topStudent = studentAverages.Aggregate((l, r) => l.Value > r.Value ? l : r);
            Console.WriteLine($"Student with the highest average score: {topStudent.Key}, Average Score: {topStudent.Value}");
        }
}

