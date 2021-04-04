namespace CRUD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Entrar = new System.Windows.Forms.PictureBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_Sair = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pic_Entrar);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(422, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 154);
            this.panel1.TabIndex = 3;
            // 
            // pic_Entrar
            // 
            this.pic_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Entrar.BackgroundImage")));
            this.pic_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Entrar.Location = new System.Drawing.Point(157, 106);
            this.pic_Entrar.Name = "pic_Entrar";
            this.pic_Entrar.Size = new System.Drawing.Size(123, 36);
            this.pic_Entrar.TabIndex = 3;
            this.pic_Entrar.TabStop = false;
            this.pic_Entrar.Tag = "";
            this.pic_Entrar.Click += new System.EventHandler(this.pic_Entrar_Click);
            this.pic_Entrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Entrar_MouseDown);
            this.pic_Entrar.MouseEnter += new System.EventHandler(this.pic_Entrar_MouseEnter);
            this.pic_Entrar.MouseLeave += new System.EventHandler(this.pic_Entrar_MouseLeave);
            this.pic_Entrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Entrar_MouseUp);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(104, 59);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(176, 30);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.Enter += new System.EventHandler(this.txt_Senha_Enter);
            this.txt_Senha.Leave += new System.EventHandler(this.txt_Senha_Leave);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(104, 21);
            this.txt_Usuario.MaxLength = 8;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(176, 30);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "SENHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "USUÁRIO";
            // 
            // pic_Sair
            // 
            this.pic_Sair.BackColor = System.Drawing.Color.Transparent;
            this.pic_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Sair.BackgroundImage")));
            this.pic_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Sair.Location = new System.Drawing.Point(665, 393);
            this.pic_Sair.Name = "pic_Sair";
            this.pic_Sair.Size = new System.Drawing.Size(123, 36);
            this.pic_Sair.TabIndex = 3;
            this.pic_Sair.TabStop = false;
            this.pic_Sair.Tag = "";
            this.pic_Sair.Click += new System.EventHandler(this.pic_Sair_Click);
            this.pic_Sair.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseDown);
            this.pic_Sair.MouseEnter += new System.EventHandler(this.pic_Sair_MouseEnter);
            this.pic_Sair.MouseLeave += new System.EventHandler(this.pic_Sair_MouseLeave);
            this.pic_Sair.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(518, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login Teste -> User: admin - Senha: admin";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Sair);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.PictureBox pic_Entrar;
        private System.Windows.Forms.PictureBox pic_Sair;
        private System.Windows.Forms.Label label1;
    }
}

