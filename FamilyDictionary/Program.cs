using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Gary" }, { "age", "72" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Lavonna" }, { "age", "70" } });
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Amy" }, { "age", "44" } });

            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }


        }
    }
}
