using System;

namespace numberguesser3times
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int correctNumber = random.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Guess a number between 1-10.");

                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (correctNumber == userNumber)

                {
                    Console.WriteLine("Oled võitnud");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    if (i < 3)
                    {
                        Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud. ");
                    }
                    else
                    {
                        Console.WriteLine("Arvuti on võitnud");
                    }
                }
            }
            Console.WriteLine("Kena päeva");
        }
    }
}
