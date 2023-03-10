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
            this.AoClicarDeletar = new System.Windows.Forms.Button();
            this.AoClicarEditar = new System.Windows.Forms.Button();
            this.AoClicarOK = new System.Windows.Forms.Button();
            this.AoClicarNovo = new System.Windows.Forms.Button();
            this.DataGrid_ListaProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // AoClicarDeletar
            // 
            this.AoClicarDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AoClicarDeletar.Location = new System.Drawing.Point(242, 329);
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
            this.AoClicarEditar.Location = new System.Drawing.Point(127, 329);
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
            this.AoClicarOK.Location = new System.Drawing.Point(538, 329);
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
            this.AoClicarNovo.Location = new System.Drawing.Point(12, 329);
            this.AoClicarNovo.Name = "AoClicarNovo";
            this.AoClicarNovo.Size = new System.Drawing.Size(109, 23);
            this.AoClicarNovo.TabIndex = 2;
            this.AoClicarNovo.Text = "Novo";
            this.AoClicarNovo.UseVisualStyleBackColor = false;
            this.AoClicarNovo.Click += new System.EventHandler(this.AoClicarEmNovo);
            // 
            // DataGrid_ListaProdutos
            // 
            this.DataGrid_ListaProdutos.AllowUserToAddRows = false;
            this.DataGrid_ListaProdutos.AllowUserToDeleteRows = false;
            this.DataGrid_ListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_ListaProdutos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataGrid_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListaProdutos.Location = new System.Drawing.Point(-1, 0);
            this.DataGrid_ListaProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_ListaProdutos.Name = "DataGrid_ListaProdutos";
            this.DataGrid_ListaProdutos.ReadOnly = true;
            this.DataGrid_ListaProdutos.RowHeadersWidth = 51;
            this.DataGrid_ListaProdutos.RowTemplate.Height = 24;
            this.DataGrid_ListaProdutos.Size = new System.Drawing.Size(659, 324);
            this.DataGrid_ListaProdutos.TabIndex = 5;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(659, 364);
            this.Controls.Add(this.DataGrid_ListaProdutos);
            this.Controls.Add(this.AoClicarOK);
            this.Controls.Add(this.AoClicarDeletar);
            this.Controls.Add(this.AoClicarEditar);
            this.Controls.Add(this.AoClicarNovo);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AoClicarOK;
        private System.Windows.Forms.Button AoClicarDeletar;
        private System.Windows.Forms.Button AoClicarEditar;
        private System.Windows.Forms.Button AoClicarNovo;
        private System.Windows.Forms.DataGridView DataGrid_ListaProdutos;
    }
}

