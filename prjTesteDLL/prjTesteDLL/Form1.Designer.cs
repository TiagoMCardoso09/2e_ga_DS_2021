namespace prjTesteDLL
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnPerfeito = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um número";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtNum.Location = new System.Drawing.Point(61, 96);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(256, 40);
            this.txtNum.TabIndex = 0;
            // 
            // btnPar
            // 
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnPar.Location = new System.Drawing.Point(61, 163);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(256, 64);
            this.btnPar.TabIndex = 1;
            this.btnPar.Text = "PAR";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnPrimo
            // 
            this.btnPrimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnPrimo.Location = new System.Drawing.Point(61, 233);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(256, 64);
            this.btnPrimo.TabIndex = 2;
            this.btnPrimo.Text = "PRIMO";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnPerfeito
            // 
            this.btnPerfeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnPerfeito.Location = new System.Drawing.Point(61, 303);
            this.btnPerfeito.Name = "btnPerfeito";
            this.btnPerfeito.Size = new System.Drawing.Size(256, 64);
            this.btnPerfeito.TabIndex = 3;
            this.btnPerfeito.Text = "PERFEITO";
            this.btnPerfeito.UseVisualStyleBackColor = true;
            this.btnPerfeito.Click += new System.EventHandler(this.btnPerfeito_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbResultado.Location = new System.Drawing.Point(359, 44);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(402, 323);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 422);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnPerfeito);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnPerfeito;
        private System.Windows.Forms.Label lbResultado;
    }
}

