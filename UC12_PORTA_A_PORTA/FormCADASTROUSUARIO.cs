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
    public partial class FormCADASTROUSUARIO : Form
    {
        public FormCADASTROUSUARIO()
        {
            InitializeComponent();
        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNOME.Text != "" && textBoxUSUARIO.Text != "" && textBoxSENHA.Text != "" && textBoxCOMFIRMASENHA.Text != "")
                {


                    ClassMYSQL.conexao.Open();
                    ClassMYSQL.comando.CommandText = "INSERT INTO tbl_usuario (nome, usuario, senha) VALUES ('" + textBoxNOME.Text + "', '" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');";



                    if (textBoxSENHA.Text == textBoxCOMFIRMASENHA.Text)
                    {
                        if (textBoxSENHA.Text.Length >= 8)
                        {
                            MySqlDataReader readaerLOGIN = ClassMYSQL.comando.ExecuteReader();
                        }
                        else
                        {
                            MessageBox.Show("Minimo de 8 caracteres");
                        }


                    }

                    else
                    {
                        MessageBox.Show("As senhas precisam ser iguais");
                    }


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
