using ProjetoSistema.Class;
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
            
                Querry.FillarDataGrield(txtCod,dtgProdutos,"ID");
            
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length >= 1) { btnPesquisarProd.Enabled = true; btnPesquisarDescri.Enabled = false; txtDescricao.Enabled = false; txtDescricao.Text = ""; }
            else { btnPesquisarProd.Enabled = false; btnPesquisarDescri.Enabled = true; txtDescricao.Enabled = true;txtCod.Enabled = true; }
        }

        private void btnPesquisarDescri_Click(object sender, EventArgs e)
        {
            Querry.FillarDataGrield(txtDescricao, dtgProdutos, "DESCRICAO");
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length >= 1) { btnPesquisarDescri.Enabled = true; btnPesquisarProd.Enabled = false; txtCod.Enabled = false; txtCod.Text = ""; }
            else { btnPesquisarDescri.Enabled = false; btnPesquisarProd.Enabled = true; txtDescricao.Enabled = true;txtCod.Enabled = true; }
        }
    }
}
