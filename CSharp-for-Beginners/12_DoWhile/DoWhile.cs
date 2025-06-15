using System;

class Program {
    static void Main() {
        int number;
        do {
            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number != 0);
    }
}