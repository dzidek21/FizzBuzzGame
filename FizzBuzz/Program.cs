using System.ComponentModel.DataAnnotations;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czesć! Podaj liczbę");

            var userNumber = UserNumber();

            GameLogic gameLogic = new GameLogic();

            Console.WriteLine(gameLogic.StartGame(userNumber));
        }
        private static int UserNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podano zły znak.\nPodaj liczbę");
                    continue;
                }
                else
                {
                    return userNumber;
                }
            }
        }
    }
}