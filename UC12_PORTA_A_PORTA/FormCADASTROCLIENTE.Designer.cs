namespace UC12_PORTA_A_PORTA
{
    partial class FormCADASTROCLIENTE
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.CADASTRAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTELEFONE = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(128, 61);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(176, 20);
            this.textBoxNOME.TabIndex = 20;
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Location = new System.Drawing.Point(171, 358);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.CADASTRAR.TabIndex = 19;
            this.CADASTRAR.Text = "Cadastrar";
            this.CADASTRAR.UseVisualStyleBackColor = true;
            this.CADASTRAR.Click += new System.EventHandler(this.CADASTRAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço";
            // 
            // textBoxENDERECO
            // 
            this.textBoxENDERECO.Location = new System.Drawing.Point(128, 300);
            this.textBoxENDERECO.Name = "textBoxENDERECO";
            this.textBoxENDERECO.Size = new System.Drawing.Size(176, 20);
            this.textBoxENDERECO.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "CPF";
            // 
            // textBoxTELEFONE
            // 
            this.textBoxTELEFONE.Location = new System.Drawing.Point(128, 214);
            this.textBoxTELEFONE.Name = "textBoxTELEFONE";
            this.textBoxTELEFONE.Size = new System.Drawing.Size(176, 20);
            this.textBoxTELEFONE.TabIndex = 14;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(128, 130);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(176, 20);
            this.textBoxCPF.TabIndex = 13;
            // 
            // FormCADASTROCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.CADASTRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxENDERECO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTELEFONE);
            this.Controls.Add(this.textBoxCPF);
            this.Name = "FormCADASTROCLIENTE";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Button CADASTRAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTELEFONE;
        private System.Windows.Forms.TextBox textBoxCPF;
    }
}