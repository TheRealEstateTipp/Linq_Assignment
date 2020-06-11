using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a function that contains a substring of "th"
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var substringTH = words.Select(w => w.Contains("th"));


            //write a function that takes in a list of strings and returns a copy of the list without duplicates 

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            var differentNamesOnly = names.Distinct();

            

            //Take in a list of Grades
            //Drop lowest grade for each student
            //Avg remaining grades from list
            //Avg the avg of student grades

            List<string> classGrades = new List<string>()
            {
                "80, 100, 92, 89, 65",
                "93, 81, 78, 84, 69",
                "73, 88, 83, 99, 64",
                "98, 100, 66, 74, 55",
            };

            List<double> listofaverages = new List<double>();
            foreach (var studentGrades in classGrades)
            {
                // convert each string to a collection (list?) of integers
                //studentGrades.Split();
                string[] studentGradesArray = studentGrades.Split(',');

                var newStudentGrades = studentGradesArray.OrderByDescending(g => g).Take(studentGradesArray.Count() - 1).ToList();
                var grades = newStudentGrades.Select(int.Parse).ToList();
                var studentAverage = grades.Average();
                listofaverages.Add(studentAverage);
            }

            var classAverage = listofaverages.Average();

            


        }
    }
}
