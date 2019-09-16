using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    public struct Dealer
    {
        public int TotalScore;
        public string Information;
        public int Victory;

        public int TakeTwoCards(Card[] deck, int usedHand)
        {
            int takenCards = usedHand + 2;
            for (int i = usedHand; i < takenCards; i++)
            {
                TotalScore += deck[i].Score;
                usedHand++;
                Information += $"{deck[i].Name} {deck[i].Suit}";

            }
            Console.WriteLine($"Dealer hand:{Information} Score{TotalScore}");
            return usedHand;
        }

    }
}
