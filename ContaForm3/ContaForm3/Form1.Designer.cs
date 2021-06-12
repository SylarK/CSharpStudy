
namespace ContaForm3
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BoxDetalhes = new System.Windows.Forms.GroupBox();
            this.textAgenciaNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxOperacoes = new System.Windows.Forms.GroupBox();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.BoxConta.SuspendLayout();
            this.BoxDetalhes.SuspendLayout();
            this.BoxOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxConta
            // 
            this.BoxConta.Controls.Add(this.btn_Search);
            this.BoxConta.Controls.Add(this.textBox1);
            this.BoxConta.Location = new System.Drawing.Point(12, 22);
            this.BoxConta.Name = "BoxConta";
            this.BoxConta.Size = new System.Drawing.Size(300, 82);
            this.BoxConta.TabIndex = 0;
            this.BoxConta.TabStop = false;
            this.BoxConta.Text = "Conta";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(172, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BoxDetalhes
            // 
            this.BoxDetalhes.Controls.Add(this.textAgenciaNumero);
            this.BoxDetalhes.Controls.Add(this.label4);
            this.BoxDetalhes.Controls.Add(this.textSaldo);
            this.BoxDetalhes.Controls.Add(this.label3);
            this.BoxDetalhes.Controls.Add(this.textTitular);
            this.BoxDetalhes.Controls.Add(this.label1);
            this.BoxDetalhes.Location = new System.Drawing.Point(12, 125);
            this.BoxDetalhes.Name = "BoxDetalhes";
            this.BoxDetalhes.Size = new System.Drawing.Size(300, 138);
            this.BoxDetalhes.TabIndex = 1;
            this.BoxDetalhes.TabStop = false;
            this.BoxDetalhes.Text = "Detalhes";
            // 
            // textAgenciaNumero
            // 
            this.textAgenciaNumero.Location = new System.Drawing.Point(145, 104);
            this.textAgenciaNumero.Name = "textAgenciaNumero";
            this.textAgenciaNumero.Size = new System.Drawing.Size(124, 20);
            this.textAgenciaNumero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ag/Número";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(145, 78);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(124, 20);
            this.textSaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo Atual";
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(145, 26);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(124, 20);
            this.textTitular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Titular";
            // 
            // BoxOperacoes
            // 
            this.BoxOperacoes.Controls.Add(this.btn_Sacar);
            this.BoxOperacoes.Controls.Add(this.textBox7);
            this.BoxOperacoes.Controls.Add(this.btn_Depositar);
            this.BoxOperacoes.Controls.Add(this.textBox6);
            this.BoxOperacoes.Location = new System.Drawing.Point(12, 279);
            this.BoxOperacoes.Name = "BoxOperacoes";
            this.BoxOperacoes.Size = new System.Drawing.Size(300, 159);
            this.BoxOperacoes.TabIndex = 2;
            this.BoxOperacoes.TabStop = false;
            this.BoxOperacoes.Text = "Operacoes";
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Location = new System.Drawing.Point(149, 86);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(89, 23);
            this.btn_Sacar.TabIndex = 9;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(149, 60);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(89, 20);
            this.textBox7.TabIndex = 10;
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.Location = new System.Drawing.Point(45, 86);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(89, 23);
            this.btn_Depositar.TabIndex = 2;
            this.btn_Depositar.Text = "Depositar";
            this.btn_Depositar.UseVisualStyleBackColor = true;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(45, 60);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 20);
            this.textBox6.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.BoxOperacoes);
            this.Controls.Add(this.BoxDetalhes);
            this.Controls.Add(this.BoxConta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BoxConta.ResumeLayout(false);
            this.BoxConta.PerformLayout();
            this.BoxDetalhes.ResumeLayout(false);
            this.BoxDetalhes.PerformLayout();
            this.BoxOperacoes.ResumeLayout(false);
            this.BoxOperacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxConta;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox BoxDetalhes;
        private System.Windows.Forms.TextBox textAgenciaNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BoxOperacoes;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.TextBox textBox6;
    }
}

