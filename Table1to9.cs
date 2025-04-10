using System;

class Table1to9 {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|   Multiplication Tables 1-9    |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        for (int i = 1; i <= 9; i++) {
            Console.WriteLine($"\nTable of {i}");
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}
