using ProjetoSistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema.Views
{
    public partial class Login : Form
    {
        private string strSQL = string.Empty;

        public bool logado = false;
        private Timer Timer1;
        public Login()
        {
            InitializeComponent();
            Timer timer = new Timer();
            Timer1 = timer;
            Timer1.Interval = 1000; // Define o intervalo do Timer1 em milissegundos
            Timer1.Tick += Timer1_Tick; // Associa o evento Tick do Timer1 ao método Timer1_Tick
            Timer1.Start(); // Inicia o Timer1
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Atribui à Label a data e hora atual formatada
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    String user = txtUser.Text;
                    String pass = txtPass.Text;
                    String strSQL = "SELECT COUNT(ID) FROM [CADUSER] WHERE [Usuario] = @user AND [Senha] = @pass";
                    SqlCommand cmd = new SqlCommand(strSQL, cn);

                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) // efetuador de login, só vai funcionar se o count for maior que 0 (tem que retornar ao menos um usuario na querry do comando StrSQL a cima)
                    {
                        MessageBox.Show("Seja bem-vindo "+ user);
                        frmPrincipal Sis = new frmPrincipal();
                        this.Hide();
                        Sis.Show();
                    }
                    else if (txtPass.Text == "" & txtUser.Text == "") //Campos vazios
                    {
                        MessageBox.Show("Por favor preencha os dados de login!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Text = "";
                        txtUser.Text = "";
                    }
                    else if (txtPass.Text == "") //txtPass vazia
                    {
                        MessageBox.Show("Campo Password vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Text = "";
                        txtUser.Text = "";
                    }
                    else if (txtUser.Text == "") //txtuser vazia
                    {
                        MessageBox.Show("Campo Utilizador vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Text = "";
                        txtUser.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Por favor verifique os dados de login!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Text = "";
                        txtUser.Text = "";
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao fazer o login \n" + ex.Message);
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    MessageBox.Show("Conexão efetuada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar \n" + ex.Message);
            }
        }

    }
}
