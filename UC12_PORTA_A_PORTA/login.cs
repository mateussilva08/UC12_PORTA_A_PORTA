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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                ClassMYSQL.conexao.Open();
                ClassMYSQL.comando.CommandText = "SELECT * FROM tbl_usuario WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";
                MySqlDataReader readaerLOGIN = ClassMYSQL.comando.ExecuteReader();
                if (readaerLOGIN.Read())
                {
                    ClassVARIAVEIS.usuario = readaerLOGIN["usuario"].ToString();
                    //ClassVARIAVEIS.permissao = readaerLOGIN["permissao"].ToString();

                    Form telaPRINCIPAL = new PRINCIPAL();
                    telaPRINCIPAL.Show();
                }
                else
                {
                    MessageBox.Show("usuario e/ou senha incorretos");
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }
        }
    }
}
