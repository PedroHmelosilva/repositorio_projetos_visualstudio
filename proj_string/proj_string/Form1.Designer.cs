
namespace proj_string
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exibir_vertical = new System.Windows.Forms.Button();
            this.mover_textos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manipulação de String";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Verificador de E-mail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exibir_vertical
            // 
            this.exibir_vertical.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibir_vertical.Location = new System.Drawing.Point(17, 168);
            this.exibir_vertical.Name = "exibir_vertical";
            this.exibir_vertical.Size = new System.Drawing.Size(283, 40);
            this.exibir_vertical.TabIndex = 3;
            this.exibir_vertical.Text = "Exibir a palavra na vertical";
            this.exibir_vertical.UseVisualStyleBackColor = true;
            this.exibir_vertical.Click += new System.EventHandler(this.exibir_vertical_Click);
            // 
            // mover_textos
            // 
            this.mover_textos.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover_textos.Location = new System.Drawing.Point(17, 244);
            this.mover_textos.Name = "mover_textos";
            this.mover_textos.Size = new System.Drawing.Size(283, 40);
            this.mover_textos.TabIndex = 4;
            this.mover_textos.Text = "Mover textos entre listas";
            this.mover_textos.UseVisualStyleBackColor = true;
            this.mover_textos.Click += new System.EventHandler(this.mover_textos_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Manipulação de String";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mover_textos);
            this.Controls.Add(this.exibir_vertical);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exibir_vertical;
        private System.Windows.Forms.Button mover_textos;
        private System.Windows.Forms.Button button3;
    }
}

