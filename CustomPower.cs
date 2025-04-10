using System;

class CustomPower {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|     Custom Exponentiation      |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int power = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++) {
            result *= baseNum;
        }

        Console.WriteLine($"{baseNum} to the power of {power} = {result}");
    }
}
