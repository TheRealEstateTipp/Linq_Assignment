using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public static class LinqPractice
    {

        //Write a function that contains a substring of "th"
        public static List<string> THWords()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var substringTH = words.Where(w => w.Contains("th"));
            List <string> newList = substringTH.ToList();
            return newList;
                
        }
       





        //write a function that takes in a list of strings and returns a copy of the list without duplicates 
        public static List<string> DistinctName()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            var differentNames = names.Distinct().ToList();

            return differentNames;
        }

       



        //Take in a list of Grades
        //Drop lowest grade for each student
        //Avg remaining grades from list
        //Avg the avg of student grades
        public static double Classaverage()
        {
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
            return classAverage;
        }



        //Write a function that takes in a string of letters
        //Returns Alphabetically Ordered String
        //Letter Frequency

        public static void AlphabetizeFrequency(string t)
        {
            char[] newArray = t.ToCharArray();
            var abcFrequency = newArray.GroupBy(a => a).OrderBy(a => a.Count()).ThenBy(a => a.Key);
            var mycharacter = abcFrequency.Select(a => a.Key).ToString();
            var frequency = abcFrequency.Select(a => a.Count()).ToString();
         
            foreach (var character in abcFrequency)
            {
                 Console.WriteLine(mycharacter, frequency);
            }
             
        }





    }
               
         
       
}
