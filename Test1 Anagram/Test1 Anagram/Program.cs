using System;
namespace Test1_Anagram
{
    internal class Program : Anagram
    {
        public static void Main(string[] args)
        {
         
           
            Console.WriteLine("Well Come to Anagram Program");
            
            string userInput;
            
            do
            {
                Console.WriteLine("Please Enter a Word: ");
                userInput = Console.ReadLine(); 
                
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a valid word. ");
                }
                
            } while (string.IsNullOrEmpty(userInput));

            Console.WriteLine("Reversed Word: " + ReversedWord(userInput));

        }
    }
}