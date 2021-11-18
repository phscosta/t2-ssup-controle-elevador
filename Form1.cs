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

            Thread.Sleep(1000);

            status.Text = "T";
        }

        protected  static string atual_andar = "T";
        
        protected static int control = 0;

        protected static int operacao = 0;

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
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
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
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
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
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
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
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
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
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
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

        //Cotrole de Emergência - EM
        private void button6_Click(object sender, EventArgs e)
        {
            switch (control)
            {
                case 0:
                    status.Text = "X";
                    status.BackColor = Color.Red;
                    break;
                case 1:
                    status.BackColor = Color.Black;
                    status.Text = "T";
                    break;
            }
            
            if (control < 1)
            {
                control++;
            }
            else if (control == 1)
            {
                control--;
            }
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

        //Modo de Operação - MANUAL
        private void checkBox_ma_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 0;
        }

        //Modo de Operação - AUTOMÁTICO
        private void checkBox_at_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;

            Random move_andar = new Random();

            while (operacao == 1)
            {
                int andar = move_andar.Next(0, 4);

                string tela_status = andar.ToString();

                switch (andar)
                {
                    case 0:
                        deslocamento();
                        status.Text = tela_status;
                        break;
                    case 1:
                        deslocamento();
                        status.Text = tela_status;
                        break;
                    case 2:
                        deslocamento();
                        status.Text = tela_status;
                        break;
                    case 3:
                        deslocamento();
                        status.Text = tela_status;
                        break;
                    case 4:
                        deslocamento();
                        status.Text = tela_status;
                        break;
                }

                break;
            }
        }
    }
}
