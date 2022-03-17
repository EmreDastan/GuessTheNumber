using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{

    /* Creator credits :
     * Yunus Emre Daştan
     */

    public partial class Form1 : Form
    {
        int chosenone, randomkey;
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            Randomizer();
        }
        private void Randomizer()
        {
            randomkey = random.Next(9);
            chosenone = numbers[randomkey];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 1)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 2)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 3)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 4)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 5)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 6)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 7)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 8)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            title.ForeColor = System.Drawing.Color.OldLace;
            if (chosenone == 9)
            {
                title.ForeColor = System.Drawing.Color.Red;
                title.Text = "YOU WON!";
                Randomizer();
            }
            else
            {
                title.Text = "YOU LOST!";
            }
        }
    }
}
