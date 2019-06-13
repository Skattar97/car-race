using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public class betcars
    {
        public PictureBox PicBox;
        public int line;
        public int track;
        public int point;
        public Random ran;


        public void go()
        {
            this.PicBox.Left = 0;
            this.point = 0;
        }
        public bool Raceing()
        {
            point = ran.Next(5);
            PicBox.Left += line + point;

            if (PicBox.Left >= track)
                return true;

            return false;
        }
        

       
    }
}
