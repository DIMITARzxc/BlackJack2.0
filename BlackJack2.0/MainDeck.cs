using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    public struct MainDeck
    {
        public int UserHand;

        public  Card[] CreateDeck()
        {
            Card[] deck = new Card[36];
            for (int cardName = 2, index=0; cardName<=11;cardName++)
            {
                if (cardName != 5)
                {
                    for(int cardSuit = 0; cardSuit <= 3; cardSuit++, index++)
                    {
                        deck[index]= new Card((CardName)cardName,(Suit)cardSuit);
                    }
                }
            }
            return deck;
        }
    }
}
