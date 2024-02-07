using ProjetoSistema.Class;
using ProjetoSistema.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema.Views
{

    public partial class frmPesquisaProd : Form
    {
        private string id;
        private string descricao;
        private string VlrVenda;
        private string VlrCusto;
        private string VlrCompra;
        private string Gtin;
        private string Cst;
        private string Ncm;
        private bool Ativo;

        public frmPesquisaProd()
        {
            InitializeComponent();
        }

        private void frmPesquisaProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ambarDataSet.CadPro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProTableAdapter.Fill(this.ambarDataSet.CadPro);

        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            
                Querry.PesquisarNaGrid(txtCod,dtgProdutos,"ID");
            
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length >= 1) { btnPesquisarProd.Enabled = true; btnPesquisarDescri.Enabled = false; txtDescricao.Enabled = false; txtDescricao.Text = ""; }
            else { btnPesquisarProd.Enabled = false; btnPesquisarDescri.Enabled = true; txtDescricao.Enabled = true;txtCod.Enabled = true; }
        }

        private void btnPesquisarDescri_Click(object sender, EventArgs e)
        {
            Querry.PesquisarnaGrid(txtDescricao, dtgProdutos, "DESCRICAO");
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length >= 1) { btnPesquisarDescri.Enabled = true; btnPesquisarProd.Enabled = false; txtCod.Enabled = false; txtCod.Text = ""; }
            else { btnPesquisarDescri.Enabled = false; btnPesquisarProd.Enabled = true; txtDescricao.Enabled = true;txtCod.Enabled = true; }
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmCadPro cadPro = new frmCadPro(id,descricao,VlrVenda,VlrCusto,VlrCompra,Cst,Gtin,Ncm,Ativo);
            cadPro.Show();
            this.Close();
            
        }

        private void dtgProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgProdutos.SelectedRows[0];
                id = row.Cells[0].Value.ToString(); 
                descricao = row.Cells[1].Value.ToString();
                VlrVenda = row.Cells[2].Value.ToString();
                VlrCusto = row.Cells[3].Value.ToString();
                VlrCompra = row.Cells[4].Value.ToString();
                Gtin = row.Cells[5].Value.ToString();
                Cst = row.Cells[6].Value.ToString();
                Ncm = row.Cells[7].Value.ToString();
                Ativo = bool.Parse( row.Cells[8].Value.ToString());

            }
        }
        
    }
}
