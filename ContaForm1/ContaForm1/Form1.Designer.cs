
namespace ContaForm1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoValorDepositar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.textoValorSacar = new System.Windows.Forms.TextBox();
            this.Conta = new System.Windows.Forms.GroupBox();
            this.Operacoes = new System.Windows.Forms.GroupBox();
            this.Conta.SuspendLayout();
            this.Operacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(118, 31);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(118, 57);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(118, 83);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo Abertura";
            // 
            // textoValorDepositar
            // 
            this.textoValorDepositar.Location = new System.Drawing.Point(32, 41);
            this.textoValorDepositar.Name = "textoValorDepositar";
            this.textoValorDepositar.Size = new System.Drawing.Size(74, 20);
            this.textoValorDepositar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.Location = new System.Drawing.Point(129, 67);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 9;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // textoValorSacar
            // 
            this.textoValorSacar.Location = new System.Drawing.Point(129, 41);
            this.textoValorSacar.Name = "textoValorSacar";
            this.textoValorSacar.Size = new System.Drawing.Size(75, 20);
            this.textoValorSacar.TabIndex = 8;
            // 
            // Conta
            // 
            this.Conta.Controls.Add(this.label3);
            this.Conta.Location = new System.Drawing.Point(22, 12);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(252, 102);
            this.Conta.TabIndex = 10;
            this.Conta.TabStop = false;
            this.Conta.Text = "Conta";
            // 
            // Operacoes
            // 
            this.Operacoes.Controls.Add(this.textoValorDepositar);
            this.Operacoes.Controls.Add(this.textoValorSacar);
            this.Operacoes.Controls.Add(this.botaoSacar);
            this.Operacoes.Controls.Add(this.button1);
            this.Operacoes.Location = new System.Drawing.Point(23, 129);
            this.Operacoes.Name = "Operacoes";
            this.Operacoes.Size = new System.Drawing.Size(252, 102);
            this.Operacoes.TabIndex = 11;
            this.Operacoes.TabStop = false;
            this.Operacoes.Text = "Operacoes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.Conta);
            this.Controls.Add(this.Operacoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conta.ResumeLayout(false);
            this.Conta.PerformLayout();
            this.Operacoes.ResumeLayout(false);
            this.Operacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoValorDepositar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.TextBox textoValorSacar;
        private System.Windows.Forms.GroupBox Conta;
        private System.Windows.Forms.GroupBox Operacoes;
    }
}

