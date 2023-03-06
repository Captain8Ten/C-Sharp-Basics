using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Tony";
            String lastName = "Stark";
            string myFirstName = "Steve";
            string myLastname = "Rodgers";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Concat(myFirstName, myLastname);

            var fullName2 = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Hulk", "Thor", "Loki" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(formattedNames);

            var text = "Hey Ironman\nTake the nuke out of the city\nHulk smash\nand Hawkeye I need folders from \\folder1\\folder2";
            
            Console.WriteLine(text);

        }
    }
}