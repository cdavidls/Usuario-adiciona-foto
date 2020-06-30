namespace UsuarioAdicionaFoto
{
    partial class Form1
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
            this.PtbFoto = new System.Windows.Forms.PictureBox();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtNomeArquivo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbFoto
            // 
            this.PtbFoto.Location = new System.Drawing.Point(58, 66);
            this.PtbFoto.Name = "PtbFoto";
            this.PtbFoto.Size = new System.Drawing.Size(160, 177);
            this.PtbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbFoto.TabIndex = 0;
            this.PtbFoto.TabStop = false;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(76, 249);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(120, 42);
            this.BtnAbrir.TabIndex = 1;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtNomeArquivo
            // 
            this.TxtNomeArquivo.Location = new System.Drawing.Point(69, 40);
            this.TxtNomeArquivo.Name = "TxtNomeArquivo";
            this.TxtNomeArquivo.Size = new System.Drawing.Size(136, 20);
            this.TxtNomeArquivo.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 365);
            this.Controls.Add(this.TxtNomeArquivo);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.PtbFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbFoto;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtNomeArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

