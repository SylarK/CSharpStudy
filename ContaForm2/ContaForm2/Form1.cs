using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaForm2
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            contas = new Conta[3];
            Cliente cliente1 = new Cliente("Lucas Amado");
            Cliente cliente2 = new Cliente("Joaquim Pereira");
            Cliente cliente3 = new Cliente("Jonas Birigui");
            
            this.contas[0] = new Conta(cliente1, 4566, 10000);
            this.contas[1] = new Conta(cliente2, 4469, 4569.50);
            this.contas[2] = new Conta(cliente3, 4998);
            InitializeComponent();
        }

        private void btn_BuscarConta_Click(object sender, EventArgs e)
        {
            int indiceTyped = Convert.ToInt32(text_Conta.Text);
            Conta selected = this.contas[indiceTyped];
            text_Titular.Text = selected.Cliente.Nome;
            text_Numero.Text = Convert.ToString(selected.Numero);
            text_Saldo.Text = Convert.ToString(selected.Saldo);
            //MessageBox.Show(Convert.ToString(indiceTyped));
        }
    }
}
