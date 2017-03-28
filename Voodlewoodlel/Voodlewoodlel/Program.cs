using System;

namespace Voodlewoodlel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your friend's name: ");
            string name = Console.ReadLine();

            foreach(char c in name)
            {
                // if vowel is lower letter
                if (c.Equals('a') ||
                    c.Equals('e') ||
                    c.Equals('i') ||
                    c.Equals('o') ||
                    c.Equals('u'))
                {
                    Console.Write("oodle");
                }
                // if vowel is upper letter
                else if (c.Equals('A') ||
                        c.Equals('E') ||
                        c.Equals('I') ||
                        c.Equals('O') ||
                        c.Equals('U'))
                {
                    Console.Write("Oodle");
                }
                // if there is no vowel
                else
                {
                    Console.Write(c);
                }
            }

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}