using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    class Betplace
    {
        public int Amount;
        public int Racer;
        public Cars bet;


        public int Winnerget(int winracer)
        {
            if (Racer == winracer) return Amount;
            return -Amount;
        }
        public string PAcedbet()
        {
            if(Amount > 0) return bet.name + " bet " + Amount + " dollars on racer #" + Racer;
            return bet.name + " has not placed a bet";
        }
        public Betplace(Cars bets)
        {
            bet = bets;
        }
       
    }
}
