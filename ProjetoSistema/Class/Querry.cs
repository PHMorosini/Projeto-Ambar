using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema.Class
{
    internal class Querry
    {
        public static void PesquisarNaGrid(TextBox TextoBusca, DataGridView Grid,string NomeCampo)
        {
            string TextoPesquisa = TextoBusca.Text;
            if (TextoPesquisa == "%")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string Querry = "SELECT * FROM cadpro";
                        SqlDataAdapter da = new SqlDataAdapter(Querry, cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid.DataSource = dt;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao fazer a busca \n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string Querry = $"SELECT * FROM cadpro where {NomeCampo} like @Text"; //alterar o nome campo pelo nome da coluna no SQL

                        using (SqlCommand cmd = new SqlCommand(Querry, cn))
                        {
                            cmd.Parameters.AddWithValue($"@Text", TextoPesquisa + "%");

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            Grid.DataSource = dt;
                        }
                        cn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao fazer a busca \n" + ex.Message);
                }
            }

        }
    }
}
