namespace CRUD.View
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_Pass2 = new System.Windows.Forms.PictureBox();
            this.Confirmar = new System.Windows.Forms.Label();
            this.pic_Pass = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.pic_Salvar = new System.Windows.Forms.PictureBox();
            this.pic_Excluir = new System.Windows.Forms.PictureBox();
            this.lista = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuário = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pic_Sair = new System.Windows.Forms.PictureBox();
            this.pic_Inserir = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inserir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pic_Pass2);
            this.panel2.Controls.Add(this.Confirmar);
            this.panel2.Controls.Add(this.pic_Pass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_Titulo);
            this.panel2.Controls.Add(this.txt_ConfirmPass);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.txt_Senha);
            this.panel2.Controls.Add(this.txt_Usuario);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 240);
            this.panel2.TabIndex = 3;
            // 
            // pic_Pass2
            // 
            this.pic_Pass2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Pass2.BackgroundImage")));
            this.pic_Pass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Pass2.Location = new System.Drawing.Point(347, 190);
            this.pic_Pass2.Name = "pic_Pass2";
            this.pic_Pass2.Size = new System.Drawing.Size(26, 29);
            this.pic_Pass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pass2.TabIndex = 7;
            this.pic_Pass2.TabStop = false;
            this.pic_Pass2.Tag = "2";
            this.pic_Pass2.Click += new System.EventHandler(this.pic_Pass2_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.AutoSize = true;
            this.Confirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(15, 193);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(131, 21);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "Confirmar Senha:";
            // 
            // pic_Pass
            // 
            this.pic_Pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Pass.BackgroundImage")));
            this.pic_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Pass.Location = new System.Drawing.Point(347, 147);
            this.pic_Pass.Name = "pic_Pass";
            this.pic_Pass.Size = new System.Drawing.Size(26, 29);
            this.pic_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pass.TabIndex = 7;
            this.pic_Pass.TabStop = false;
            this.pic_Pass.Tag = "1";
            this.pic_Pass.Click += new System.EventHandler(this.pic_Pass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nova Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(15, 16);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(119, 21);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Alterar Usuário";
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.Location = new System.Drawing.Point(152, 190);
            this.txt_ConfirmPass.MaxLength = 6;
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(184, 29);
            this.txt_ConfirmPass.TabIndex = 3;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(152, 60);
            this.txt_ID.MaxLength = 8;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(69, 29);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TabStop = false;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(152, 147);
            this.txt_Senha.MaxLength = 6;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(184, 29);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(152, 103);
            this.txt_Usuario.MaxLength = 8;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(184, 29);
            this.txt_Usuario.TabIndex = 1;
            // 
            // pic_Salvar
            // 
            this.pic_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Salvar.BackgroundImage")));
            this.pic_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Salvar.Location = new System.Drawing.Point(158, 292);
            this.pic_Salvar.Name = "pic_Salvar";
            this.pic_Salvar.Size = new System.Drawing.Size(123, 36);
            this.pic_Salvar.TabIndex = 2;
            this.pic_Salvar.TabStop = false;
            this.pic_Salvar.Tag = "";
            this.pic_Salvar.Click += new System.EventHandler(this.pic_Salvar_Click);
            this.pic_Salvar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Salvar_MouseDown);
            this.pic_Salvar.MouseEnter += new System.EventHandler(this.pic_Salvar_MouseEnter);
            this.pic_Salvar.MouseLeave += new System.EventHandler(this.pic_Salvar_MouseLeave);
            this.pic_Salvar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Salvar_MouseUp);
            // 
            // pic_Excluir
            // 
            this.pic_Excluir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Excluir.BackgroundImage")));
            this.pic_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Excluir.Location = new System.Drawing.Point(12, 292);
            this.pic_Excluir.Name = "pic_Excluir";
            this.pic_Excluir.Size = new System.Drawing.Size(123, 36);
            this.pic_Excluir.TabIndex = 2;
            this.pic_Excluir.TabStop = false;
            this.pic_Excluir.Tag = "";
            this.pic_Excluir.Click += new System.EventHandler(this.pic_Excluir_Click);
            this.pic_Excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseDown);
            this.pic_Excluir.MouseEnter += new System.EventHandler(this.pic_Excluir_MouseEnter);
            this.pic_Excluir.MouseLeave += new System.EventHandler(this.pic_Excluir_MouseLeave);
            this.pic_Excluir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseUp);
            // 
            // lista
            // 
            this.lista.AutoArrange = false;
            this.lista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Usuário});
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lista.FullRowSelect = true;
            this.lista.GridLines = true;
            this.lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lista.HideSelection = false;
            this.lista.LabelWrap = false;
            this.lista.Location = new System.Drawing.Point(437, 12);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(297, 240);
            this.lista.TabIndex = 0;
            this.lista.TabStop = false;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Usuário
            // 
            this.Usuário.Text = "USUÁRIO";
            this.Usuário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuário.Width = 250;
            // 
            // pic_Sair
            // 
            this.pic_Sair.BackColor = System.Drawing.Color.Transparent;
            this.pic_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Sair.BackgroundImage")));
            this.pic_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Sair.Location = new System.Drawing.Point(611, 292);
            this.pic_Sair.Name = "pic_Sair";
            this.pic_Sair.Size = new System.Drawing.Size(123, 36);
            this.pic_Sair.TabIndex = 6;
            this.pic_Sair.TabStop = false;
            this.pic_Sair.Tag = "";
            this.pic_Sair.Click += new System.EventHandler(this.pic_Sair_Click);
            this.pic_Sair.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseDown);
            this.pic_Sair.MouseEnter += new System.EventHandler(this.pic_Sair_MouseEnter);
            this.pic_Sair.MouseLeave += new System.EventHandler(this.pic_Sair_MouseLeave);
            this.pic_Sair.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseUp);
            // 
            // pic_Inserir
            // 
            this.pic_Inserir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Inserir.BackgroundImage")));
            this.pic_Inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Inserir.Location = new System.Drawing.Point(305, 292);
            this.pic_Inserir.Name = "pic_Inserir";
            this.pic_Inserir.Size = new System.Drawing.Size(123, 36);
            this.pic_Inserir.TabIndex = 15;
            this.pic_Inserir.TabStop = false;
            this.pic_Inserir.Tag = "";
            this.pic_Inserir.Click += new System.EventHandler(this.pic_Inserir_Click);
            this.pic_Inserir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Inserir_MouseDown);
            this.pic_Inserir.MouseEnter += new System.EventHandler(this.pic_Inserir_MouseEnter);
            this.pic_Inserir.MouseLeave += new System.EventHandler(this.pic_Inserir_MouseLeave);
            this.pic_Inserir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Inserir_MouseUp);
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 340);
            this.Controls.Add(this.pic_Inserir);
            this.Controls.Add(this.pic_Sair);
            this.Controls.Add(this.pic_Excluir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.pic_Salvar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inserir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.PictureBox pic_Salvar;
        private System.Windows.Forms.PictureBox pic_Excluir;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Usuário;
        private System.Windows.Forms.PictureBox pic_Sair;
        private System.Windows.Forms.PictureBox pic_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.PictureBox pic_Pass2;
        private System.Windows.Forms.Label Confirmar;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.PictureBox pic_Inserir;
    }
}