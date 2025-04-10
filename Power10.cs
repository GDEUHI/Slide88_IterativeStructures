using System;

class Power10 {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|        Power of 10 Tool        |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        Console.Write("Enter a number: ");
        int baseNum = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= 10; i++) {
            result *= baseNum;
        }

        Console.WriteLine($"{baseNum} to the power of 10 = {result}");
    }
}
