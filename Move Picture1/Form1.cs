using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_down_Click(object sender, EventArgs e)
        
        {
            PB.Location = new Point(PB.Location.X, PB.Location.Y +10);
        }

        private void Btn_left_Click(object sender, EventArgs e)
    {
            if (PB.Location.X > 0)
            {
                PB.Location = new Point(PB.Location.X - 10, PB.Location.Y);
            }
    }
        

        private void Btn_up_Click(object sender, EventArgs e)
        {
            PB.Location = new Point(PB.Location.X, PB.Location.Y -10);
        }

        private void Btn_right_Click(object sender, EventArgs e)
    {
            if (PB.Location.X + 10 < ClientRectangle.Width)
            { 
                 PB.Location = new Point(PB.Location.X +10, PB.Location.Y);
            }      
    }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_upleft_Click(object sender, EventArgs e)
        {
            PB.Location = new Point(PB.Location.X - 10, PB.Location.Y - 10);
        }

        private void Btn_upright_Click(object sender, EventArgs e)
        {
            PB.Location = new Point(PB.Location.X + 10, PB.Location.Y - 10);
        }

        private void Btn_downleft_Click(object sender, EventArgs e)
        {
            PB.Location = new Point(PB.Location.X - 10, PB.Location.Y + 10);
        }

        private void Btn_downright_Click(object sender, EventArgs e)
        {
            PB.Location = new Point(PB.Location.X + 10, PB.Location.Y + 10);
        }
    }
}
