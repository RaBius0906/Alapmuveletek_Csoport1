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
            int szám1 = kérSzámot();
            int szám2 = kérSzámot();
            lblFeladatKiir.Text = $"{szám1}{jel}{szám2}";
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
