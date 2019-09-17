using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    class Program
    {

        static void Main(string[] args)
        {
            Card[] deck = MainDeck.CreateDeck();
            Dealer dealer = new Dealer();
            Player player = new Player();

            Console.Title = "© Blackjack Game by Nedilko";
            
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
                        case "P":
                            incorrectInput = false;
                            break;
                        case "D":
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
                    case "P":
                        MainDeck.UserHand = player.TakeTwoCards(deck, MainDeck.UserHand);

                        if (VictoryAttachment.FirstTurn(ref player))
                        {
                            break;
                        }

                        MainDeck.UserHand = dealer.TakeTwoCards(deck, MainDeck.UserHand);
                        MainDeck.UserHand = player.TakePlayerCard(deck, MainDeck.UserHand, dealer, true);
                        MainDeck.UserHand = dealer.TakeCard(deck, MainDeck.UserHand, player);
                       VictoryAttachment.Winner(ref dealer,ref player);
                        break;
                    case "D":
                        MainDeck.UserHand = dealer.TakeTwoCards(deck, MainDeck.UserHand);

                        if (VictoryAttachment.FirstTurn(ref dealer))
                        {
                            break;
                        }

                        MainDeck.UserHand = player.TakeTwoCards(deck, MainDeck.UserHand);
                        MainDeck.UserHand = dealer.TakeCard(deck, MainDeck.UserHand, player);
                        MainDeck.UserHand = player.TakePlayerCard(deck, MainDeck.UserHand, dealer, false);
                        VictoryAttachment.Winner(ref dealer, ref player);
                        break;
                }
            }
            while (ContinueGame(player, dealer));
            Console.ReadLine();
        }

        private static bool ContinueGame(Player player, Dealer dealer)
        {
            do
            {
                Console.WriteLine("Start a new game? [Y]es/[N]o");
                string input = Console.ReadLine();

                if (input == "y"|| input=="Y")
                {
                    Console.Clear();
                    return true;
                }
                else if (input == "n" || input == "N")
                {
                    Console.WriteLine($"Total player wins: {player.Win}");
                    Console.WriteLine($"Total computer wins: {dealer.Win}");
                    return false;
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            } while (true);
        }
    }
}
