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

        public Card[] CreateDeck()
        {
            Card[] deck = new Card[36];
            for (int cardName = 2, index = 0; cardName <= 11; cardName++)
            {
                if (cardName != 5)
                {
                    for (int cardSuit = 0; cardSuit <= 3; cardSuit++, index++)
                    {
                        deck[index] = new Card((CardName)cardName, (Suit)cardSuit);
                    }
                }
            }
            return deck;
        }
        public Card[] ShuffleDeck(Card[] deck)
        {
            Random rnd = new Random();
            for (int i = deck.Length - 1; i >= 1; i--)
            {
                int a = rnd.Next(i);
                Card temp = deck[a];
                deck[a] = deck[i];
                deck[i] = temp;
            }
            UserHand = 0;
            return deck;
        }
    }
}
