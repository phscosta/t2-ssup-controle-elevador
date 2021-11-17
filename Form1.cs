using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2_ssup_controle_elevador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected int temp_d = 0;

        protected  static string atual_andar = "0";

        public void deslocamento()
        {
            for (int t = 0; t < 100; t++)
            {
                temp_d = temp_d += t;

                if (temp_d >= 97 || temp_d < 100)
                {
                    status.Text = status.Text + ".";
                }
            }
        }

        /***********************************************************/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        //Botão Térreo - Navegação Interna
        private void button1_Click(object sender, EventArgs e)
        {
            status.Text = "T";

            switch (atual_andar)
            {
                case "0":
                    deslocamento();
                    status.Text = "T";
                    break;
                case "1":
                    deslocamento();
                    status.Text = "T";
                    break;
                case "2":
                    deslocamento();
                    status.Text = "T";
                    break;
                case "3":
                    deslocamento();
                    status.Text = "T";
                    break;
                case "4":
                    deslocamento();
                    status.Text = "T";
                    break;
            }
        }

        //Botão 1 - Navegação Interna
        private void button2_Click(object sender, EventArgs e)
        {
            atual_andar = "0";

            switch (atual_andar)
            {
                case "0":
                    deslocamento();
                    status.Text = "1";
                    break;
                case "1":
                    deslocamento();
                    status.Text = "1";
                    break;
                case "2":
                    deslocamento();
                    status.Text = "1";
                    break;
                case "3":
                    deslocamento();
                    status.Text = "1";
                    break;
                case "4":
                    deslocamento();
                    status.Text = "1";
                    break;
            }
        }

        //Botão 2 - Navegação Interna
        private void button3_Click(object sender, EventArgs e)
        {
            status.Text = "2";

            switch (atual_andar)
            {
                case "0":
                    deslocamento();
                    status.Text = "2";
                    break;
                case "1":
                    deslocamento();
                    status.Text = "2";
                    break;
                case "2":
                    deslocamento();
                    status.Text = "2";
                    break;
                case "3":
                    deslocamento();
                    status.Text = "2";
                    break;
                case "4":
                    deslocamento();
                    status.Text = "2";
                    break;
            }
        }

        //Botão 3 - Navegação Interna
        private void button4_Click(object sender, EventArgs e)
        {
            status.Text = "3";

            switch (atual_andar)
            {
                case "0":
                    deslocamento();
                    status.Text = "3";
                    break;
                case "1":
                    deslocamento();
                    status.Text = "3";
                    break;
                case "2":
                    deslocamento();
                    status.Text = "3";
                    break;
                case "3":
                    deslocamento();
                    status.Text = "3";
                    break;
                case "4":
                    deslocamento();
                    status.Text = "3";
                    break;
            }
        }

        //Botão 4 - Navegação Interna
        private void button5_Click(object sender, EventArgs e)
        {
            status.Text = "4";

            switch (atual_andar)
            {
                case "0":
                    deslocamento();
                    status.Text = "4";
                    break;
                case "1":
                    deslocamento();
                    status.Text = "4";
                    break;
                case "2":
                    deslocamento();
                    status.Text = "4";
                    break;
                case "3":
                    deslocamento();
                    status.Text = "4";
                    break;
                case "4":
                    deslocamento();
                    status.Text = "4";
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
