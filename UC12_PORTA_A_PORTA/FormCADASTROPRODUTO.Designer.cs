namespace UC12_PORTA_A_PORTA
{
    partial class FormCADASTROPRODUTO
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
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.textBoxPRECO = new System.Windows.Forms.TextBox();
            this.labelDESCRICAO = new System.Windows.Forms.Label();
            this.Preço = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(67, 103);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(155, 20);
            this.textBoxDESCRICAO.TabIndex = 0;
            // 
            // textBoxPRECO
            // 
            this.textBoxPRECO.Location = new System.Drawing.Point(67, 189);
            this.textBoxPRECO.Name = "textBoxPRECO";
            this.textBoxPRECO.Size = new System.Drawing.Size(155, 20);
            this.textBoxPRECO.TabIndex = 1;
            // 
            // labelDESCRICAO
            // 
            this.labelDESCRICAO.AutoSize = true;
            this.labelDESCRICAO.Location = new System.Drawing.Point(67, 60);
            this.labelDESCRICAO.Name = "labelDESCRICAO";
            this.labelDESCRICAO.Size = new System.Drawing.Size(110, 13);
            this.labelDESCRICAO.TabIndex = 2;
            this.labelDESCRICAO.Text = "Descrição do Produto";
            // 
            // Preço
            // 
            this.Preço.AutoSize = true;
            this.Preço.Location = new System.Drawing.Point(67, 161);
            this.Preço.Name = "Preço";
            this.Preço.Size = new System.Drawing.Size(35, 13);
            this.Preço.TabIndex = 3;
            this.Preço.Text = "Preço";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(102, 241);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 4;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // FormCADASTROPRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 367);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.Preço);
            this.Controls.Add(this.labelDESCRICAO);
            this.Controls.Add(this.textBoxPRECO);
            this.Controls.Add(this.textBoxDESCRICAO);
            this.Name = "FormCADASTROPRODUTO";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.TextBox textBoxPRECO;
        private System.Windows.Forms.Label labelDESCRICAO;
        private System.Windows.Forms.Label Preço;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}