using System;

class Program {
    static void Main() {
        int age = 20;
        bool hasID = true;

        if (age >= 18) {
            if (hasID) {
                Console.WriteLine("You may enter.");
            } else {
                Console.WriteLine("Please show ID.");
            }
        } else {
            Console.WriteLine("You are too young.");
        }
    }
}