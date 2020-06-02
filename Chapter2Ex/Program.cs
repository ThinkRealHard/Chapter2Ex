using System;

namespace Chapter2Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Now, how big did you want that rectangle? Length: ");
            string input2 = Console.ReadLine();
            float length;
            length = float.Parse(input2);
            Console.WriteLine("How about that width?");
            string input3 = Console.ReadLine();
            float width;
            width = float.Parse(input3);
            Console.WriteLine("The area of your rectangle is: " + width * length);
            Console.WriteLine("Let's check your MPG. Miles driven on the current tank? Input now: ");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How much gas have you consumed? ");
            int gas = int.Parse(Console.ReadLine());
            Console.WriteLine("Your MPG is " + miles / gas);
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            System.Console.WriteLine(alice);
            System.Console.WriteLine("Now, what we need from you, is to know which word you wish to search for:");
            string input = Console.ReadLine();
            System.Console.WriteLine(input + " appears at index: " + alice.IndexOf(input));
        }
    }
}
