using System.Windows.Forms;

namespace ProjetoSistema.Views
{
    partial class frmCadPro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtValorCusto = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnInf = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGtin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNcm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisarDescri = new System.Windows.Forms.Button();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnInf.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 25);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtCod);
            this.panel2.Controls.Add(this.btnPesquisarProd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 34);
            this.panel2.TabIndex = 2;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCod.Location = new System.Drawing.Point(87, 0);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(194, 32);
            this.txtCod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "CÓDIGO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.btnPesquisarDescri);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(381, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 34);
            this.panel3.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescricao.Location = new System.Drawing.Point(117, 0);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(294, 32);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "DESCRIÇÃO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.panel4.Controls.Add(this.txtValorCompra);
            this.panel4.Controls.Add(this.txtValorCusto);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtValorVenda);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(22, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 121);
            this.panel4.TabIndex = 4;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(146, 45);
            this.txtValorCompra.Mask = "9999,90";
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(132, 20);
            this.txtValorCompra.TabIndex = 9;
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Location = new System.Drawing.Point(146, 78);
            this.txtValorCusto.Mask = "9999,90";
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(132, 20);
            this.txtValorCusto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "VALOR DE CUSTO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(146, 14);
            this.txtValorVenda.Mask = "9999,90";
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(132, 20);
            this.txtValorVenda.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "VALOR DE COMPRA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "VALOR DE VENDA:";
            // 
            // pnInf
            // 
            this.pnInf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.pnInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInf.Controls.Add(this.btnNovo);
            this.pnInf.Controls.Add(this.btnExcluir);
            this.pnInf.Controls.Add(this.btnGravar);
            this.pnInf.Location = new System.Drawing.Point(-1, 466);
            this.pnInf.Name = "pnInf";
            this.pnInf.Size = new System.Drawing.Size(858, 32);
            this.pnInf.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.panel5.Controls.Add(this.txtGtin);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtCst);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtNcm);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(22, 244);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 121);
            this.panel5.TabIndex = 6;
            // 
            // txtGtin
            // 
            this.txtGtin.Location = new System.Drawing.Point(48, 77);
            this.txtGtin.MaxLength = 14;
            this.txtGtin.Name = "txtGtin";
            this.txtGtin.Size = new System.Drawing.Size(132, 20);
            this.txtGtin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "GTIN:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCst
            // 
            this.txtCst.Location = new System.Drawing.Point(48, 45);
            this.txtCst.MaxLength = 4;
            this.txtCst.Name = "txtCst";
            this.txtCst.Size = new System.Drawing.Size(132, 20);
            this.txtCst.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "CST:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNcm
            // 
            this.txtNcm.Location = new System.Drawing.Point(48, 14);
            this.txtNcm.MaxLength = 8;
            this.txtNcm.Name = "txtNcm";
            this.txtNcm.Size = new System.Drawing.Size(132, 20);
            this.txtNcm.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "NCM:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackgroundImage = global::ProjetoSistema.Properties.Resources.btnNovo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(455, -2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 32);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackgroundImage = global::ProjetoSistema.Properties.Resources.btnExcluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(582, -2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 32);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackgroundImage = global::ProjetoSistema.Properties.Resources.btnSalvar;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Location = new System.Drawing.Point(709, -2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(121, 32);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisarDescri
            // 
            this.btnPesquisarDescri.BackgroundImage = global::ProjetoSistema.Properties.Resources.ImagemPesquisa;
            this.btnPesquisarDescri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarDescri.Location = new System.Drawing.Point(409, 0);
            this.btnPesquisarDescri.Name = "btnPesquisarDescri";
            this.btnPesquisarDescri.Size = new System.Drawing.Size(41, 34);
            this.btnPesquisarDescri.TabIndex = 1;
            this.btnPesquisarDescri.UseVisualStyleBackColor = true;
            this.btnPesquisarDescri.Click += new System.EventHandler(this.btnPesquisarDescri_Click);
            // 
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.BackgroundImage = global::ProjetoSistema.Properties.Resources.ImagemPesquisa;
            this.btnPesquisarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarProd.Location = new System.Drawing.Point(279, -2);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(41, 36);
            this.btnPesquisarProd.TabIndex = 1;
            this.btnPesquisarProd.UseVisualStyleBackColor = true;
            this.btnPesquisarProd.Click += new System.EventHandler(this.btnPesquisarProd_Click);
            // 
            // frmCadPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnInf);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadPro";
            this.Text = "Cadastro de produtos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnInf.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPesquisarDescri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnInf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGtin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNcm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGravar;
        private Button btnExcluir;
        private Button btnNovo;
        public TextBox txtCod;
        public TextBox txtDescricao;
        private MaskedTextBox txtValorCompra;
        private MaskedTextBox txtValorCusto;
        private MaskedTextBox txtValorVenda;
    }
}