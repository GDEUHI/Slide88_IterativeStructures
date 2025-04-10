using System;

class LoopCalculator {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|     Loop-Based Calculator      |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        string again;
        do {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+ - * /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            double result = 0;
            bool valid = true;

            if (op == "+") result = a + b;
            else if (op == "-") result = a - b;
            else if (op == "*") result = a * b;
            else if (op == "/") {
                if (b != 0) result = a / b;
                else {
                    Console.WriteLine("Division by zero.");
                    valid = false;
                }
            } else {
                Console.WriteLine("Invalid operator.");
                valid = false;
            }

            if (valid)
                Console.WriteLine("Result: " + result);

            Console.Write("Try again? (yes/no): ");
            again = Console.ReadLine();
        } while (again.ToLower() == "yes");
    }
}
