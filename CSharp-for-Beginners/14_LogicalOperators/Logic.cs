using System;

class Program {
    static void Main() {
        bool hasKey = true;
        bool knowsPassword = false;

        if (hasKey && knowsPassword) {
            Console.WriteLine("Access granted.");
        } else {
            Console.WriteLine("Access denied.");
        }
    }
}