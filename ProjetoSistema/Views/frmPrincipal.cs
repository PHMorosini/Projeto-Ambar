using ProjetoSistema.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoSistema
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDropCad_MouseEnter(object sender, EventArgs e)
        {
            pnCad.Visible = true;

        }

        private void pnCad_MouseEnter(object sender, EventArgs e)
        {
            pnCad.Visible = true;

        }
        private void pnCad_MouseLeave(object sender, EventArgs e)
        {
            pnCad.Visible = false;

        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pnCad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAbrirCadPro_Click(object sender, EventArgs e)
        {
            frmCadPro Abrir = new frmCadPro();
            Abrir.Show();

        }
    }
}
