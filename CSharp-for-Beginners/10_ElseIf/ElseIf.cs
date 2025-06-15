using System;

class Program {
    static void Main() {
        int score = 75;
        if (score >= 90)
            Console.WriteLine("Excellent");
        else if (score >= 70)
            Console.WriteLine("Good");
        else
            Console.WriteLine("Needs Improvement");
    }
}