namespace UC12_PORTA_A_PORTA
{
    partial class FormCADASTROUSUARIO
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCOMFIRMASENHA = new System.Windows.Forms.TextBox();
            this.CADASTRAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(88, 202);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(176, 20);
            this.textBoxSENHA.TabIndex = 5;
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(88, 118);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(176, 20);
            this.textBoxUSUARIO.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirme a Senha";
            // 
            // textBoxCOMFIRMASENHA
            // 
            this.textBoxCOMFIRMASENHA.Location = new System.Drawing.Point(88, 288);
            this.textBoxCOMFIRMASENHA.Name = "textBoxCOMFIRMASENHA";
            this.textBoxCOMFIRMASENHA.Size = new System.Drawing.Size(176, 20);
            this.textBoxCOMFIRMASENHA.TabIndex = 8;
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Location = new System.Drawing.Point(131, 346);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.CADASTRAR.TabIndex = 10;
            this.CADASTRAR.Text = "Cadastrar";
            this.CADASTRAR.UseVisualStyleBackColor = true;
            this.CADASTRAR.Click += new System.EventHandler(this.CADASTRAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(88, 49);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(176, 20);
            this.textBoxNOME.TabIndex = 11;
            // 
            // FormCADASTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.CADASTRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCOMFIRMASENHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "FormCADASTRO";
            this.Text = "FormCADASTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCOMFIRMASENHA;
        private System.Windows.Forms.Button CADASTRAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNOME;
    }
}