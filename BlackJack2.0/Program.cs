﻿using System;
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

        }
    }
}
