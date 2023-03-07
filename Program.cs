using System;

namespace CountingCharacters
{
    public class Program
    {
        // Get the idea put into the console
        static void Main(string[] args)
        {
            string wordToCount;
            {
                Console.WriteLine("Please enter your word to count:");
                string input = Console.ReadLine();
                wordToCount = input;
            }
            
            // Google research for how to remove non alphabetical characters
            List<char> charsToRemove = new List<char>() { '@', '_', ',', ' ', ' ', '#'};
            wordToCount = wordToCount.Filter(charsToRemove);
            int result = wordToCount.Length;
            Console.WriteLine("The length of your string is "  +result);
        }
    } 
}