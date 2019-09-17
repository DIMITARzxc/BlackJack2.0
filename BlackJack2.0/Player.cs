using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    public struct Player
    {
        public int TotalScore;
        public int Win;
        public string Information;

        public int TakeTwoCards(Card[] deck, int usedCard)
        {
            int takeCard = usedCard + 2;
            for (int i = usedCard; i < takeCard; i++)
            {
                TotalScore += deck[i].Score;
                usedCard++;
                Information += $"{deck[i].Name} {deck[i].Suit}";
            }
            Console.WriteLine($"Your Hand: {Information} Score: {TotalScore}");
            return usedCard;
        }

        public int TakePlayerCard(Card[] deck, int usedHand, Dealer dealer, bool turn)
        {
            if (!turn && (dealer.TotalScore >= 21 || TotalScore > dealer.TotalScore))
            {
                return usedHand;
            }
            for (int i = usedHand; i < deck.Length; i++)
            {
                if (TotalScore >= 21 || (dealer.TotalScore < TotalScore && dealer.TotalScore >= 21))
                {
                    return usedHand;
                }
                bool incorrectInput = true;
                while (incorrectInput)
                {
                    Console.WriteLine("Choose some valid options:[S]tand or [H]it");
                    string input = Console.ReadLine();
                    if (input == "h" || input == "H")
                    {
                        TotalScore += deck[i].Score;
                        usedHand++;
                        Information += $"{deck[i].Name} {deck[i].Suit}";
                        Console.WriteLine($"You get: {Information} Score: {TotalScore}");
                        incorrectInput = false;
                    }
                    else if (input == "S" || input == "s")
                    {
                        Console.WriteLine($"Your hand: {Information} Score: {TotalScore}");
                        incorrectInput = false;
                        i = deck.Length;
                    }
                    else { Console.WriteLine("Bad input"); }
                }
            }
            return usedHand;
        }
        public void Clear()
        {
            TotalScore = 0;
            Information = string.Empty;
        }
    }
}
