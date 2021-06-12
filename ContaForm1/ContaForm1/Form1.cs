using ContaForm1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaForm1
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Lucas", "701.000.659-98");
            this.c = new Conta(cliente, 1000.50, 50565);


            textoTitular.Text = c.Cliente.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValorDepositar.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Valor depositado com sucesso.");
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValorSacar.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Sacar(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Saque realizado com sucesso.");
        }
    }
}
