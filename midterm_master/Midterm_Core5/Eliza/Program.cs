using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me what you are feeling today.");
            string clientStatement = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(clientStatement));
            string clientStatement2 = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(clientStatement2));
            string clientStatement3 = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(clientStatement3));
        }

        static string CreateElizaResponse(string clientStatement)
        {
            if (clientStatement.Contains("my"))
            {
                int myIndex = clientStatement.IndexOf("my");
                string noun = clientStatement.Substring(myIndex + 3);
                return "Tell me more about your " + noun;
            }
            else if (clientStatement.Contains("love") || clientStatement.Contains("hate"))
            {
                return "You have strong feelings about that!";
            }
            else
            {
                string[] responses = { "Please go on.", "Tell me more", "Continue" };
                Random rand = new Random();
                int index = rand.Next(responses.Length);
                return responses[index];
            }

            /* pseudocode:
            
            Console.WriteLine("Tell me what you are feeling today.");
            string clientStatement = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(clientStatement));
            Console.WriteLine("response.");

            static string CreateElizaResponse(string clientStatement)
            {
                if statement (contains "my")
                    respoond with "tell me more about your" brother;
                if statement (contains "love" || "hate")
                    respond with "you have strong feelings about that!"
                else
                     respond with "Please go on.", "Tell me more" or "Continue"
                {
                    
                }
            }
            */
        }
    }
}
