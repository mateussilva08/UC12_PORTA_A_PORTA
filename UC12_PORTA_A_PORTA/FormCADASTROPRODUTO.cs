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
    public partial class FormCADASTROPRODUTO : Form
    {
        public FormCADASTROPRODUTO()
        {
            InitializeComponent();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPRECO.Text != "" && textBoxDESCRICAO.Text != "")
                {


                    ClassMYSQL.conexao.Open();
                    ClassMYSQL.comando.CommandText = "INSERT INTO tbl_produto (descricao, preco) VALUES ('" + textBoxDESCRICAO.Text + "', '" + textBoxPRECO.Text + "');";

                }
                else
                {
                    MessageBox.Show("Campos em branco");
                }
            }


            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Campos em branco");
            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }
        }
    }
}
