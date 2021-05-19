using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alapmuveletek
{
    
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public bool sok = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Osszeadas_Click(object sender, EventArgs e)
        {
            string jel = "+";
            feladatotGenerál(jel);
        }

        private void feladatotGenerál(string jel)
        {

            int szám1;
            int szám2;
            do
            {
                szám1 = kérSzámot();
                szám2 = kérSzámot();
                leelenőrizSzámok(szám1, szám2, jel); 
            } while (sok);

            lblFeladatKiir.Text = $"{szám1}{jel}{szám2}";
        }

        private bool leelenőrizSzámok(int szám1, int szám2, string jel)
        {
            
            switch (jel)
            {

                case "+":
                    sok = (szám1 + szám2 > 100) ? true : false;
                    break;
                case "-":
                    sok = (szám1 - szám2 < 0) ? true : false;
                    break;
                case "*":
                    sok = (szám1 * szám2 > 100) ? true : false;
                    break;
                case "/":
                    sok = (szám2 == 0) || (szám1 % szám2 != 0) ? true : false;
                    break;
            }
            return sok;
        }

        public int kérSzámot()
        {
            return rnd.Next(0, 101);
        }

        private void Szorzas_Click(object sender, EventArgs e)
        {
            string jel = "*";
            feladatotGenerál(jel);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Mennyi az eredménye? 5+3=
        }

        private void UjFeladat_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Statisztika gruopbox
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //kivonás statisztika
        }

        private void Osztas_Click(object sender, EventArgs e)
        {
            string jel = "/";
            feladatotGenerál(jel);
        }

        private void Kivonas_Click(object sender, EventArgs e)
        {
            string jel = "-";
            feladatotGenerál(jel);
        }

        private void Megoldas_Click(object sender, EventArgs e)
        {

        }

        private void EredmenyBekuld_Click(object sender, EventArgs e)
        {

        }

        private void BeirtEredmeny_TextChanged(object sender, EventArgs e)
        {
            // Írd be az eredményt helye
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //groupbox Feladat
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            //Szorzás statisztika
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Osztás statisztika
        }
    }
}
