#define Positivo_
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form//TODO directivas y boton insert coin
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int dinero = 50;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dinero >= 2)
            {
                Random ludopatia = new Random();
                // Dinero
                dinero = dinero - 2;
                label4.Text = "Monocoins: " + dinero.ToString();
                //Casillas
                int casilla = ludopatia.Next(1, 8);
                label1.Text = casilla.ToString();
                casilla = ludopatia.Next(1, 8);
                label2.Text = casilla.ToString();
                casilla = ludopatia.Next(1, 8);
                label3.Text = casilla.ToString();
                if (label1.Text == label2.Text && label1.Text == label3.Text)
                {
                    label5.Text = "GRAN PREMIO";
                    dinero = dinero + 20;
                }
                else
                {
                    if (label1.Text == label2.Text || label1.Text == label3.Text || label2.Text == label3.Text)
                    {
                        label5.Text = "PREMIO";
#if Positivo
                        dinero = dinero + 5;
#else
                        dinero = dinero - 5;
#endif
                    }
                    else
                    {
                        label5.Text = "SIN PREMIO";
                    }
                }
                label4.Text = "Monocoins: " + dinero.ToString();
            }
            else
            {
                label5.Text = "No tienes más monedas";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dinero = dinero + 10;
            label6.Text = "Monocoins insertadas";
            label4.Text = "Monocoins: " + dinero.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
