namespace EstoqueMercado
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            this.AoClicarDeletar = new System.Windows.Forms.Button();
            this.AoClicarEditar = new System.Windows.Forms.Button();
            this.AoClicarOK = new System.Windows.Forms.Button();
            this.AoClicarNovo = new System.Windows.Forms.Button();
            this.dataSet = new EstoqueMercado.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUD_PRODUTODataSet = new EstoqueMercado.CRUD_PRODUTODataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new EstoqueMercado.CRUD_PRODUTODataSetTableAdapters.ProdutosTableAdapter();
            this.cRUD_PRODUTODataSet1 = new EstoqueMercado.CRUD_PRODUTODataSet1();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter1 = new EstoqueMercado.CRUD_PRODUTODataSet1TableAdapters.ProdutosTableAdapter();
            this.DataGrid_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PRODUTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PRODUTODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // AoClicarDeletar
            // 
            this.AoClicarDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AoClicarDeletar.Location = new System.Drawing.Point(239, 344);
            this.AoClicarDeletar.Name = "AoClicarDeletar";
            this.AoClicarDeletar.Size = new System.Drawing.Size(109, 23);
            this.AoClicarDeletar.TabIndex = 4;
            this.AoClicarDeletar.Text = "Deletar";
            this.AoClicarDeletar.UseVisualStyleBackColor = true;
            this.AoClicarDeletar.Click += new System.EventHandler(this.AoClicarEmDeletar);
            // 
            // AoClicarEditar
            // 
            this.AoClicarEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AoClicarEditar.Location = new System.Drawing.Point(124, 344);
            this.AoClicarEditar.Name = "AoClicarEditar";
            this.AoClicarEditar.Size = new System.Drawing.Size(109, 23);
            this.AoClicarEditar.TabIndex = 3;
            this.AoClicarEditar.Text = "Editar";
            this.AoClicarEditar.UseVisualStyleBackColor = true;
            this.AoClicarEditar.Click += new System.EventHandler(this.AoClicarEmEditar);
            // 
            // AoClicarOK
            // 
            this.AoClicarOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AoClicarOK.Location = new System.Drawing.Point(686, 344);
            this.AoClicarOK.Name = "AoClicarOK";
            this.AoClicarOK.Size = new System.Drawing.Size(109, 23);
            this.AoClicarOK.TabIndex = 0;
            this.AoClicarOK.Text = "OK";
            this.AoClicarOK.UseVisualStyleBackColor = true;
            this.AoClicarOK.Click += new System.EventHandler(this.AoClicarEmOK);
            // 
            // AoClicarNovo
            // 
            this.AoClicarNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AoClicarNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AoClicarNovo.Location = new System.Drawing.Point(10, 344);
            this.AoClicarNovo.Name = "AoClicarNovo";
            this.AoClicarNovo.Size = new System.Drawing.Size(109, 23);
            this.AoClicarNovo.TabIndex = 2;
            this.AoClicarNovo.Text = "Novo";
            this.AoClicarNovo.UseVisualStyleBackColor = false;
            this.AoClicarNovo.Click += new System.EventHandler(this.AoClicarEmNovo);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // cRUD_PRODUTODataSet
            // 
            this.cRUD_PRODUTODataSet.DataSetName = "CRUD_PRODUTODataSet";
            this.cRUD_PRODUTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.cRUD_PRODUTODataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // cRUD_PRODUTODataSet1
            // 
            this.cRUD_PRODUTODataSet1.DataSetName = "CRUD_PRODUTODataSet1";
            this.cRUD_PRODUTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.cRUD_PRODUTODataSet1;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // DataGrid_ListaProdutos
            // 
            this.DataGrid_ListaProdutos.AllowUserToAddRows = false;
            this.DataGrid_ListaProdutos.AllowUserToDeleteRows = false;
            this.DataGrid_ListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_ListaProdutos.AutoGenerateColumns = false;
            this.DataGrid_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.DataGrid_ListaProdutos.DataSource = this.produtosBindingSource1;
            this.DataGrid_ListaProdutos.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_ListaProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGrid_ListaProdutos.Name = "DataGrid_ListaProdutos";
            this.DataGrid_ListaProdutos.ReadOnly = true;
            this.DataGrid_ListaProdutos.RowHeadersWidth = 51;
            this.DataGrid_ListaProdutos.RowTemplate.Height = 24;
            this.DataGrid_ListaProdutos.Size = new System.Drawing.Size(805, 338);
            this.DataGrid_ListaProdutos.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            this.codigoBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoBarrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 377);
            this.Controls.Add(this.AoClicarOK);
            this.Controls.Add(this.AoClicarDeletar);
            this.Controls.Add(this.DataGrid_ListaProdutos);
            this.Controls.Add(this.AoClicarEditar);
            this.Controls.Add(this.AoClicarNovo);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PRODUTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PRODUTODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AoClicarOK;
        private System.Windows.Forms.Button AoClicarDeletar;
        private System.Windows.Forms.Button AoClicarEditar;
        private System.Windows.Forms.Button AoClicarNovo;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DataSet dataSet;
        private CRUD_PRODUTODataSet cRUD_PRODUTODataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private CRUD_PRODUTODataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private CRUD_PRODUTODataSet1 cRUD_PRODUTODataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private CRUD_PRODUTODataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.DataGridView DataGrid_ListaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
    }
}

