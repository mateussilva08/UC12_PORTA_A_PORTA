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


            }
            catch (Exception erro)
            {

            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }
           
        }
    }
}
