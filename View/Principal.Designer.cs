namespace CRUD.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.pic_Inserir = new System.Windows.Forms.PictureBox();
            this.pic_Editar = new System.Windows.Forms.PictureBox();
            this.pic_Excluir = new System.Windows.Forms.PictureBox();
            this.pic_Buscar = new System.Windows.Forms.PictureBox();
            this.pnl_Acoes = new System.Windows.Forms.Panel();
            this.lbl_User = new System.Windows.Forms.Label();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.pnl_Servicos = new System.Windows.Forms.Panel();
            this.lbl_HoraAtual = new System.Windows.Forms.Label();
            this.link_Consultar = new System.Windows.Forms.LinkLabel();
            this.link_NovoUsuario = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_Sair = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Buscar)).BeginInit();
            this.pnl_Acoes.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.pnl_Servicos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Nome
            // 
            this.Nome.Text = "NOME";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 250;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Text = "SOBRENOME";
            this.Sobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sobrenome.Width = 288;
            // 
            // listView
            // 
            this.listView.AutoArrange = false;
            this.listView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Sobrenome});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(205, 196);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(583, 281);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // pic_Inserir
            // 
            this.pic_Inserir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Inserir.BackgroundImage")));
            this.pic_Inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Inserir.Location = new System.Drawing.Point(20, 16);
            this.pic_Inserir.Name = "pic_Inserir";
            this.pic_Inserir.Size = new System.Drawing.Size(123, 36);
            this.pic_Inserir.TabIndex = 0;
            this.pic_Inserir.TabStop = false;
            this.pic_Inserir.Tag = "";
            this.pic_Inserir.Click += new System.EventHandler(this.pic_Inserir_Click);
            this.pic_Inserir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Inserir_MouseDown);
            this.pic_Inserir.MouseEnter += new System.EventHandler(this.pic_Inserir_MouseEnter);
            this.pic_Inserir.MouseLeave += new System.EventHandler(this.pic_Inserir_MouseLeave);
            this.pic_Inserir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Inserir_MouseUp);
            // 
            // pic_Editar
            // 
            this.pic_Editar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Editar.BackgroundImage")));
            this.pic_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Editar.Location = new System.Drawing.Point(20, 84);
            this.pic_Editar.Name = "pic_Editar";
            this.pic_Editar.Size = new System.Drawing.Size(123, 36);
            this.pic_Editar.TabIndex = 0;
            this.pic_Editar.TabStop = false;
            this.pic_Editar.Tag = "";
            this.pic_Editar.Click += new System.EventHandler(this.pic_Editar_Click);
            this.pic_Editar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Editar_MouseDown);
            this.pic_Editar.MouseEnter += new System.EventHandler(this.pic_Editar_MouseEnter);
            this.pic_Editar.MouseLeave += new System.EventHandler(this.pic_Editar_MouseLeave);
            this.pic_Editar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Editar_MouseUp);
            // 
            // pic_Excluir
            // 
            this.pic_Excluir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Excluir.BackgroundImage")));
            this.pic_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Excluir.Location = new System.Drawing.Point(20, 153);
            this.pic_Excluir.Name = "pic_Excluir";
            this.pic_Excluir.Size = new System.Drawing.Size(123, 36);
            this.pic_Excluir.TabIndex = 0;
            this.pic_Excluir.TabStop = false;
            this.pic_Excluir.Tag = "";
            this.pic_Excluir.Click += new System.EventHandler(this.pic_Excluir_Click);
            this.pic_Excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseDown);
            this.pic_Excluir.MouseEnter += new System.EventHandler(this.pic_Excluir_MouseEnter);
            this.pic_Excluir.MouseLeave += new System.EventHandler(this.pic_Excluir_MouseLeave);
            this.pic_Excluir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseUp);
            // 
            // pic_Buscar
            // 
            this.pic_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Buscar.BackgroundImage")));
            this.pic_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Buscar.Location = new System.Drawing.Point(20, 223);
            this.pic_Buscar.Name = "pic_Buscar";
            this.pic_Buscar.Size = new System.Drawing.Size(123, 36);
            this.pic_Buscar.TabIndex = 0;
            this.pic_Buscar.TabStop = false;
            this.pic_Buscar.Tag = "";
            this.pic_Buscar.Click += new System.EventHandler(this.pic_Buscar_Click);
            this.pic_Buscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Buscar_MouseDown);
            this.pic_Buscar.MouseEnter += new System.EventHandler(this.pic_Buscar_MouseEnter);
            this.pic_Buscar.MouseLeave += new System.EventHandler(this.pic_Buscar_MouseLeave);
            this.pic_Buscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Buscar_MouseUp);
            // 
            // pnl_Acoes
            // 
            this.pnl_Acoes.Controls.Add(this.pic_Buscar);
            this.pnl_Acoes.Controls.Add(this.pic_Excluir);
            this.pnl_Acoes.Controls.Add(this.pic_Editar);
            this.pnl_Acoes.Controls.Add(this.pic_Inserir);
            this.pnl_Acoes.Location = new System.Drawing.Point(12, 196);
            this.pnl_Acoes.Name = "pnl_Acoes";
            this.pnl_Acoes.Size = new System.Drawing.Size(168, 281);
            this.pnl_Acoes.TabIndex = 2;
            // 
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_User.Location = new System.Drawing.Point(427, 119);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_User.Size = new System.Drawing.Size(361, 24);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Ola senhor usuario";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelPrincipal.BackgroundImage")));
            this.painelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelPrincipal.Controls.Add(this.lbl_User);
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(801, 152);
            this.painelPrincipal.TabIndex = 1;
            // 
            // pnl_Servicos
            // 
            this.pnl_Servicos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_Servicos.Controls.Add(this.lbl_HoraAtual);
            this.pnl_Servicos.Controls.Add(this.link_Consultar);
            this.pnl_Servicos.Controls.Add(this.link_NovoUsuario);
            this.pnl_Servicos.Location = new System.Drawing.Point(0, 152);
            this.pnl_Servicos.Name = "pnl_Servicos";
            this.pnl_Servicos.Size = new System.Drawing.Size(801, 30);
            this.pnl_Servicos.TabIndex = 3;
            // 
            // lbl_HoraAtual
            // 
            this.lbl_HoraAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraAtual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_HoraAtual.Location = new System.Drawing.Point(624, 3);
            this.lbl_HoraAtual.Name = "lbl_HoraAtual";
            this.lbl_HoraAtual.Size = new System.Drawing.Size(164, 23);
            this.lbl_HoraAtual.TabIndex = 1;
            this.lbl_HoraAtual.Text = "horario";
            this.lbl_HoraAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // link_Consultar
            // 
            this.link_Consultar.ActiveLinkColor = System.Drawing.Color.Lavender;
            this.link_Consultar.AutoSize = true;
            this.link_Consultar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Consultar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_Consultar.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Consultar.Location = new System.Drawing.Point(185, 6);
            this.link_Consultar.Margin = new System.Windows.Forms.Padding(0);
            this.link_Consultar.Name = "link_Consultar";
            this.link_Consultar.Size = new System.Drawing.Size(135, 17);
            this.link_Consultar.TabIndex = 0;
            this.link_Consultar.TabStop = true;
            this.link_Consultar.Text = "> Consultar Usuários";
            this.link_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Consultar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.link_Consultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Consultar_LinkClicked);
            // 
            // link_NovoUsuario
            // 
            this.link_NovoUsuario.ActiveLinkColor = System.Drawing.Color.Lavender;
            this.link_NovoUsuario.AutoSize = true;
            this.link_NovoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_NovoUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_NovoUsuario.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_NovoUsuario.Location = new System.Drawing.Point(15, 6);
            this.link_NovoUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.link_NovoUsuario.Name = "link_NovoUsuario";
            this.link_NovoUsuario.Size = new System.Drawing.Size(104, 17);
            this.link_NovoUsuario.TabIndex = 0;
            this.link_NovoUsuario.TabStop = true;
            this.link_NovoUsuario.Text = "> Novo Usuário";
            this.link_NovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_NovoUsuario.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.link_NovoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_NovoUsuario_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.link_Sair);
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 30);
            this.panel1.TabIndex = 3;
            // 
            // link_Sair
            // 
            this.link_Sair.ActiveLinkColor = System.Drawing.Color.Lavender;
            this.link_Sair.AutoSize = true;
            this.link_Sair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Sair.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_Sair.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_Sair.Location = new System.Drawing.Point(750, 4);
            this.link_Sair.Margin = new System.Windows.Forms.Padding(0);
            this.link_Sair.Name = "link_Sair";
            this.link_Sair.Size = new System.Drawing.Size(45, 21);
            this.link_Sair.TabIndex = 0;
            this.link_Sair.TabStop = true;
            this.link_Sair.Text = "SAIR";
            this.link_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Sair.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.link_Sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Sair_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Servicos);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.pnl_Acoes);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD - Sistema de Projetos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Inserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Buscar)).EndInit();
            this.pnl_Acoes.ResumeLayout(false);
            this.painelPrincipal.ResumeLayout(false);
            this.pnl_Servicos.ResumeLayout(false);
            this.pnl_Servicos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Sobrenome;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.PictureBox pic_Inserir;
        private System.Windows.Forms.PictureBox pic_Editar;
        private System.Windows.Forms.PictureBox pic_Excluir;
        private System.Windows.Forms.PictureBox pic_Buscar;
        private System.Windows.Forms.Panel pnl_Acoes;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Panel pnl_Servicos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel link_Sair;
        private System.Windows.Forms.LinkLabel link_NovoUsuario;
        private System.Windows.Forms.LinkLabel link_Consultar;
        private System.Windows.Forms.Label lbl_HoraAtual;
    }
}