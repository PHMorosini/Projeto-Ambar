using ProjetoSistema.Class;
using ProjetoSistema.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoSistema.Views
{
    public partial class frmCadPro : Form
    {
        private Produto produto;
        public frmCadPro(int id, string descricao, decimal VlrVenda, decimal VlrCusto, decimal VlrCompra, string Gtin, string Cst, string Ncm, bool Ativo)
        {
            bool ativo;
            ativo = Ativo;
            InitializeComponent();
            produto = new Produto
            {
                Id = id,
                Descricao = descricao,
                ValorVenda = VlrVenda,
                ValorCusto = VlrCusto,
                ValorCompra = VlrCompra,
                GTIN = Gtin,
                CST = Cst,
                NCM = Ncm,
                Ativo = ativo
            };

            // Exibir informações do produto nos controles do formulário
            
            
            txtCod.Text = produto.Id.ToString();
            txtDescricao.Text = produto.Descricao;
            txtValorVenda.Text = produto.ValorVenda.ToString();
            txtValorCusto.Text = produto.ValorCusto.ToString();
            txtValorCompra.Text = produto.ValorCompra.ToString();
            txtGtin.Text = produto.GTIN;
            txtCst.Text = produto.CST;
            txtNcm.Text = produto.NCM;
            Ativo = ativo;


            if (Ativo == false) { btnRestaurar.Enabled = true; btnRestaurar.Visible = true; btnExcluir.Enabled = false; btnExcluir.Visible = false; }
            else { btnRestaurar.Enabled = false; btnRestaurar.Visible = false; btnExcluir.Enabled = true; btnExcluir.Visible = true; }
        }
        public frmCadPro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCod.Text.Length < 1)
                {
                    string Descricao = txtDescricao.Text;
                    decimal VlrVenda = decimal.Parse(txtValorVenda.Text.TrocarPontoPorVirgula());
                    decimal VlrCompra = decimal.Parse(txtValorCompra.Text.TrocarPontoPorVirgula());
                    decimal VlrCusto = decimal.Parse(txtValorCusto.Text.TrocarPontoPorVirgula());
                    string Cst = txtCst.Text;
                    string Ncm = txtNcm.Text;
                    string Gtin = txtGtin.Text;

                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        var Sql = "INSERT INTO CADPRO (DESCRICAO,VLRVENDA,VLRCOMPRA,VLRCUSTO,CST,NCM,GTIN,ATIVO) VALUES (@Descricao,@VlrVenda,@VlrCompra,@VlrCusto,@Cst,@Ncm,@Gtin,'1')";

                        using (SqlCommand Add = new SqlCommand(Sql, cn))
                        {

                            Add.Parameters.AddWithValue("@Descricao", Descricao);
                            Add.Parameters.AddWithValue("@VlrVenda", VlrVenda);
                            Add.Parameters.AddWithValue("@VlrCompra", VlrCompra);
                            Add.Parameters.AddWithValue("@VlrCusto", VlrCusto);
                            Add.Parameters.AddWithValue("@Cst", Cst);
                            Add.Parameters.AddWithValue("@Ncm", Ncm);
                            Add.Parameters.AddWithValue("@Gtin", Gtin);

                            Add.ExecuteNonQuery();
                            MessageBox.Show("Produto cadastrado com sucesso");

                            txtDescricao.Text = "";
                            txtValorVenda.Text = "";
                            txtValorCusto.Text = "";
                            txtValorCompra.Text = "";
                            txtGtin.Text = "";
                            txtNcm.Text = "";
                            txtCst.Text = "";

                        }
                    }
                }
                else
                {
                    if (produto.Ativo == false)
                    {
                        MessageBox.Show("Não é possivel modificar produtos inativos.");
                    }
                    else
                    {
                        AttCadastros.UpdateCadastro("CADPRO", "DESCRICAO", txtDescricao.Text, "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "VlrVenda", txtValorVenda.Text.TrocarVirgulaPorPonto(), "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "VlrCusto", txtValorCusto.Text.TrocarVirgulaPorPonto(), "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "VlrCompra", txtValorCompra.Text.TrocarVirgulaPorPonto(), "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "GTIN", txtGtin.Text, "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "Cst", txtCst.Text, "ID", txtCod.Text);
                        AttCadastros.UpdateCadastro("CADPRO", "Ncm", txtNcm.Text, "ID", txtCod.Text);

                        MessageBox.Show("Produto atualizado com sucesso");
                        txtDescricao.Text = "";
                        txtValorVenda.Text = "";
                        txtValorCusto.Text = "";
                        txtValorCompra.Text = "";
                        txtGtin.Text = "";
                        txtNcm.Text = "";
                        txtCst.Text = "";
                        txtCod.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto {ex.Message}");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtDescricao.Text = "";
            txtValorVenda.Text = "";
            txtValorCusto.Text = "";
            txtValorCompra.Text = "";
            txtGtin.Text = "";
            txtNcm.Text = "";
            txtCst.Text = "";

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.Text.ObservadorParaMaiusculo(txtDescricao);
        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            frmPesquisaProd frmPesquisaProd = new frmPesquisaProd();
            frmPesquisaProd.Show();
            this.Close();
        }

        private void btnPesquisarDescri_Click(object sender, EventArgs e)
        {
            frmPesquisaProd p = new frmPesquisaProd();
            p.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AttCadastros.ExcluirEntidade("CADPRO", txtCod);
            btnRestaurar.Enabled = true; btnRestaurar.Visible = true; btnExcluir.Enabled = false; btnExcluir.Visible = false;

            produto.Ativo = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            AttCadastros.RestaurarEntidade("CADPRO", txtCod);
            btnRestaurar.Enabled = false; btnRestaurar.Visible = false; btnExcluir.Enabled = true; btnExcluir.Visible = true;

            produto.Ativo = true;
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValorVenda.Text.TrocarVirgulaPorPonto();
            txtValorVenda.Text.SoNumeroComPontoEVirgula(txtValorVenda, e);
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValorCompra.Text.TrocarVirgulaPorPonto();
            txtValorCompra.Text.SoNumeroComPontoEVirgula(txtValorCompra, e);
        }

        private void txtValorCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValorCusto.Text.TrocarVirgulaPorPonto();
            txtValorCusto.Text.SoNumeroComPontoEVirgula(txtValorCusto, e);
        }

        private void txtNcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNcm.Text.SoNumero(txtNcm, e);
        }

        private void txtCst_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCst.Text.SoNumero(txtCst, e);
        }
    }
}
