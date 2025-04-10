using System;

class TennisLoop {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|    Tennis Launcher (Loop)      |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        string ready, empty;
        Console.Write("Is the player ready? (yes/no): ");
        ready = Console.ReadLine();
        Console.Write("Is the basket empty? (yes/no): ");
        empty = Console.ReadLine();

        if (ready == "yes" && empty == "no") {
            Console.WriteLine("Launch the ball!");
        } else {
            Console.WriteLine("Do not launch the ball.");
        }
    }
}
