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
    class AutoControle
    {
        public delegate void AutoModoDelegate(object sender, EventArgs e);

        public event AutoModoDelegate AutoModo;

        public void doAutoModo()
        {
            while (true)
            {
                if (AutoModo != null)
                {
                    AutoModo(this, EventArgs.Empty);
                }
                Thread.Sleep(3000);
            }
        }
    }

    public partial class Form1 : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected  static string atual_andar = "T";
        
        protected static int control = 0;

        protected static int operacao = 0;

        AutoControle autoControle;

        Task automata;

        public Form1()
        {
            InitializeComponent();

            this.autoControle = new AutoControle();
            this.automata = new Task(autoControle.doAutoModo);
        }

        public void deslocamento()
        {
            Thread.Sleep(5000);
        }

        //Estabelece o modo default do elevador após carga da aplicação
        private void Form1_Load(object sender, EventArgs e)
        {
            Log.Info("OPERAÇÃO INICIADA");

            status.Text = "T";

            Log.Info("Andar: Térreo");

            checkBox_ma.Checked = true;

            checkBox_ma_CheckedChanged(sender, e);
        }

        

        /***********************************************************/

        //Botão Térreo - Navegação Interna
        private void button1_Click(object sender, EventArgs e)
        {
            atual_andar = status.Text;

            switch (atual_andar)
            {
                case "T":
                    status.Text = "T";
                    Log.Info("Andar: Térreo");
                    break;
                case "1":
                    deslocamento();
                    status.Text = "T";
                    Log.Info("Andar: Térreo");
                    break;
                case "2":
                    deslocamento();
                    status.Text = "T";
                    Log.Info("Andar: Térreo");
                    break;
                case "3":
                    deslocamento();
                    status.Text = "T";
                    Log.Info("Andar: Térreo");
                    break;
                case "4":
                    deslocamento();
                    status.Text = "T";
                    Log.Info("Andar: Térreo");
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
                    Log.Info("Andar: 1");
                    break;
                case "1":
                    status.Text = "1";
                    Log.Info("Andar: 1");
                    break;
                case "2":
                    deslocamento();
                    status.Text = "1";
                    Log.Info("Andar: 1");
                    break;
                case "3":
                    deslocamento();
                    status.Text = "1";
                    Log.Info("Andar: 1");
                    break;
                case "4":
                    deslocamento();
                    status.Text = "1";
                    Log.Info("Andar: 1");
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
                    Log.Info("Andar: 2");
                    break;
                case "1":
                    deslocamento();
                    status.Text = "2";
                    Log.Info("Andar: 2");
                    break;
                case "2":
                    status.Text = "2";
                    Log.Info("Andar: 2");
                    break;
                case "3":
                    deslocamento();
                    status.Text = "2";
                    Log.Info("Andar: 2");
                    break;
                case "4":
                    deslocamento();
                    status.Text = "2";
                    Log.Info("Andar: 2");
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
                    Log.Info("Andar: 3");
                    break;
                case "1":
                    deslocamento();
                    status.Text = "3";
                    Log.Info("Andar: 3");
                    break;
                case "2":
                    deslocamento();
                    status.Text = "3";
                    Log.Info("Andar: 3");
                    break;
                case "3":
                    status.Text = "3";
                    Log.Info("Andar: 3");
                    break;
                case "4":
                    deslocamento();
                    status.Text = "3";
                    Log.Info("Andar: 3");
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
                    Log.Info("Andar: 4");
                    break;
                case "1":
                    deslocamento();
                    status.Text = "4";
                    Log.Info("Andar: 4");
                    break;
                case "2":
                    deslocamento();
                    status.Text = "4";
                    Log.Info("Andar: 4");
                    break;
                case "3":
                    deslocamento();
                    status.Text = "4";
                    Log.Info("Andar: 4");
                    break;
                case "4":
                    status.Text = "4";
                    Log.Info("Andar: 4");
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
                    vmodo.ForeColor = Color.Red;
                    vmodo.Text = "ENVIANDO ALERTA PARA CENTRAL...";
                    vexterno.ForeColor = Color.Red;
                    vexterno.Text = "PERIGO: MAL FUNCIONAMENTO!";
                    Log.Info("EMERGÊNCIA: OPERAÇÃO COM MAL FUNCIONAMENTO");
                    break;
                case 1:
                    status.BackColor = Color.Black;
                    status.Text = "T";
                    vmodo.ForeColor = Color.Lime;
                    vmodo.Text = "";
                    vexterno.ForeColor = Color.Lime;
                    vexterno.Text = "-----------------------------";
                    Log.Info("OPERAÇÃO RESTABELECIDA");
                    break;
            }
            
            //Controle do botão de emergência
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
            //Caixa de texto
        }
                
        private void status_Click(object sender, EventArgs e)
        {
            //Tela de status
        }

        //Botão Up - Térreo - Navegação Externa
        private void upT_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "T";
            atual_andar = status.Text;
            Log.Info("Andar: Térreo");
        }

        //Botão Up - 1º Andar - Navegação Externa
        private void up1_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "1";
            atual_andar = status.Text;
            Log.Info("Andar: 1");
        }

        //Botão Down - 1º Andar - Navegação Externa
        private void button8_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "1";
            atual_andar = status.Text;
            Log.Info("Andar: 1");
        }

        //Botão Up - 2º Andar - Navegação Externa
        private void up2_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "2";
            atual_andar = status.Text;
            Log.Info("Andar: 2");
        }

        //Botão Down - 2º Andar - Navegação Externa
        private void d2_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "2";
            atual_andar = status.Text;
            Log.Info("Andar: 2");
        }

        //Botão Up - 3º Andar - Navegação Externa
        private void up3_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "3";
            atual_andar = status.Text;
            Log.Info("Andar: 3");
        }

        //Botão Down - 3º Andar - Navegação Externa
        private void d3_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "3";
            atual_andar = status.Text;
            Log.Info("Andar: 3");
        }

        //Botão Down - 4º Andar - Navegação Externa
        private void d4_Click(object sender, EventArgs e)
        {
            deslocamento();
            status.Text = "4";
            atual_andar = status.Text;
            Log.Info("Andar: 4");
        }

        //Modo de Operação - MANUAL
        private void checkBox_ma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ma.Checked == true)
            {
                operacao = 0;
                vmodo.Text = "MODO MANUAL";
                checkBox_ma.Checked = true;
            }
            else
            {
                checkBox_at.Checked = true;
                checkBox_at_CheckedChanged(sender, e);
            }
        }

        //Modo de Operação - AUTOMÁTICO
        private void checkBox_at_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at.Checked == true)
            {
                operacao = 1;
                vmodo.Text = "MODO AUTOMATICO";

                //this.automata.Start();

                int cont = 0;

                this.Invoke((MethodInvoker)delegate ()
                {
                    vexterno.Text = "TESTE " + cont;

                    cont++;
                    /*
                    Random move_andar = new Random();

                    int andar = move_andar.Next(0, 5);

                    string tela_status = andar.ToString();

                    while (operacao == 1)
                    {
                        switch (andar)
                        {
                            case 0:
                                status.Text = "T";
                                break;
                            case 1:
                                status.Text = tela_status;
                                break;
                            case 2:
                                status.Text = tela_status;
                                break;
                            case 3:
                                status.Text = tela_status;
                                break;
                            case 4:
                                status.Text = tela_status;
                                break;
                        }
                    }
                    */
                });
            }
            else if (checkBox_at.Checked == false)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    checkBox_ma.Checked = true;
                    checkBox_ma_CheckedChanged(sender, e);
                });
            }
        }

        private void changeMode(object sender, EventArgs e)
        {
            
        }
    }
}