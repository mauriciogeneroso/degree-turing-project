namespace MaquinaDeTuring
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tbBase = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbposição = new System.Windows.Forms.TextBox();
            this.tbatual = new System.Windows.Forms.TextBox();
            this.labelFita = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(107, 11);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(248, 20);
            this.tbBase.TabIndex = 0;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(107, 41);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(248, 20);
            this.tbAltura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base do triângulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura do triângulo:";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(377, 9);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(377, 42);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.tbBase);
            this.panel1.Controls.Add(this.btIniciar);
            this.panel1.Controls.Add(this.tbAltura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 76);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 38);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fórmula: (Base x Altura) / 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Realiza o cálculo da área de um triângulo.";
            // 
            // tbposição
            // 
            this.tbposição.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbposição.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbposição.Enabled = false;
            this.tbposição.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbposição.Location = new System.Drawing.Point(12, 163);
            this.tbposição.Name = "tbposição";
            this.tbposição.Size = new System.Drawing.Size(467, 13);
            this.tbposição.TabIndex = 8;
            this.tbposição.Text = " ";
            // 
            // tbatual
            // 
            this.tbatual.Location = new System.Drawing.Point(12, 182);
            this.tbatual.Name = "tbatual";
            this.tbatual.Size = new System.Drawing.Size(467, 20);
            this.tbatual.TabIndex = 9;
            // 
            // labelFita
            // 
            this.labelFita.AutoSize = true;
            this.labelFita.Location = new System.Drawing.Point(16, 147);
            this.labelFita.Name = "labelFita";
            this.labelFita.Size = new System.Drawing.Size(0, 13);
            this.labelFita.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fita:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFita);
            this.Controls.Add(this.tbatual);
            this.Controls.Add(this.tbposição);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Maquina de Turing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbposição;
        private System.Windows.Forms.TextBox tbatual;
        private System.Windows.Forms.Label labelFita;
        private System.Windows.Forms.Label label5;
    }
}

