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

        }
    }
}
