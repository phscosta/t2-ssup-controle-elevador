using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        protected  static string atual_andar = "0";
        
        protected static int control = 0;

        public void deslocamento()
        {
            Thread.Sleep(5000);
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
            atual_andar = "1";

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
            status.Text = "X";
            status.BackColor = Color.Red;

            if (control == 1)
            {
                status.BackColor = Color.Black;
                status.Text = "";
                control = 0;
            }

            control++;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        //Botão Up - Térreo - Navegação Externa
        private void upT_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "T";
        }

        //Botão Up - 1º Andar - Navegação Externa
        private void up1_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "1";
        }

        //Botão Down - 1º Andar - Navegação Externa
        private void button8_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "1";
        }

        //Botão Up - 2º Andar - Navegação Externa
        private void up2_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "2";
        }

        //Botão Down - 2º Andar - Navegação Externa
        private void d2_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "2";
        }

        //Botão Up - 3º Andar - Navegação Externa
        private void up3_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "3";
        }

        //Botão Down - 3º Andar - Navegação Externa
        private void d3_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "3";
        }

        //Botão Down - 4º Andar - Navegação Externa
        private void d4_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "4";
        }
    }
}
