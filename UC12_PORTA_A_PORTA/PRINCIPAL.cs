using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_PORTA_A_PORTA
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

       

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTROPRODUTO();

           // telaCADASTRO.MdiParent = this;
            telaCADASTRO.Show();
            telaCADASTRO.WindowState = FormWindowState.Maximized;

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTROCLIENTE();

            // telaCADASTRO.MdiParent = this;
            telaCADASTRO.Show();
            telaCADASTRO.WindowState = FormWindowState.Maximized;
        }
    }
}
