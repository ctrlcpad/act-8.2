using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable students = new Hashtable();

        // Store the student details using Student ID as the key
        students.Add("101", "Name:\t\tJose Marie Chou\nAddress:\tSolano\nContact no:\tN/A");
        students.Add("102", "Name:\t\tMarites Alcantara\nAddress:\tBayombong\nContact no:\t09273744546");
        students.Add("103", "Name:\t\tPepito Montalban\nAddress:\tAritao\nContact no:\t09184476548");

        Console.WriteLine("Welcome to my HASHTABLE Program");

        string choice = "Y";

        while (choice.ToUpper() == "Y")
        {
            Console.WriteLine("Here are the available records:");
            Console.WriteLine("Student ID");
            Console.WriteLine("101");
            Console.WriteLine("102");
            Console.WriteLine("103");

            Console.Write("\nEnter look up id: ");
            string id = Console.ReadLine();

            if (students.ContainsKey(id))
            {
                Console.WriteLine("\nHere is the detailed information:");
                Console.WriteLine("Student ID:\t" + id);
                Console.WriteLine(students[id]);
            }
            else
            {
                Console.WriteLine("Record is not existing!");
            }

            Console.Write("\nWould you like to search another record? [Y/N]: ");
            choice = Console.ReadLine();
        }
    }
}