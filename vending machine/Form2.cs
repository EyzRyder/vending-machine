using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vending_machine
{
    public partial class Form2 : Form
    {
        double valor = 0;
        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Gold;
            progressBar1.BackColor = Color.Black;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        private void showText_Click(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            int prov = Convert.ToInt32(textBox1.Text);
            if (prov == 2 || prov == 5 || prov == 10 || prov == 20 || prov == 50 || prov == 100 || prov == 200)
            {
                valor = valor + prov;
                if (valor >= 1)
                {
                    button11.Enabled = true;
                }
                if (valor >= 4.99)
                {
                    button12.Enabled = true;
                }
                if (valor >= 1.50)
                {
                    button13.Enabled = true;
                }
                if (valor >= 1.50)
                {
                    button21.Enabled = true;
                }
                if (valor >= 4.50)
                {
                    button22.Enabled = true;
                }
                if (valor >= 3.99)
                {
                    button23.Enabled = true;
                }
                if (valor >= 0.50)
                {
                    button31.Enabled = true;
                }
                if (valor >= 2)
                {
                    button32.Enabled = true;
                }
                if (valor >= 2)
                {
                    button33.Enabled = true;
                }
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Escolha o Produto");
            }
            else{
                showText.Text = ("Valor não aceito");
            }
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = true;
            showText.Text = "insira o valor";
            textBox1.Text = "";
            valor = 0;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor = valor - 1.50;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor = valor - 4.99;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            valor = valor - 1.50;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            valor = valor - 4.50;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            valor = valor - 3.99;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            valor = valor - 0.5;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            valor = valor - 2;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            valor = valor - 2;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor = valor - 1;
            if (valor > 0)
            {
                textBox1.Text = (Convert.ToString(valor));
                showText.Text = ("Retire Seu Troco");
            }
            else
            {
                showText.Text = "Obrigado!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
