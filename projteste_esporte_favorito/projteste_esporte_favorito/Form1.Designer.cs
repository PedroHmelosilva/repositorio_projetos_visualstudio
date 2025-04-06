
namespace projteste_esporte_favorito
{
    partial class frmMsg
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEsporte = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEsporte = new System.Windows.Forms.TextBox();
            this.bntExecutar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(78, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(152, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // lblEsporte
            // 
            this.lblEsporte.AutoSize = true;
            this.lblEsporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsporte.Location = new System.Drawing.Point(290, 19);
            this.lblEsporte.Name = "lblEsporte";
            this.lblEsporte.Size = new System.Drawing.Size(260, 24);
            this.lblEsporte.TabIndex = 1;
            this.lblEsporte.Text = "Qual é o seu esporte favorito?";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEsporte
            // 
            this.txtEsporte.Location = new System.Drawing.Point(294, 46);
            this.txtEsporte.Name = "txtEsporte";
            this.txtEsporte.Size = new System.Drawing.Size(256, 20);
            this.txtEsporte.TabIndex = 3;
            // 
            // bntExecutar
            // 
            this.bntExecutar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntExecutar.Location = new System.Drawing.Point(141, 115);
            this.bntExecutar.Name = "bntExecutar";
            this.bntExecutar.Size = new System.Drawing.Size(89, 40);
            this.bntExecutar.TabIndex = 4;
            this.bntExecutar.Text = "Executar";
            this.bntExecutar.UseVisualStyleBackColor = false;
            this.bntExecutar.Click += new System.EventHandler(this.bntExecutar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Location = new System.Drawing.Point(250, 115);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 40);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(348, 115);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 40);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(607, 175);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntExecutar);
            this.Controls.Add(this.txtEsporte);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEsporte);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMsg";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEsporte;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEsporte;
        private System.Windows.Forms.Button bntExecutar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

