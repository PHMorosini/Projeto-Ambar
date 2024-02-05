using ProjetoSistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema.Views
{
    public partial class frmCadPro : Form
    {
        public frmCadPro(string id,string descricao,string vlrvenda, string vlrcusto, string vlrcompra, string gtin,string cst, string ncm, bool ativo)
        {
            InitializeComponent();

            txtCod.Text = id;
            txtDescricao.Text = descricao;
            txtValorVenda.Text= vlrvenda;
            txtValorCompra.Text = vlrcompra;
            txtValorCusto.Text = vlrcusto;
            txtGtin.Text = gtin;
            txtNcm.Text = ncm;
            txtCst.Text =cst ;
            var Ativo = ativo;
           
        }
        public frmCadPro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto {ex.Message}");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
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
        }
    }
}
