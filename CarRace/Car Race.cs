using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public partial class maingame : Form
    {
        Cars[] Cars = new Cars[3];
        betcars[] betperson = new betcars[4];
        Random Rand = new Random();
        
    public maingame()
        {
            InitializeComponent();
            Track();
        }
        public void FnishRace(int winnercar)
        {
            timer1.Stop();
            timer1.Dispose();
            MessageBox.Show("The Winner is " + winnercar);
            foreach (var guy in Cars)
            {
                guy.First(winnercar);
            }
            foreach (var bike in betperson)
            {
                bike.go();
            }
            Gobtn.Enabled = true;
        }
        public void Track()
        {
            betperson[0] = new betcars()
            {
                PicBox = car1,
                line = racePB.Left,
                track = racePB.Width - car1.Width,
                ran = Rand
            };
            betperson[1] = new betcars()
            {
                PicBox = car2,
                line = racePB.Left,
                track = racePB.Width - car2.Width,
                ran = Rand
            };
            betperson[2] = new betcars()
            {
                PicBox = car3,
                line = racePB.Left,
                track = racePB.Width - car3.Width,
                ran = Rand
            };
            betperson[3] = new betcars()
            {
                PicBox = car4,
                line = racePB.Left,
                track = racePB.Width - car4.Width,
                ran = Rand
            };


            Cars[0] = new Cars("Jack", 50, rbJack, JackLabel);
            Cars[1] = new Cars("Sam", 50, rbSam, SamLabel);
            Cars[2] = new Cars("Jess", 50, rbJess, JessLabel);

            foreach (var racer in Cars)
            {
                racer.car_Bet(0, 0);
                racer.carlb();
            }
            minimumBetLabel.Text = "Minimum bet is " + 1 + " bucks";
            betplaceud.Minimum = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < betperson.Length; i++)
            {
                if (betperson[i].Raceing())
                {
                    FnishRace(i);
                    break;
                }
            }

        }
        void Raceing()
        {
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Racerbtn_Click(object sender, EventArgs e)
        {
            Raceing();
            Gobtn.Enabled = false;
        }

        private void beterbtn_Click(object sender, EventArgs e)
        {
            if (rbJack.Checked)
            {
                Cars[0].car_Bet((int)betplaceud.Value, (int)Racerud.Value);
                Cars[0].carlb();
            }
            if (rbSam.Checked)
            {
                Cars[1].car_Bet((int)betplaceud.Value, (int)Racerud.Value);
                Cars[1].carlb();
            }
            if (rbJess.Checked)
            {
                Cars[2].car_Bet((int)betplaceud.Value, (int)Racerud.Value);
                Cars[2].carlb();
            }
        }

        private void rbSam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
