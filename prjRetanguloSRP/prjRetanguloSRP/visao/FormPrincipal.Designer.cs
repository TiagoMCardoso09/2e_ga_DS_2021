namespace prjRetanguloSRP.visao
{
    partial class FormPrincipal
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbPerimetro = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGrafico = new System.Windows.Forms.Panel();
            this.btnPlotar = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.Black;
            this.pnSuperior.Controls.Add(this.lbPerimetro);
            this.pnSuperior.Controls.Add(this.lbArea);
            this.pnSuperior.Controls.Add(this.btnPlotar);
            this.pnSuperior.Controls.Add(this.btnCalcular);
            this.pnSuperior.Controls.Add(this.txtL2);
            this.pnSuperior.Controls.Add(this.txtL1);
            this.pnSuperior.Controls.Add(this.label2);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(557, 199);
            this.pnSuperior.TabIndex = 0;
            // 
            // lbPerimetro
            // 
            this.lbPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerimetro.Location = new System.Drawing.Point(267, 147);
            this.lbPerimetro.Name = "lbPerimetro";
            this.lbPerimetro.Size = new System.Drawing.Size(272, 39);
            this.lbPerimetro.TabIndex = 6;
            this.lbPerimetro.Text = "PERÍMETRO: 0";
            this.lbPerimetro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArea
            // 
            this.lbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(273, 91);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(266, 39);
            this.lbArea.TabIndex = 6;
            this.lbArea.Text = "AREA: 0";
            this.lbArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(18, 91);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(243, 39);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(279, 52);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(260, 22);
            this.txtL2.TabIndex = 1;
            this.txtL2.Text = "0";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(18, 52);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(243, 22);
            this.txtL1.TabIndex = 0;
            this.txtL1.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lado 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lado 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnGrafico
            // 
            this.pnGrafico.Location = new System.Drawing.Point(18, 205);
            this.pnGrafico.Name = "pnGrafico";
            this.pnGrafico.Size = new System.Drawing.Size(521, 251);
            this.pnGrafico.TabIndex = 6;
            this.pnGrafico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnGrafico_MouseClick);
            // 
            // btnPlotar
            // 
            this.btnPlotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlotar.Location = new System.Drawing.Point(18, 147);
            this.btnPlotar.Name = "btnPlotar";
            this.btnPlotar.Size = new System.Drawing.Size(243, 39);
            this.btnPlotar.TabIndex = 5;
            this.btnPlotar.Text = "Plotar";
            this.btnPlotar.UseVisualStyleBackColor = true;
            this.btnPlotar.Click += new System.EventHandler(this.btnPlotar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(557, 474);
            this.Controls.Add(this.pnGrafico);
            this.Controls.Add(this.pnSuperior);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLOTADOR DE RETANGULOS";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPerimetro;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnPlotar;
        private System.Windows.Forms.Panel pnGrafico;
    }
}