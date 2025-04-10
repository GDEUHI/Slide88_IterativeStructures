using System;

class NumberGuess {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|         Number Guessing        |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        int secret = 7;
        int guess;
        do {
            Console.Write("Guess the number (1–10): ");
            guess = int.Parse(Console.ReadLine());
        } while (guess != secret);

        Console.WriteLine("Correct!");
    }
}
