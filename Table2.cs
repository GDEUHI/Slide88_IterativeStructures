using System;

class Table2 {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|     Multiplication Table 2     |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"2 x {i} = {2 * i}");
        }
    }
}
