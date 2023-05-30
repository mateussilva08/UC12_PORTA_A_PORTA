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
    public partial class FormCADASTROCLIENTE : Form
    {
        public FormCADASTROCLIENTE()
        {
            InitializeComponent();
        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxTELEFONE.Text != "" )
                {


                    ClassMYSQL.conexao.Open();
                    ClassMYSQL.comando.CommandText = "INSERT INTO tbl_cliente (nome, cpf, telefone, endereco) VALUES ('" + textBoxNOME.Text + "', '" + textBoxCPF.Text + "', '" + textBoxTELEFONE.Text + "', '" + textBoxENDERECO.Text + "');";
                                 
                }
                else
                {
                    MessageBox.Show(" ");
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
