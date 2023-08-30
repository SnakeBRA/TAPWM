namespace PClasses
{
    partial class frmHorista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalarioHr = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalarioHr = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.lblNumHrs = new System.Windows.Forms.Label();
            this.txtNumHrs = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblMatricula.Location = new System.Drawing.Point(89, 63);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(76, 18);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            this.lblMatricula.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(89, 243);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(190, 18);
            this.lblDataEntrada.TabIndex = 2;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            this.lblDataEntrada.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblSalarioHr
            // 
            this.lblSalarioHr.AutoSize = true;
            this.lblSalarioHr.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblSalarioHr.Location = new System.Drawing.Point(89, 150);
            this.lblSalarioHr.Name = "lblSalarioHr";
            this.lblSalarioHr.Size = new System.Drawing.Size(95, 18);
            this.lblSalarioHr.TabIndex = 3;
            this.lblSalarioHr.Text = "Salário Hora";
            this.lblSalarioHr.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblNome.Location = new System.Drawing.Point(89, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(316, 59);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(285, 26);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(316, 239);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(285, 26);
            this.txtDataEntrada.TabIndex = 6;
            this.txtDataEntrada.TextChanged += new System.EventHandler(this.TxtDataEntrada_TextChanged);
            // 
            // txtSalarioHr
            // 
            this.txtSalarioHr.Location = new System.Drawing.Point(316, 146);
            this.txtSalarioHr.Name = "txtSalarioHr";
            this.txtSalarioHr.Size = new System.Drawing.Size(285, 26);
            this.txtSalarioHr.TabIndex = 7;
            this.txtSalarioHr.TextChanged += new System.EventHandler(this.TxtSalarioHr_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(316, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 26);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInstanciar.Location = new System.Drawing.Point(348, 376);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(225, 44);
            this.btnInstanciar.TabIndex = 9;
            this.btnInstanciar.Text = "Instanciar Horista";
            this.btnInstanciar.UseVisualStyleBackColor = false;
            this.btnInstanciar.Click += new System.EventHandler(this.Inspecionar_Click);
            // 
            // lblNumHrs
            // 
            this.lblNumHrs.AutoSize = true;
            this.lblNumHrs.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHrs.Location = new System.Drawing.Point(89, 196);
            this.lblNumHrs.Name = "lblNumHrs";
            this.lblNumHrs.Size = new System.Drawing.Size(133, 18);
            this.lblNumHrs.TabIndex = 11;
            this.lblNumHrs.Text = "Número de Horas";
            // 
            // txtNumHrs
            // 
            this.txtNumHrs.Location = new System.Drawing.Point(316, 192);
            this.txtNumHrs.Name = "txtNumHrs";
            this.txtNumHrs.Size = new System.Drawing.Size(285, 26);
            this.txtNumHrs.TabIndex = 12;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(316, 290);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(285, 26);
            this.txtDiasFalta.TabIndex = 13;
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasFalta.Location = new System.Drawing.Point(89, 294);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(99, 18);
            this.lblDiasFalta.TabIndex = 14;
            this.lblDiasFalta.Text = "Dias de Falta";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 623);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtNumHrs);
            this.Controls.Add(this.lblNumHrs);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalarioHr);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSalarioHr);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalarioHr;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalarioHr;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Label lblNumHrs;
        private System.Windows.Forms.TextBox txtNumHrs;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label lblDiasFalta;
    }
}