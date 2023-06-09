﻿using System;
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
        public static string servidor = "Server=localhost;Database=bd_porta_a_porta;Uid=root;Pwd=";
        public static MySqlConnection conexao = new MySqlConnection(servidor);
        public static MySqlCommand comando = conexao.CreateCommand();

        public CLIENTES()
        {
            InitializeComponent();
            mostrarclientes();

        }
        private void mostrarclientes()
        {

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_cliente;";
                comando.ExecuteNonQuery();

                MySqlDataAdapter adaptadorCLIENTES = new MySqlDataAdapter(comando);

                DataTable tabelaCLIENTES = new DataTable();
                adaptadorCLIENTES.Fill(tabelaCLIENTES);

                dataGridView1.DataSource = tabelaCLIENTES;
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
