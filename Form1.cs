using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lekcja10i11
{
    public partial class Form1 : Form
    {
        int min, max, x;
        public Form1()
        {
            InitializeComponent();
            label2.Text = ("");
            label3.Text = ("");
            label4.Text = ("");
            label5.Text = ("");
            label6.Text = ("");
            label7.Text = ("");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = ("");
            label3.Text = ("");
            label4.Text = ("");
            label5.Text = ("");
            label6.Text = ("");
            label7.Text = ("");

            string y;
            int k = 1;
            y = Interaction.InputBox("Podaj liczbę dodatnią", "Wczytywanie danych");
            if (y != "")
            {
                x = Convert.ToInt32(y);
                max = x;
                min = x;
                label2.Text = ("Wczytałeś liczb: ");
                label5.Text = Convert.ToString(k);
                label3.Text = ("Największa z wczytanych liczb to: ");
                label6.Text = Convert.ToString(max);
                label4.Text = ("Najmniejsza z wczytanych liczb to: ");
                label7.Text = Convert.ToString(min);
            }

            while (y != "") 
            {
                k = k + 1;
                y = (Interaction.InputBox("Podaj liczbę dodatnią", "Wczytywanie danych"));
                if (y != "")
                    x = Convert.ToInt32(y);
                if (max < x) max = x;
                if (min > x) min = x;
                label2.Text = ("Wczytałeś liczb: ");
                label5.Text = Convert.ToString(k);
                label3.Text = ("Największa z wczytanych liczb to: ");
                label6.Text = Convert.ToString(max);
                label4.Text = ("Najmniejsza z wczytanych liczb to: ");
                label7.Text = Convert.ToString(min);
            }
            label5.Text = Convert.ToString(k-1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ("");
            label3.Text = ("");
            label4.Text = ("");
            label5.Text = ("");
            label6.Text = ("");
            label7.Text = ("");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
