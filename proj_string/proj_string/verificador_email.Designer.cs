
namespace proj_string
{
    partial class verificador_email
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exibir_vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mover_textos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.verificar_arroba = new System.Windows.Forms.Button();
            this.verificar_usuario = new System.Windows.Forms.Button();
            this.verificar_provedor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.manipulaçãoDeStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exibir_vertical,
            this.menu_mover_textos,
            this.manipulaçãoDeStringToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menu_exibir_vertical
            // 
            this.menu_exibir_vertical.Name = "menu_exibir_vertical";
            this.menu_exibir_vertical.Size = new System.Drawing.Size(326, 28);
            this.menu_exibir_vertical.Text = "Exibir a palavra na vertical";
            this.menu_exibir_vertical.Click += new System.EventHandler(this.menu_exibir_vertical_Click);
            // 
            // menu_mover_textos
            // 
            this.menu_mover_textos.Name = "menu_mover_textos";
            this.menu_mover_textos.Size = new System.Drawing.Size(326, 28);
            this.menu_mover_textos.Text = "Mover textos entre listas";
            this.menu_mover_textos.Click += new System.EventHandler(this.menu_mover_textos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail: ";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(96, 51);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(255, 29);
            this.txt_email.TabIndex = 2;
            // 
            // verificar_arroba
            // 
            this.verificar_arroba.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_arroba.Location = new System.Drawing.Point(79, 116);
            this.verificar_arroba.Name = "verificar_arroba";
            this.verificar_arroba.Size = new System.Drawing.Size(210, 32);
            this.verificar_arroba.TabIndex = 3;
            this.verificar_arroba.Text = "Verificar @";
            this.verificar_arroba.UseVisualStyleBackColor = true;
            this.verificar_arroba.Click += new System.EventHandler(this.verificar_arroba_Click);
            // 
            // verificar_usuario
            // 
            this.verificar_usuario.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_usuario.Location = new System.Drawing.Point(79, 174);
            this.verificar_usuario.Name = "verificar_usuario";
            this.verificar_usuario.Size = new System.Drawing.Size(210, 32);
            this.verificar_usuario.TabIndex = 4;
            this.verificar_usuario.Text = "Verificar usuário";
            this.verificar_usuario.UseVisualStyleBackColor = true;
            this.verificar_usuario.Click += new System.EventHandler(this.verificar_usuario_Click);
            // 
            // verificar_provedor
            // 
            this.verificar_provedor.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_provedor.Location = new System.Drawing.Point(79, 230);
            this.verificar_provedor.Name = "verificar_provedor";
            this.verificar_provedor.Size = new System.Drawing.Size(210, 32);
            this.verificar_provedor.TabIndex = 5;
            this.verificar_provedor.Text = "Verificar provedor";
            this.verificar_provedor.UseVisualStyleBackColor = true;
            this.verificar_provedor.Click += new System.EventHandler(this.verificar_provedor_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(254, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(16, 281);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(107, 32);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(373, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.Text = "Nicolas de Oliveira Silva";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel2.Text = "Pedro Henrique Melo E Silva";
            // 
            // manipulaçãoDeStringToolStripMenuItem
            // 
            this.manipulaçãoDeStringToolStripMenuItem.Name = "manipulaçãoDeStringToolStripMenuItem";
            this.manipulaçãoDeStringToolStripMenuItem.Size = new System.Drawing.Size(326, 28);
            this.manipulaçãoDeStringToolStripMenuItem.Text = "Manipulação de String";
            this.manipulaçãoDeStringToolStripMenuItem.Click += new System.EventHandler(this.manipulaçãoDeStringToolStripMenuItem_Click);
            // 
            // verificador_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(373, 344);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.verificar_provedor);
            this.Controls.Add(this.verificar_usuario);
            this.Controls.Add(this.verificar_arroba);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "verificador_email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verificador_email";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_exibir_vertical;
        private System.Windows.Forms.ToolStripMenuItem menu_mover_textos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button verificar_arroba;
        private System.Windows.Forms.Button verificar_usuario;
        private System.Windows.Forms.Button verificar_provedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem manipulaçãoDeStringToolStripMenuItem;
    }
}