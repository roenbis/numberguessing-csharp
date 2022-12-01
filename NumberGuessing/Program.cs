using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess A Number In-between 0 And 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine("To High!");
                } 
                else if (i < winNum)
                {
                    Console.WriteLine("To Low!");
                } 
                else if (i == winNum)
                {
                    Console.WriteLine("You Win!");
                    win = true;
                }
                
                Console.WriteLine();
            } while (win == false);
            
            Console.Write("Press any button to finish...");
            Console.ReadKey(true);
        }
    }
}