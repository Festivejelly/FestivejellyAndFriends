using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            string description;

            if (Bettor.MyBet.Amount > 0)
            {
                description = Bettor.Name + " bets " + Bettor.MyBet.Amount + " on dog #" + Bettor.MyBet.Dog;
            }
            else
            {
                description = Bettor.Name + " hasnt placed any bets";
            }

            return description;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -1 * Amount;
            }
        }
    }
}
