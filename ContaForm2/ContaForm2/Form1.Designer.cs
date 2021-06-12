
namespace ContaForm2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxConta = new System.Windows.Forms.GroupBox();
            this.BoxDescricaoConta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarConta = new System.Windows.Forms.Button();
            this.text_Conta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Titular = new System.Windows.Forms.TextBox();
            this.text_Numero = new System.Windows.Forms.TextBox();
            this.text_Saldo = new System.Windows.Forms.TextBox();
            this.text_Valor = new System.Windows.Forms.TextBox();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.BoxConta.SuspendLayout();
            this.BoxDescricaoConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxConta
            // 
            this.BoxConta.Controls.Add(this.btn_BuscarConta);
            this.BoxConta.Controls.Add(this.text_Conta);
            this.BoxConta.Controls.Add(this.label1);
            this.BoxConta.Location = new System.Drawing.Point(12, 12);
            this.BoxConta.Name = "BoxConta";
            this.BoxConta.Size = new System.Drawing.Size(318, 99);
            this.BoxConta.TabIndex = 0;
            this.BoxConta.TabStop = false;
            this.BoxConta.Text = "Conta";
            // 
            // BoxDescricaoConta
            // 
            this.BoxDescricaoConta.Controls.Add(this.btn_Sacar);
            this.BoxDescricaoConta.Controls.Add(this.btn_Depositar);
            this.BoxDescricaoConta.Controls.Add(this.text_Valor);
            this.BoxDescricaoConta.Controls.Add(this.text_Saldo);
            this.BoxDescricaoConta.Controls.Add(this.text_Numero);
            this.BoxDescricaoConta.Controls.Add(this.text_Titular);
            this.BoxDescricaoConta.Controls.Add(this.label5);
            this.BoxDescricaoConta.Controls.Add(this.label4);
            this.BoxDescricaoConta.Controls.Add(this.label3);
            this.BoxDescricaoConta.Controls.Add(this.label2);
            this.BoxDescricaoConta.Location = new System.Drawing.Point(12, 117);
            this.BoxDescricaoConta.Name = "BoxDescricaoConta";
            this.BoxDescricaoConta.Size = new System.Drawing.Size(318, 182);
            this.BoxDescricaoConta.TabIndex = 1;
            this.BoxDescricaoConta.TabStop = false;
            this.BoxDescricaoConta.Text = "Descricao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a conta";
            // 
            // btn_BuscarConta
            // 
            this.btn_BuscarConta.Location = new System.Drawing.Point(211, 45);
            this.btn_BuscarConta.Name = "btn_BuscarConta";
            this.btn_BuscarConta.Size = new System.Drawing.Size(75, 21);
            this.btn_BuscarConta.TabIndex = 1;
            this.btn_BuscarConta.Text = "Search";
            this.btn_BuscarConta.UseVisualStyleBackColor = true;
            this.btn_BuscarConta.Click += new System.EventHandler(this.btn_BuscarConta_Click);
            // 
            // text_Conta
            // 
            this.text_Conta.Location = new System.Drawing.Point(105, 45);
            this.text_Conta.Name = "text_Conta";
            this.text_Conta.Size = new System.Drawing.Size(100, 20);
            this.text_Conta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // text_Titular
            // 
            this.text_Titular.Location = new System.Drawing.Point(105, 26);
            this.text_Titular.Name = "text_Titular";
            this.text_Titular.Size = new System.Drawing.Size(181, 20);
            this.text_Titular.TabIndex = 3;
            // 
            // text_Numero
            // 
            this.text_Numero.Location = new System.Drawing.Point(105, 55);
            this.text_Numero.Name = "text_Numero";
            this.text_Numero.Size = new System.Drawing.Size(181, 20);
            this.text_Numero.TabIndex = 7;
            // 
            // text_Saldo
            // 
            this.text_Saldo.Location = new System.Drawing.Point(105, 81);
            this.text_Saldo.Name = "text_Saldo";
            this.text_Saldo.Size = new System.Drawing.Size(181, 20);
            this.text_Saldo.TabIndex = 8;
            // 
            // text_Valor
            // 
            this.text_Valor.Location = new System.Drawing.Point(105, 107);
            this.text_Valor.Name = "text_Valor";
            this.text_Valor.Size = new System.Drawing.Size(181, 20);
            this.text_Valor.TabIndex = 9;
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.Location = new System.Drawing.Point(105, 144);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(75, 21);
            this.btn_Depositar.TabIndex = 3;
            this.btn_Depositar.Text = "Depositar";
            this.btn_Depositar.UseVisualStyleBackColor = true;
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Location = new System.Drawing.Point(211, 144);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(75, 21);
            this.btn_Sacar.TabIndex = 10;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 324);
            this.Controls.Add(this.BoxDescricaoConta);
            this.Controls.Add(this.BoxConta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BoxConta.ResumeLayout(false);
            this.BoxConta.PerformLayout();
            this.BoxDescricaoConta.ResumeLayout(false);
            this.BoxDescricaoConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxConta;
        private System.Windows.Forms.Button btn_BuscarConta;
        private System.Windows.Forms.TextBox text_Conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BoxDescricaoConta;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.TextBox text_Valor;
        private System.Windows.Forms.TextBox text_Saldo;
        private System.Windows.Forms.TextBox text_Numero;
        private System.Windows.Forms.TextBox text_Titular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

