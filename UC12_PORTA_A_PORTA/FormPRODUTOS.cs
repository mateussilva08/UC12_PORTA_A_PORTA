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
    public partial class FormPRODUTOS : Form
    {
        public static string servidor = "Server=localhost;Database=bd_porta_a_porta;Uid=root;Pwd=";
        public static MySqlConnection conexao = new MySqlConnection(servidor);
        public static MySqlCommand comando = conexao.CreateCommand();

        public FormPRODUTOS()
        {
            InitializeComponent();
            mostrarproduto();
        }

        private void mostrarproduto()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produto;";
                comando.ExecuteNonQuery();

                MySqlDataAdapter adaptadorPRODUTO = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTO = new DataTable();
                adaptadorPRODUTO.Fill(tabelaPRODUTO);

                dataGridView1.DataSource = tabelaPRODUTO;
                // textBoxNOME.Text = dataGridViewPESQUISA.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Erro ao atualizar o contato!");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}

