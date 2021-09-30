using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guess = 0;

            Console.WriteLine("Guess a number between 1-10.");

            while (guess != correctNumber)
            {


                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please use an actual number");

                    continue;
                }
                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    Console.WriteLine("Wrong number, please try again");
                }
            }
            Console.WriteLine("Oled võitnud");
            /*            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            bool loopactive = true;

            

            while (loopactive)
            {
                Console.WriteLine("Guess a number between 1-10.");

                string input = Console.ReadLine();

                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (correctNumber == userNumber)

                {
                    Console.WriteLine("Oled võitnud");
                      loopactive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
            }
            Console.WriteLine("Kena päeva.");*/
        }
    }
}
