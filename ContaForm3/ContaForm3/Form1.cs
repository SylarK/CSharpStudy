using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaForm3
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            contas = new Conta[3];

            Cliente cliente1 = new Cliente("Lucas Amado");
            this.contas[0] = new Conta(cliente1, 456, 001563, 1000);

            Cliente cliente2 = new Cliente("Beretriz Lestrange");
            this.contas[1] = new Conta(cliente2, 456, 001865, 800);

            Cliente cliente3 = new Cliente("Felix Oliveira");
            this.contas[2] = new Conta(cliente3, 456, 001990, 450);

            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int indiceCliente = Convert.ToInt32(textBox1.Text);
            textTitular.Text = contas[indiceCliente].Cliente.Nome;
            textAgenciaNumero.Text = contas[indiceCliente].Agencia + "/" + contas[indiceCliente].Numero;
            textSaldo.Text = Convert.ToString(contas[indiceCliente].Saldo);
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            int indiceCliente = Convert.ToInt32(textBox1.Text);
            contas[indiceCliente].Depositar(Convert.ToDouble(textBox6.Text));
            textSaldo.Text = Convert.ToString(contas[indiceCliente].Saldo);
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            int indiceCliente = Convert.ToInt32(textBox1.Text);
            contas[indiceCliente].Sacar(Convert.ToDouble(textBox7.Text));
            textSaldo.Text = Convert.ToString(contas[indiceCliente].Saldo);
        }
    }
}
