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
        public int Win;
        public string Information;

        public int TakeTwoCards(Card[] deck, int usedCard) 
        {
            int takeCard = usedCard + 2;
            for (int i = usedCard; i < takeCard; i++)
            {
                TotalScore += deck[i].Score;
                usedCard++;
                Information += $"{deck[i].Name}{deck[i].Suit}";
            }
            Console.WriteLine($"Your Hand:{Information} Points:{TotalScore}");
            return usedCard;
        }
        
        public int TakeDealerCard(Card[] deck, int usedHand, bool Turn)
        {
            if(!Turn && (d))
            return usedHand;
        }
    }
}
