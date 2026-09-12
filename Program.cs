using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning) {
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("\n wlecome to our calculator");
                Console.WriteLine("*************");

                double num1=GetValidNumber("Enter the first number: "); 
                double num2 = GetValidNumber("Enter the second number: ");

                Console.WriteLine("Select an operation:");
                Console.WriteLine("1, Addition (+)");
                Console.WriteLine("2, Subtraction (-)");
                Console.WriteLine("3, multiply (*)");
                Console.WriteLine("4, division (/)");
                Console.Write("enter your choice (1-4): ");

                String choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine($"Result : {num1} -{num2} = {num1 - num2} ");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                        break;
                    case "4":
                        if(num2 ==0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                         break;
                    default:
                        Console.WriteLine("Invalid operation choice.");
                        break;
                }

                Console.WriteLine("\nDo you want to perform another calculation? (y/n): ");
                string again = Console.ReadLine().Trim().ToLower();
                keepRunning = (again == "y" || again == "yes" || again == "Y");
            }
            Console.WriteLine("Thank you for using the calculator. Goodbye!");


        }

        static double GetValidNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            return number;

        }
    }
}