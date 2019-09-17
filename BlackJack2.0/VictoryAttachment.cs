using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack2._0
{
    public struct VictoryAttachment
    {
        public  static void Winner(ref Dealer dealer,ref Player player)
        {
            if(player.TotalScore<=21 && dealer.TotalScore > 21)
            {
                player.Win++;
                Console.WriteLine("Congratulations, you win");
            }
            if(player.TotalScore>dealer.TotalScore && player.TotalScore <= 21)
            {
                player.Win++;
                Console.WriteLine("Congratulations, you win");
            }
            if(player.TotalScore>21 && dealer.TotalScore > 21)
            {
                if (player.TotalScore<dealer.TotalScore)
                {
                    player.Win++;
                    Console.WriteLine("Congratulations, you win");
                }
                else if (player.TotalScore>dealer.TotalScore)
                {
                    dealer.Win++;
                    Console.WriteLine("Ooops, you lose");
                }
            }
            if (dealer.TotalScore<=21 && player.TotalScore>21)
            {
                dealer.Win++;
                Console.WriteLine("Ooops, you lose");
            }
            if (dealer.TotalScore>player.TotalScore && dealer.TotalScore<=21)
            {
                dealer.Win++;
                Console.WriteLine("Ooops, you lose");
            }
        }
        public static bool FirstTurn(ref Player player)
        {
            if(player.TotalScore==21)
            {
                player.Win++;
                Console.WriteLine("Congratulations, you win");
                return true;
            }
            return false;
        }
        public static bool FirstTurn(ref Dealer dealer)
        {
            if(dealer.TotalScore==21)
            {
                dealer.Win++;
                Console.WriteLine("Ooops, you lose");
                return true;
            }
            return false;
        }
    }
}
