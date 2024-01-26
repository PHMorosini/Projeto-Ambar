namespace ProjetoSistema
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnDropEst = new System.Windows.Forms.Button();
            this.btnDropCad = new System.Windows.Forms.Button();
            this.pnCad = new System.Windows.Forms.Panel();
            this.BtnAbrirCadFor = new System.Windows.Forms.Button();
            this.BtnAbrirCadCli = new System.Windows.Forms.Button();
            this.BtnAbrirCadPro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.btnDropEst);
            this.panel1.Controls.Add(this.btnDropCad);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1024);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.button3.BackgroundImage = global::ProjetoSistema.Properties.Resources.Botao_configurações;
            this.button3.Location = new System.Drawing.Point(0, 665);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 53);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.BtnSearch.BackgroundImage = global::ProjetoSistema.Properties.Resources.Botao_pesquisar__1_;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.Location = new System.Drawing.Point(-1, 374);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(184, 53);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDropEst
            // 
            this.btnDropEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.btnDropEst.BackgroundImage = global::ProjetoSistema.Properties.Resources.Botao_estoque;
            this.btnDropEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDropEst.Location = new System.Drawing.Point(0, 273);
            this.btnDropEst.Name = "btnDropEst";
            this.btnDropEst.Size = new System.Drawing.Size(184, 53);
            this.btnDropEst.TabIndex = 1;
            this.btnDropEst.UseVisualStyleBackColor = false;
            this.btnDropEst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDropCad
            // 
            this.btnDropCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.btnDropCad.BackgroundImage = global::ProjetoSistema.Properties.Resources.btnCad;
            this.btnDropCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDropCad.Location = new System.Drawing.Point(-1, 187);
            this.btnDropCad.Name = "btnDropCad";
            this.btnDropCad.Size = new System.Drawing.Size(184, 63);
            this.btnDropCad.TabIndex = 0;
            this.btnDropCad.UseVisualStyleBackColor = false;
            this.btnDropCad.MouseEnter += new System.EventHandler(this.btnDropCad_MouseEnter);
            // 
            // pnCad
            // 
            this.pnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.pnCad.Controls.Add(this.BtnAbrirCadFor);
            this.pnCad.Controls.Add(this.BtnAbrirCadCli);
            this.pnCad.Controls.Add(this.BtnAbrirCadPro);
            this.pnCad.Location = new System.Drawing.Point(189, 159);
            this.pnCad.Name = "pnCad";
            this.pnCad.Size = new System.Drawing.Size(125, 104);
            this.pnCad.TabIndex = 1;
            this.pnCad.Visible = false;
            this.pnCad.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCad_Paint);
            this.pnCad.MouseEnter += new System.EventHandler(this.pnCad_MouseLeave);
            // 
            // BtnAbrirCadFor
            // 
            this.BtnAbrirCadFor.Location = new System.Drawing.Point(3, 67);
            this.BtnAbrirCadFor.Name = "BtnAbrirCadFor";
            this.BtnAbrirCadFor.Size = new System.Drawing.Size(118, 32);
            this.BtnAbrirCadFor.TabIndex = 2;
            this.BtnAbrirCadFor.Text = "Fornecedor";
            this.BtnAbrirCadFor.UseVisualStyleBackColor = true;
            // 
            // BtnAbrirCadCli
            // 
            this.BtnAbrirCadCli.Location = new System.Drawing.Point(3, 35);
            this.BtnAbrirCadCli.Name = "BtnAbrirCadCli";
            this.BtnAbrirCadCli.Size = new System.Drawing.Size(118, 32);
            this.BtnAbrirCadCli.TabIndex = 1;
            this.BtnAbrirCadCli.Text = "Cliente";
            this.BtnAbrirCadCli.UseVisualStyleBackColor = true;
            // 
            // BtnAbrirCadPro
            // 
            this.BtnAbrirCadPro.Location = new System.Drawing.Point(4, 4);
            this.BtnAbrirCadPro.Name = "BtnAbrirCadPro";
            this.BtnAbrirCadPro.Size = new System.Drawing.Size(118, 32);
            this.BtnAbrirCadPro.TabIndex = 0;
            this.BtnAbrirCadPro.Text = "Produtos";
            this.BtnAbrirCadPro.UseVisualStyleBackColor = true;
            this.BtnAbrirCadPro.Click += new System.EventHandler(this.BtnAbrirCadPro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.BackgroundImage = global::ProjetoSistema.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1424, 716);
            this.ControlBox = false;
            this.Controls.Add(this.pnCad);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Ambar";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pnCad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDropCad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnDropEst;
        private System.Windows.Forms.Panel pnCad;
        private System.Windows.Forms.Button BtnAbrirCadCli;
        private System.Windows.Forms.Button BtnAbrirCadPro;
        private System.Windows.Forms.Button BtnAbrirCadFor;
    }
}

