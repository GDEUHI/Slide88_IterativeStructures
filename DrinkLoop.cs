using System;

class DrinkLoop {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|       Drink Dispenser Loop     |");
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine();

        string[] drinks = { "Water", "Tea", "Cola" };
        int[] stock = { 2, 1, 0 };
        int choice;

        do {
            Console.WriteLine("Choose a drink:");
            for (int i = 0; i < drinks.Length; i++) {
                Console.WriteLine($"{i + 1}. {drinks[i]} (Stock: {stock[i]})");
            }
            Console.WriteLine("0. Exit");
            choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= drinks.Length) {
                if (stock[choice - 1] > 0) {
                    Console.WriteLine($"You chose: {drinks[choice - 1]}");
                    stock[choice - 1]--;
                } else {
                    Console.WriteLine("Out of stock!");
                }
            }
        } while (choice != 0);
    }
}
