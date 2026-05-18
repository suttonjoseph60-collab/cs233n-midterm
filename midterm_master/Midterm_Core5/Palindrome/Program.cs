
using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Main pseudocode:
             * Console.WriteLine("Enter a word or phrase to check if it is a palindrome.");
             * get string input = Console.ReadLine();
             * print boolean result of IsPalindrome(input) as a string statement.
             * WriteLine($"Is {input} a palindrome? " + IsPalindrome(input));
             */

            Console.WriteLine("Enter a word or phrase to check if it is a palindrome.");
            string input = Console.ReadLine();
            Console.WriteLine($"Is {input} a palindrome? " + IsPalindrome(input));
        }

        /*
         IsPalindrome pseudocode:
         static bool IsPalindrome(string input)
            {
                create stack and queue data structures
                for each character in input that isnt a punctuation, whitespace
                    add character to stack and queue
                for each character in input
                    if character from top of stack != character from front of queue
                        return false
                return true
            }
         */
        static bool IsPalindrome(string input)
        {
            if (input != null)
            {
                Stack<char> stack = new Stack<char>();
                Queue<char> queue = new Queue<char>();
                foreach (char c in input)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        char lowerChar = char.ToLower(c);
                        stack.Push(lowerChar);
                        queue.Enqueue(lowerChar);
                    }
                }
                while (stack.Count > 0 && queue.Count > 0)
                {
                    if (stack.Pop() != queue.Dequeue())
                    {
                        return false;
                    }
                }
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
