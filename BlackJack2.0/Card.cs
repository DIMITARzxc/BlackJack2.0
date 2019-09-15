using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
     public struct Card
    {
        public int Score;
        public CardName Name;
        public Suit Suit;
        public Card(CardName cardName, Suit suit)
        {
            Suit = suit;
            Name = cardName;
            Score = (int)cardName;
        }
    }
}
