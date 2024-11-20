using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        string operador = "";
        bool operadorSelecionado = false;

        public Form1()
        {
            InitializeComponent(); // Garante que o formulário e os controles sejam inicializados
        }

        // Quando o botão 1 for clicado
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        // Quando o botão 2 for clicado
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        // Quando o botão 3 for clicado
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        // Quando o botão 4 for clicado
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        // Quando o botão 5 for clicado
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        // Quando o botão 6 for clicado
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        // Quando o botão 7 for clicado
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        // Quando o botão 8 for clicado
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        // Quando o botão 9 for clicado
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        // Quando o botão 0 for clicado
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Quando o botão de soma (+) for clicado
        private void button11_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Quando o botão de subtração (-) for clicado
        private void button12_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Quando o botão de multiplicação (x) for clicado
        private void button13_Click(object sender, EventArgs e)
        {
            operador = "x";
            valor1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Quando o botão de divisão (/) for clicado
        private void button14_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        // Quando o botão de limpar (C) for clicado
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            valor1 = 0;
            valor2 = 0;
            operador = "";
        }

        // Quando o botão de igual (=) for clicado
        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = Double.Parse(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = (valor1 + valor2).ToString();
                    break;
                case "-":
                    textBox1.Text = (valor1 - valor2).ToString();
                    break;
                case "x":
                    textBox1.Text = (valor1 * valor2).ToString();
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        textBox1.Text = (valor1 / valor2).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Erro";
                    }
                    break;
                default:
                    break;
            }
        }

        // Efeito de hover nos botões
        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.CornflowerBlue; // Cor ao passar o mouse
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == button15) // Para o botão Limpar
                button.BackColor = System.Drawing.Color.Red;
            else if (button == button16) // Para o botão Igual
                button.BackColor = System.Drawing.Color.Green;
            else
                button.BackColor = System.Drawing.Color.LightSkyBlue; // Cor padrão para os botões
        }
    }
}
