
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ltbListaProdutos = new System.Windows.Forms.ListBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbListarItens = new System.Windows.Forms.ComboBox();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.lblTestarPessoa = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblNumCartao = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblMostrarDocumento = new System.Windows.Forms.Label();
            this.lblMostrarNumDocumento = new System.Windows.Forms.Label();
            this.mtbNumCartao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCarregar
            // 
            resources.ApplyResources(this.btnCarregar, "btnCarregar");
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ltbListaProdutos
            // 
            resources.ApplyResources(this.ltbListaProdutos, "ltbListaProdutos");
            this.ltbListaProdutos.FormattingEnabled = true;
            this.ltbListaProdutos.Name = "ltbListaProdutos";
            // 
            // cmbProdutos
            // 
            resources.ApplyResources(this.cmbProdutos, "cmbProdutos");
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Name = "cmbProdutos";
            // 
            // lblProdutos
            // 
            resources.ApplyResources(this.lblProdutos, "lblProdutos");
            this.lblProdutos.Name = "lblProdutos";
            // 
            // lblListaProdutos
            // 
            resources.ApplyResources(this.lblListaProdutos, "lblListaProdutos");
            this.lblListaProdutos.Name = "lblListaProdutos";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbListarItens
            // 
            resources.ApplyResources(this.cmbListarItens, "cmbListarItens");
            this.cmbListarItens.FormattingEnabled = true;
            this.cmbListarItens.Items.AddRange(new object[] {
            resources.GetString("cmbListarItens.Items")});
            this.cmbListarItens.Name = "cmbListarItens";
            this.cmbListarItens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbListarItens_MouseClick);
            // 
            // btnTestarPessoa
            // 
            resources.ApplyResources(this.btnTestarPessoa, "btnTestarPessoa");
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.btnTestarPessoa_Click);
            // 
            // lblTestarPessoa
            // 
            resources.ApplyResources(this.lblTestarPessoa, "lblTestarPessoa");
            this.lblTestarPessoa.Name = "lblTestarPessoa";
            // 
            // btnReservar
            // 
            resources.ApplyResources(this.btnReservar, "btnReservar");
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblNumCartao
            // 
            resources.ApplyResources(this.lblNumCartao, "lblNumCartao");
            this.lblNumCartao.Name = "lblNumCartao";
            // 
            // lblDocumento
            // 
            resources.ApplyResources(this.lblDocumento, "lblDocumento");
            this.lblDocumento.Name = "lblDocumento";
            // 
            // txtDocumento
            // 
            resources.ApplyResources(this.txtDocumento, "txtDocumento");
            this.txtDocumento.Name = "txtDocumento";
            // 
            // lblMostrarDocumento
            // 
            resources.ApplyResources(this.lblMostrarDocumento, "lblMostrarDocumento");
            this.lblMostrarDocumento.Name = "lblMostrarDocumento";
            // 
            // lblMostrarNumDocumento
            // 
            resources.ApplyResources(this.lblMostrarNumDocumento, "lblMostrarNumDocumento");
            this.lblMostrarNumDocumento.Name = "lblMostrarNumDocumento";
            // 
            // mtbNumCartao
            // 
            resources.ApplyResources(this.mtbNumCartao, "mtbNumCartao");
            this.mtbNumCartao.Name = "mtbNumCartao";
            // 
            // frmListarProdutos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbNumCartao);
            this.Controls.Add(this.lblMostrarDocumento);
            this.Controls.Add(this.lblMostrarNumDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNumCartao);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblTestarPessoa);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbListarItens);
            this.Controls.Add(this.lblListaProdutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.ltbListaProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmListarProdutos";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox ltbListaProdutos;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListarItens;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Label lblTestarPessoa;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblNumCartao;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblMostrarDocumento;
        private System.Windows.Forms.Label lblMostrarNumDocumento;
        private System.Windows.Forms.MaskedTextBox mtbNumCartao;
    }
}