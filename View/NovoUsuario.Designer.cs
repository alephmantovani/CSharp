namespace CRUD.View
{
    partial class NovoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ConfirmeSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pic_Salvar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Salvar);
            this.panel1.Controls.Add(this.txt_ConfirmeSenha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 199);
            this.panel1.TabIndex = 0;
            // 
            // txt_ConfirmeSenha
            // 
            this.txt_ConfirmeSenha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmeSenha.Location = new System.Drawing.Point(199, 98);
            this.txt_ConfirmeSenha.Name = "txt_ConfirmeSenha";
            this.txt_ConfirmeSenha.PasswordChar = '*';
            this.txt_ConfirmeSenha.Size = new System.Drawing.Size(176, 30);
            this.txt_ConfirmeSenha.TabIndex = 13;
            this.txt_ConfirmeSenha.Enter += new System.EventHandler(this.txt_ConfirmeSenha_Enter);
            this.txt_ConfirmeSenha.Leave += new System.EventHandler(this.txt_ConfirmeSenha_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "CONFIRME A SENHA";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(199, 52);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(176, 30);
            this.txt_Senha.TabIndex = 11;
            this.txt_Senha.Enter += new System.EventHandler(this.txt_Senha_Enter);
            this.txt_Senha.Leave += new System.EventHandler(this.txt_Senha_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(72, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOVA SENHA";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(199, 7);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(176, 30);
            this.txt_Usuario.TabIndex = 9;
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            this.txt_Usuario.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Usuario_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOVO USUÁRIO";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pic_Salvar
            // 
            this.pic_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Salvar.BackgroundImage")));
            this.pic_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Salvar.Location = new System.Drawing.Point(252, 150);
            this.pic_Salvar.Name = "pic_Salvar";
            this.pic_Salvar.Size = new System.Drawing.Size(123, 36);
            this.pic_Salvar.TabIndex = 14;
            this.pic_Salvar.TabStop = false;
            this.pic_Salvar.Tag = "";
            this.pic_Salvar.Click += new System.EventHandler(this.pic_Salvar_Click);
            this.pic_Salvar.MouseEnter += new System.EventHandler(this.pic_Salvar_MouseEnter);
            this.pic_Salvar.MouseLeave += new System.EventHandler(this.pic_Salvar_MouseLeave);
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 223);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_ConfirmeSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pic_Salvar;
    }
}