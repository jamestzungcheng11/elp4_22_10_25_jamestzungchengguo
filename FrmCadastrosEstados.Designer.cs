namespace PaisesEstadosCidades
{
    partial class FrmCadastrosEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(147, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(150, 27);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 0;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(276, 9);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(25, 16);
            this.lbluf.TabIndex = 12;
            this.lbluf.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(279, 28);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(49, 22);
            this.txtUF.TabIndex = 1;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(419, 9);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoPais.TabIndex = 14;
            this.lblCodigoPais.Text = "Codigo";
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(422, 28);
            this.txtCodPais.MaxLength = 5;
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(100, 22);
            this.txtCodPais.TabIndex = 2;
            this.txtCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(538, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 16;
            this.lblPais.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(541, 28);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(647, 28);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmCadastrosEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Name = "FrmCadastrosEstados";
            this.Text = "Cadastros Estados";
            this.Load += new System.EventHandler(this.FrmCadastrosEstados_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.lbluf, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button BtnBuscar;
        protected System.Windows.Forms.TextBox txtCodPais;
        protected System.Windows.Forms.TextBox txtPais;
    }
}
