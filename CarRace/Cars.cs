using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    class Cars
    {
        public int money;
        public RadioButton Radiobtn;
        public Label labellb;
        public string name;
        public Betplace amtBet;
        

      


        public void bet_remove()
        {
            amtBet.Amount = 0;
        }
        public Cars(string Rcname, int Rcmoney, RadioButton Rcbtn, Label RClb)
        {
            name = Rcname;
            money = Rcmoney;
            labellb = RClb;
            amtBet = new Betplace(this);
            Radiobtn = Rcbtn;
            
        }
        public bool car_Bet(int betmoney, int winbet)
        {
            amtBet.Amount = betmoney;
            amtBet.Racer = winbet;
            if (money >= betmoney) return true;
            return false;
        }
        public void First(int winner)
        {
            money += amtBet.Winnerget(winner);
            bet_remove();
            carlb();
        }
        public void carlb()
        {
            labellb.Text = amtBet.PAcedbet();
            Radiobtn.Text = name + " has " + money + " $";
        }
       
    }
}
