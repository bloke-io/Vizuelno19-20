using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Prkt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            blood.Visible = false;
        }
        Random r = new Random();
        int Score = 0;
        int Total_Shots = 0;
        int Miss_Shots = 0;

        void Shot()
        {

            pictureBox1.Visible = false;
            blood.Location = pictureBox1.Location;
            blood.Visible = true;
            pictureBox1.Visible = true;

            if (Score < 10)
            {
                Score++;
                lblScore.Text = "Score= " + Score;
                lblLevel.Text = "Level = 1";
            }
            if (Score >= 10)
            {
                timer1.Interval = 1000;
                Score++;
                lblScore.Text = "Score= " + Score;
                lblLevel.Text = "Level = 2";
            }
            if (Score >= 20)
            {
                timer1.Interval = 750;
                Score++;
                lblScore.Text = "Score= " + Score;
                lblLevel.Text = "Level = 3";
            }
            if(Score >= 25)
            {
                timer1.Interval = 500;
                Score++;
                lblScore.Text = "Score= " + Score;
                lblLevel.Text = "Level = 4";
            }
            Total_Shots++;
            lblTotalShot.Text = "Total shots= " + Total_Shots;
        }
        void Miss_Shot()
        {
            Miss_Shots++;
            lblMissShot.Text = "Miss shot= " + Miss_Shots;
            Total_Shots++;
            lblTotalShot.Text = "Total shots= " + Total_Shots;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 1000);
            y = r.Next(350, 630);
            pictureBox1.Location = new Point(x,y);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Shot();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Miss_Shot();
        }
    }
}
