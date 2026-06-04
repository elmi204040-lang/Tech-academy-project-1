using System;

namespace OperatorsAssignment
{
    /// <summary>
    /// Main entry point for the console application.
    /// Demonstrates how to compare Employee objects using operator overloading.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Operators Assignment - Employee Comparison";

            Console.WriteLine("===== Operators Assignment =====\n");

            // Create the first Employee object and assign values.
            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Create the second Employee object and assign values.
            Employee emp2 = new Employee()
            {
                Id = 101, // Same ID to show equality based on Id property.
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Display both employees.
            Console.WriteLine($"Employee 1: {emp1}");
            Console.WriteLine($"Employee 2: {emp2}\n");

            // Compare the two Employee objects using the overloaded "==" operator.
            bool areEqual = emp1 == emp2;
            Console.WriteLine($"Are Employee 1 and Employee 2 equal by Id? {areEqual}");

            // Compare using "!=" for completeness.
            bool areNotEqual = emp1 != emp2;
            Console.WriteLine($"Are Employee 1 and Employee 2 not equal? {areNotEqual}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
