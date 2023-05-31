using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_PORTA_A_PORTA
{
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            try
            {
                ClassMYSQL.conexao.Open();
                ClassMYSQL.comando.CommandText = "SELECT * FROM tbl_cliente;";
                ClassMYSQL.comando.ExecuteNonQuery();
               // textBoxNOME.Text = dataGridViewPESQUISA.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Erro ao atualizar o contato!");
            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }

        }
    }
}
