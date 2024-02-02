namespace ProjetoSistema.Views
{
    partial class frmPesquisaProd
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.ambarDataSet = new ProjetoSistema.AmbarDataSet();
            this.cadProBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadProTableAdapter = new ProjetoSistema.AmbarDataSetTableAdapters.CadProTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnInf = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesquisarDescri = new System.Windows.Forms.Button();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProBindingSource)).BeginInit();
            this.pnInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtCod);
            this.panel2.Controls.Add(this.btnPesquisarProd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 34);
            this.panel2.TabIndex = 3;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCod.Location = new System.Drawing.Point(87, 0);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(194, 32);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 25);
            this.panel1.TabIndex = 8;
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
            this.label1.Text = "Pesquisa de Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.btnPesquisarDescri);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(338, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 34);
            this.panel3.TabIndex = 9;
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
            // dtgProdutos
            // 
            this.dtgProdutos.AutoGenerateColumns = false;
            this.dtgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.vlrVendaDataGridViewTextBoxColumn,
            this.vlrCustoDataGridViewTextBoxColumn,
            this.vlrCompraDataGridViewTextBoxColumn,
            this.gtinDataGridViewTextBoxColumn,
            this.cstDataGridViewTextBoxColumn,
            this.ncmDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.dtgProdutos.DataSource = this.cadProBindingSource;
            this.dtgProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProdutos.GridColor = System.Drawing.SystemColors.Control;
            this.dtgProdutos.Location = new System.Drawing.Point(4, 87);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.Size = new System.Drawing.Size(806, 348);
            this.dtgProdutos.TabIndex = 10;
            // 
            // ambarDataSet
            // 
            this.ambarDataSet.DataSetName = "AmbarDataSet";
            this.ambarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadProBindingSource
            // 
            this.cadProBindingSource.DataMember = "CadPro";
            this.cadProBindingSource.DataSource = this.ambarDataSet;
            // 
            // cadProTableAdapter
            // 
            this.cadProTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // vlrVendaDataGridViewTextBoxColumn
            // 
            this.vlrVendaDataGridViewTextBoxColumn.DataPropertyName = "VlrVenda";
            this.vlrVendaDataGridViewTextBoxColumn.HeaderText = "VlrVenda";
            this.vlrVendaDataGridViewTextBoxColumn.Name = "vlrVendaDataGridViewTextBoxColumn";
            // 
            // vlrCustoDataGridViewTextBoxColumn
            // 
            this.vlrCustoDataGridViewTextBoxColumn.DataPropertyName = "VlrCusto";
            this.vlrCustoDataGridViewTextBoxColumn.HeaderText = "VlrCusto";
            this.vlrCustoDataGridViewTextBoxColumn.Name = "vlrCustoDataGridViewTextBoxColumn";
            // 
            // vlrCompraDataGridViewTextBoxColumn
            // 
            this.vlrCompraDataGridViewTextBoxColumn.DataPropertyName = "VlrCompra";
            this.vlrCompraDataGridViewTextBoxColumn.HeaderText = "VlrCompra";
            this.vlrCompraDataGridViewTextBoxColumn.Name = "vlrCompraDataGridViewTextBoxColumn";
            // 
            // gtinDataGridViewTextBoxColumn
            // 
            this.gtinDataGridViewTextBoxColumn.DataPropertyName = "gtin";
            this.gtinDataGridViewTextBoxColumn.HeaderText = "gtin";
            this.gtinDataGridViewTextBoxColumn.Name = "gtinDataGridViewTextBoxColumn";
            // 
            // cstDataGridViewTextBoxColumn
            // 
            this.cstDataGridViewTextBoxColumn.DataPropertyName = "cst";
            this.cstDataGridViewTextBoxColumn.HeaderText = "cst";
            this.cstDataGridViewTextBoxColumn.Name = "cstDataGridViewTextBoxColumn";
            // 
            // ncmDataGridViewTextBoxColumn
            // 
            this.ncmDataGridViewTextBoxColumn.DataPropertyName = "ncm";
            this.ncmDataGridViewTextBoxColumn.HeaderText = "ncm";
            this.ncmDataGridViewTextBoxColumn.Name = "ncmDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            // 
            // pnInf
            // 
            this.pnInf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.pnInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInf.Controls.Add(this.btnConfirmar);
            this.pnInf.Location = new System.Drawing.Point(4, 430);
            this.pnInf.Name = "pnInf";
            this.pnInf.Size = new System.Drawing.Size(806, 32);
            this.pnInf.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackgroundImage = global::ProjetoSistema.Properties.Resources.btnConfirmar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(683, -2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 31);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarDescri
            // 
            this.btnPesquisarDescri.BackgroundImage = global::ProjetoSistema.Properties.Resources.ImagemPesquisa;
            this.btnPesquisarDescri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarDescri.Enabled = false;
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
            this.btnPesquisarProd.Enabled = false;
            this.btnPesquisarProd.Location = new System.Drawing.Point(279, -2);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(41, 36);
            this.btnPesquisarProd.TabIndex = 1;
            this.btnPesquisarProd.UseVisualStyleBackColor = true;
            this.btnPesquisarProd.Click += new System.EventHandler(this.btnPesquisarProd_Click);
            // 
            // frmPesquisaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(807, 463);
            this.Controls.Add(this.pnInf);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPesquisaProd";
            this.Text = "Pesquisa de produtos";
            this.Load += new System.EventHandler(this.frmPesquisaProd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProBindingSource)).EndInit();
            this.pnInf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisarDescri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private AmbarDataSet ambarDataSet;
        private System.Windows.Forms.BindingSource cadProBindingSource;
        private AmbarDataSetTableAdapters.CadProTableAdapter cadProTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel pnInf;
        private System.Windows.Forms.Button btnConfirmar;
    }
}