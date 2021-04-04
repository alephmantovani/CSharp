namespace CRUD.View
{
    partial class ConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Pesquisar = new System.Windows.Forms.PictureBox();
            this.rd_Sobrenome = new System.Windows.Forms.RadioButton();
            this.rd_ID = new System.Windows.Forms.RadioButton();
            this.rd_Nome = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pic_Excluir = new System.Windows.Forms.PictureBox();
            this.pic_Editar = new System.Windows.Forms.PictureBox();
            this.pic_Sair = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_Pesquisar);
            this.panel1.Controls.Add(this.rd_Sobrenome);
            this.panel1.Controls.Add(this.rd_ID);
            this.panel1.Controls.Add(this.rd_Nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Pesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 98);
            this.panel1.TabIndex = 3;
            // 
            // pic_Pesquisar
            // 
            this.pic_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Pesquisar.BackgroundImage")));
            this.pic_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Pesquisar.Location = new System.Drawing.Point(523, 54);
            this.pic_Pesquisar.Name = "pic_Pesquisar";
            this.pic_Pesquisar.Size = new System.Drawing.Size(43, 29);
            this.pic_Pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pesquisar.TabIndex = 3;
            this.pic_Pesquisar.TabStop = false;
            this.pic_Pesquisar.Click += new System.EventHandler(this.pic_Pesquisar_Click);
            this.pic_Pesquisar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Pesquisar_MouseDown);
            this.pic_Pesquisar.MouseEnter += new System.EventHandler(this.pic_Pesquisar_MouseEnter);
            this.pic_Pesquisar.MouseLeave += new System.EventHandler(this.pic_Pesquisar_MouseLeave);
            this.pic_Pesquisar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Pesquisar_MouseUp);
            // 
            // rd_Sobrenome
            // 
            this.rd_Sobrenome.AutoSize = true;
            this.rd_Sobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Sobrenome.Location = new System.Drawing.Point(389, 11);
            this.rd_Sobrenome.Name = "rd_Sobrenome";
            this.rd_Sobrenome.Size = new System.Drawing.Size(109, 25);
            this.rd_Sobrenome.TabIndex = 3;
            this.rd_Sobrenome.Text = "Sobrenome";
            this.rd_Sobrenome.UseVisualStyleBackColor = true;
            this.rd_Sobrenome.Click += new System.EventHandler(this.rd_Sobrenome_Click);
            // 
            // rd_ID
            // 
            this.rd_ID.AutoSize = true;
            this.rd_ID.Checked = true;
            this.rd_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ID.Location = new System.Drawing.Point(184, 11);
            this.rd_ID.Name = "rd_ID";
            this.rd_ID.Size = new System.Drawing.Size(78, 25);
            this.rd_ID.TabIndex = 1;
            this.rd_ID.TabStop = true;
            this.rd_ID.Text = "Código";
            this.rd_ID.UseVisualStyleBackColor = true;
            this.rd_ID.Click += new System.EventHandler(this.rd_ID_Click);
            // 
            // rd_Nome
            // 
            this.rd_Nome.AutoSize = true;
            this.rd_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Nome.Location = new System.Drawing.Point(291, 11);
            this.rd_Nome.Name = "rd_Nome";
            this.rd_Nome.Size = new System.Drawing.Size(71, 25);
            this.rd_Nome.TabIndex = 3;
            this.rd_Nome.Text = "Nome";
            this.rd_Nome.UseVisualStyleBackColor = true;
            this.rd_Nome.Click += new System.EventHandler(this.rd_Nome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisar por";
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.Location = new System.Drawing.Point(20, 54);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(478, 29);
            this.txt_Pesquisar.TabIndex = 1;
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
            this.listView.Location = new System.Drawing.Point(12, 130);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(583, 259);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
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
            // pic_Excluir
            // 
            this.pic_Excluir.BackColor = System.Drawing.Color.Transparent;
            this.pic_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Excluir.BackgroundImage")));
            this.pic_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Excluir.Location = new System.Drawing.Point(14, 404);
            this.pic_Excluir.Name = "pic_Excluir";
            this.pic_Excluir.Size = new System.Drawing.Size(123, 36);
            this.pic_Excluir.TabIndex = 7;
            this.pic_Excluir.TabStop = false;
            this.pic_Excluir.Tag = "";
            this.pic_Excluir.Click += new System.EventHandler(this.pic_Excluir_Click);
            this.pic_Excluir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseDown);
            this.pic_Excluir.MouseEnter += new System.EventHandler(this.pic_Excluir_MouseEnter);
            this.pic_Excluir.MouseLeave += new System.EventHandler(this.pic_Excluir_MouseLeave);
            this.pic_Excluir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Excluir_MouseUp);
            // 
            // pic_Editar
            // 
            this.pic_Editar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Editar.BackgroundImage")));
            this.pic_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Editar.Location = new System.Drawing.Point(165, 404);
            this.pic_Editar.Name = "pic_Editar";
            this.pic_Editar.Size = new System.Drawing.Size(123, 36);
            this.pic_Editar.TabIndex = 8;
            this.pic_Editar.TabStop = false;
            this.pic_Editar.Tag = "";
            this.pic_Editar.Click += new System.EventHandler(this.pic_Editar_Click);
            this.pic_Editar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Editar_MouseDown);
            this.pic_Editar.MouseEnter += new System.EventHandler(this.pic_Editar_MouseEnter);
            this.pic_Editar.MouseLeave += new System.EventHandler(this.pic_Editar_MouseLeave);
            this.pic_Editar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Editar_MouseUp);
            // 
            // pic_Sair
            // 
            this.pic_Sair.BackColor = System.Drawing.Color.Transparent;
            this.pic_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Sair.BackgroundImage")));
            this.pic_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Sair.Location = new System.Drawing.Point(472, 404);
            this.pic_Sair.Name = "pic_Sair";
            this.pic_Sair.Size = new System.Drawing.Size(123, 36);
            this.pic_Sair.TabIndex = 8;
            this.pic_Sair.TabStop = false;
            this.pic_Sair.Tag = "";
            this.pic_Sair.Click += new System.EventHandler(this.pic_Sair_Click);
            this.pic_Sair.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseDown);
            this.pic_Sair.MouseEnter += new System.EventHandler(this.pic_Sair_MouseEnter);
            this.pic_Sair.MouseLeave += new System.EventHandler(this.pic_Sair_MouseLeave);
            this.pic_Sair.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Sair_MouseUp);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.pic_Sair);
            this.Controls.Add(this.pic_Editar);
            this.Controls.Add(this.pic_Excluir);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Excluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_Pesquisar;
        private System.Windows.Forms.RadioButton rd_Sobrenome;
        private System.Windows.Forms.RadioButton rd_ID;
        private System.Windows.Forms.RadioButton rd_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Sobrenome;
        private System.Windows.Forms.PictureBox pic_Excluir;
        private System.Windows.Forms.PictureBox pic_Editar;
        private System.Windows.Forms.PictureBox pic_Sair;
    }
}