using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";
        string[] entradaProibida = new string[] { "NaN", "Entrada inválida", "Infinity" };
        public Calculadora()
        {
            InitializeComponent();
        }

        private void botaoSete_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "7";
        }

        private void botaoFracao_Click(object sender, EventArgs e)
        {
            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = (1 / (valor1)).ToString(CultureInfo.InvariantCulture);
            }
        }

        private void botaoUm_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "1";
        }

        private void botaoDecimal_Click(object sender, EventArgs e)
        {
            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if(!telaResultado.Text.Contains("."))
            {
                telaResultado.Text += ".";
            }
            
        }

        private void botaoZero_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "0";
        }

        private void botaoQuatro_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "4";
        }

        private void botaoDois_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "2";
        }

        private void botaoCinco_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "5";
        }

        private void botaoOito_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "8";
        }

        private void botaoNove_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "9";
        }

        private void botaoSeis_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "6";
        }

        private void botaoTres_Click(object sender, EventArgs e)
        {
            telaResultado.Text += "3";
        }

        private void botaoApagarVisor_Click(object sender, EventArgs e)
        {
            telaResultado.Text = "";
        }

        private void botaoApagarDigito_Click(object sender, EventArgs e)
        {
            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains)) {
                telaResultado.Text = "";
                
            }
            else if(telaResultado.Text != "")
            {
                telaResultado.Text = telaResultado.Text.Remove(telaResultado.Text.Length - 1);
            }
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor2 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    telaResultado.Text = (valor1 + valor2).ToString(CultureInfo.InvariantCulture);
                    labelOperacao.Text = "";
                }
                if (operacao == "SUBTRAÇÃO")
                {
                    telaResultado.Text = (valor1 - valor2).ToString(CultureInfo.InvariantCulture);
                    labelOperacao.Text = "";
                }
                if (operacao == "MULTIPLICAÇÃO")
                {
                    telaResultado.Text = (valor1 * valor2).ToString(CultureInfo.InvariantCulture);
                    labelOperacao.Text = "";
                }
                if (operacao == "DIVISÃO")
                {
                    telaResultado.Text = (valor1 / valor2).ToString(CultureInfo.InvariantCulture);
                    labelOperacao.Text = "";
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void telaResultado_TextChanged(object sender, EventArgs e)
        {
            if (telaResultado.TextLength >= 20)
            {
                labelOperacao.Text = "";
            }
            else if (telaResultado.TextLength > 16)
            {
                telaResultado.Text = (telaResultado.Text.Substring(0, 16));

            }
        }
            private void botaoMenos_Click(object sender, EventArgs e)
        {
            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = "";
                operacao = "SUBTRAÇÃO";
                labelOperacao.Text = "-";
            }
            
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {

            if (telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = "";
                operacao = "MULTIPLICAÇÃO";
                labelOperacao.Text = "*";
            }
        }

        private void botaoDivisao_Click(object sender, EventArgs e)
        {
            if(telaResultado.Text == "" || entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = "";
                operacao = "DIVISÃO";
                labelOperacao.Text = "/";
            }
                
        }

        private void botaoRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "Entrada inválida";
                labelOperacao.Text = "";
            }
            else if(telaResultado.Text != "")
            {
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = (Convert.ToSingle(Math.Sqrt((double)valor1))).ToString(CultureInfo.InvariantCulture);
            }
           
  
        }

        private void botaoPorcentagem_Click(object sender, EventArgs e)
        {
            if (entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "Entrada inválida";
                labelOperacao.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor2 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                if (valor1.ToString() != "0")
                {
                    telaResultado.Text = ((valor2 * valor1) / 100).ToString(CultureInfo.InvariantCulture);
                    labelOperacao.Text = "%";
                }
                else
                {
                    telaResultado.Text = ("Entrada inválida");
                }
            }
           
        }

        private void botaoApagarMemoria_Click(object sender, EventArgs e)
        {
            telaResultado.Text = "";
            operacao = "";
            labelOperacao.Text = "";
        }

        private void botaoAlterarSinal_Click(object sender, EventArgs e)
        {
            if (entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else
            {
                if (telaResultado.Text.StartsWith("-"))
                {
                    telaResultado.Text = telaResultado.Text.Remove(0, 1);
                }
                else
                {
                    telaResultado.Text = ("-" + telaResultado.Text);
                }
            }
            
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            if (entradaProibida.Any(telaResultado.Text.Contains) || telaResultado.Text == "," || telaResultado.Text == "-" || telaResultado.Text == ".")
            {
                telaResultado.Text = "";
            }
            else if (telaResultado.Text != "")
            {
                valor1 = double.Parse(telaResultado.Text, CultureInfo.InvariantCulture);
                telaResultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
        }
    }
}
