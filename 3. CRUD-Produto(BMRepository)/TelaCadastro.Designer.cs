namespace EstoqueMercado
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.AoClicarSalvar = new System.Windows.Forms.Button();
            this.AoClicarCancelar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.label3.Location = new System.Drawing.Point(23, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.label4.Location = new System.Drawing.Point(23, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Vencimento";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(187, 98);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(293, 22);
            this.txtMarca.TabIndex = 5;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(187, 159);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(293, 22);
            this.txtCodigoBarras.TabIndex = 6;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataVencimento.Location = new System.Drawing.Point(187, 219);
            this.DataVencimento.Margin = new System.Windows.Forms.Padding(4);
            this.DataVencimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DataVencimento.MinDate = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Size = new System.Drawing.Size(141, 22);
            this.DataVencimento.TabIndex = 7;
            this.DataVencimento.Value = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            // 
            // AoClicarSalvar
            // 
            this.AoClicarSalvar.Location = new System.Drawing.Point(27, 294);
            this.AoClicarSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.AoClicarSalvar.Name = "AoClicarSalvar";
            this.AoClicarSalvar.Size = new System.Drawing.Size(135, 28);
            this.AoClicarSalvar.TabIndex = 8;
            this.AoClicarSalvar.Text = "Salvar";
            this.AoClicarSalvar.UseVisualStyleBackColor = true;
            this.AoClicarSalvar.Click += new System.EventHandler(this.AoClicarEmSalvar);
            // 
            // AoClicarCancelar
            // 
            this.AoClicarCancelar.Location = new System.Drawing.Point(187, 294);
            this.AoClicarCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.AoClicarCancelar.Name = "AoClicarCancelar";
            this.AoClicarCancelar.Size = new System.Drawing.Size(143, 28);
            this.AoClicarCancelar.TabIndex = 9;
            this.AoClicarCancelar.Text = "Cancelar";
            this.AoClicarCancelar.UseVisualStyleBackColor = true;
            this.AoClicarCancelar.Click += new System.EventHandler(this.AoClicarEmCancelar);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(187, 42);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(293, 22);
            this.txtNomeProduto.TabIndex = 10;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 352);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.AoClicarCancelar);
            this.Controls.Add(this.AoClicarSalvar);
            this.Controls.Add(this.DataVencimento);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaCadastro";
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AoClicarSalvar;
        private System.Windows.Forms.Button AoClicarCancelar;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtCodigoBarras;
        public System.Windows.Forms.DateTimePicker DataVencimento;
        private System.Windows.Forms.TextBox txtNomeProduto;
    }
}