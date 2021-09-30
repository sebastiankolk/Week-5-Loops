using System;

namespace QuackQuackQuack
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 5; i > 0; i--)
                if (i > 2)
                {
                    Console.WriteLine($"{i} little ducks, went out one day, Over the hill and far away, The mother duck said: Quack, quack quack quack. But only {i - 1} little ducks came back.");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i} little ducks, went out one day, Over the hill and far away, The mother duck said: Quack, quack quack quack. But only {i - 1} little duck came back.");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{i} little duck, went out one day, Over the hill and far away, The mother duck said: Quack, quack quack quack. But none of the {i+4} little ducks came back.");
                }
        }
    }
}
