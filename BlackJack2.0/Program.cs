using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    class Program
    {

        static int money;
        static int sCoins;
        static void Main(string[] args)
        {
            Card[] deck = MainDeck.CreateDeck();
            Dealer dealer = new Dealer();
            Player player = new Player();

            /*Console.Title = "© Blackjack Game by Nedilko";
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("♥♦♣♠SILENT CASINO♠♣♦♥");
             Console.ResetColor();
             Console.WriteLine("$Enter your deposit$");

             money = Convert.ToInt32(Console.ReadLine());
             sCoins = money * 2;
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine($"Your money {money}$ convert to silent coins x2\n Current silent coins:{sCoins}¤");
             Console.ResetColor();
             Console.ReadLine();*/
            do
            {
                MainDeck.ShuffleDeck(deck);
                player.Clear();
                dealer.Clear();
                bool incorrectInput = true;
                Console.WriteLine("Choose who takes two cards first[P]layer/[D]ealer]");
                string input = Console.ReadLine();
                while (incorrectInput)
                {
                    switch (input)
                    {
                        case "P || p":
                            incorrectInput = false;
                            break;
                        case "D || d":
                            incorrectInput = false;
                            break;
                        default:
                            Console.WriteLine("Bad input");
                            Console.WriteLine("Choose who takes two cards first[P]layer/[D]ealer]");
                            input = Console.ReadLine();
                            break;
                    }
                }
                switch (input)
                {
                    case "p":
                        MainDeck.UserHand = player.TakeTwoCards(deck, MainDeck.UserHand);
                        if(VictoryAttachment.FirstTurn(ref player))
                        {
                            break;
                        }
                        MainDeck.UserHand = dealer.TakeTwoCards(deck, MainDeck.UserHand);
                        MainDeck.
                }

            } while (true);
        }
    }
}
