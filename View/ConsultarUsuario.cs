using CRUD.Controller;
using CRUD.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.View
{
    public partial class ConsultarUsuario : Form
    {
        Usuario usuario;
        ConfigurarSistema config;
        ControleLogin contLogin;
        DataTable result;
        String mensagem;
        bool senhaAberta;
        String tipo;

        public ConsultarUsuario(string tipo)
        {
            InitializeComponent();

            this.tipo = tipo;

            if (tipo.Equals("EDITAR"))
            {
                pic_Inserir.Visible = false;
                pic_Excluir.Visible = true;
                pic_Salvar.Visible = true;
                this.Text = "Consultar Usuário";
                this.lbl_Titulo.Text = "Alterar Usuário";
            }
            else if (tipo.Equals("INSERIR"))
            {
                pic_Inserir.Visible = true;
                pic_Excluir.Visible = false;
                pic_Salvar.Visible = false;
                this.Text = "Novo Usuário";
                this.lbl_Titulo.Text = "Novo Usuário";
            }

            config = new ConfigurarSistema();

            mensagem = "";
            senhaAberta = false;
            txt_Usuario.Focus();
        }


        private void carregarDados()
        {
            if (tipo.Equals("EDITAR"))
            {

                if (lista.SelectedItems.Count > 0)
                {
                    txt_ID.Text = lista.SelectedItems[0].SubItems[0].Text;
                    txt_Usuario.Text = lista.SelectedItems[0].SubItems[1].Text;
                    txt_Senha.Clear();
                    txt_ConfirmPass.Clear();
                    senhaAberta = false;
                    txt_Senha.UseSystemPasswordChar = true;
                    pic_Pass.BackgroundImage = config.configurarBotoes("PASS", "F");

                    if (txt_Usuario.Text.Equals("admin"))
                    {
                        pic_Excluir.Enabled = false;
                        pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "D");
                        pic_Salvar.Enabled = false;
                        pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "D");
                    }
                    else if (txt_Usuario.Text.Equals(Principal.user))
                    {
                        pic_Excluir.Enabled = false;
                        pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "D");
                        pic_Salvar.Enabled = false;
                        pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "D");
                    }
                    else
                    {
                        pic_Excluir.Enabled = true;
                        pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "N");
                        pic_Salvar.Enabled = true;
                        pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "N");
                    }
                }
            }
        }

        private void excluir()
        {
            if (lista.SelectedItems.Count > 0)
            {
                usuario = new Usuario();
                usuario.Id = lista.SelectedItems[0].SubItems[0].Text;

                contLogin = new ControleLogin();
                bool pop = contLogin.excluir(usuario.Id);


                if (pop)
                {
                    popularLista();
                }

            }
            else
            {
                MessageBox.Show("Não há linha selecionada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inserir()
        {
            bool salvar = true;

            usuario = new Usuario();
            usuario.Id = txt_ID.Text;
            usuario.User = txt_Usuario.Text.Trim();
            usuario.Pass = txt_Senha.Text.Trim();

            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                MessageBox.Show("O campo Usuário NÃO pode ser vazio!", "USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                salvar = false;
                txt_Usuario.Focus();
                txt_Senha.Clear();
                txt_ConfirmPass.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Senha.Text))
            {
                DialogResult resp = MessageBox.Show("O campo senha está vazio. Deseja cadastrar mesmo assim?", "SENHA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.No)
                {
                    salvar = false;
                    txt_Senha.Focus();
                    txt_ConfirmPass.Clear();
                }
            }
            else
            {
                salvar = true;
            }

            //INSERIR O CADASTRO
            if (salvar)
            {
                contLogin = new ControleLogin();

                if (contLogin.confirmSenha(txt_Senha.Text, txt_ConfirmPass.Text))
                {
                    contLogin.cadastrar(usuario.User, usuario.Pass);

                    if (contLogin.verificador)
                    {
                        MessageBox.Show(contLogin.mensagem, "NOVO USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        popularLista();
                    }
                    else
                    {
                        MessageBox.Show(contLogin.mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_ID.Clear();
                        txt_Usuario.Clear();
                        txt_Senha.Clear();
                        txt_ConfirmPass.Clear();
                        txt_Usuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("A senha não confere!", "SENHA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Senha.Clear();
                    txt_ConfirmPass.Clear();
                    txt_Senha.Focus();
                }
            }
        }


        private void editar()
        {
            bool salvar = true;

            if (lista.SelectedItems.Count > 0)
            {
                usuario = new Usuario();
                usuario.Id = txt_ID.Text;
                usuario.User = txt_Usuario.Text.Trim();
                usuario.Pass = txt_Senha.Text.Trim();

                if (string.IsNullOrEmpty(txt_Senha.Text))
                {
                    DialogResult resp = MessageBox.Show("O campo senha está vazio. Deseja alterar mesmo assim?", "SENHA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.No)
                    {
                        salvar = false;
                        txt_Senha.Focus();
                        txt_ConfirmPass.Clear();
                    }
                }
                else
                {
                    salvar = true;
                }

                //EDITAR O CADASTRO
                if (salvar)
                {
                    contLogin = new ControleLogin();

                    if (contLogin.confirmSenha(txt_Senha.Text, txt_ConfirmPass.Text))
                    {
                        contLogin.editar(usuario);

                        if (contLogin.verificador)
                        {
                            MessageBox.Show(contLogin.mensagem, "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            popularLista();
                        }
                        else
                        {
                            MessageBox.Show(contLogin.mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_ID.Clear();
                            txt_Usuario.Clear();
                            txt_Senha.Clear();
                            txt_ConfirmPass.Clear();
                            txt_Usuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha não confere!", "SENHA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Senha.Clear();
                        txt_ConfirmPass.Clear();
                        txt_Senha.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há linha selecionada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /*--EVENTO
         * --MOUSE
         * --SALVAR--*/
        private void pic_Salvar_MouseEnter(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Salvar_MouseLeave(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "N");
        }

        private void pic_Salvar_Click(object sender, EventArgs e)
        {
            //Chamar o metodo para salvar
            editar();
        }

        /*--EVENTO
         * --MOUSE
         * --EXCLUIR--*/
        private void pic_Excluir_MouseEnter(object sender, EventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "H");
        }

        private void pic_Excluir_MouseLeave(object sender, EventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "N");
        }

        private void pic_Excluir_Click(object sender, EventArgs e)
        {
            //Chamar o metodo para excluir
            excluir();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void pic_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Sair_MouseEnter(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "H");
        }

        private void pic_Sair_MouseLeave(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "N");
        }

        private void pic_Sair_MouseDown(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "C");
        }

        private void pic_Sair_MouseUp(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "N");
        }

        private void pic_Salvar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "C");
        }

        private void pic_Salvar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Inserir_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("SALVAR", "C");
        }

        private void pic_Inserir_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("SALVAR", "N");
        }
        private void pic_Inserir_MouseEnter(object sender, EventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Inserir_MouseLeave(object sender, EventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("SALVAR", "N");
        }


        private void pic_Excluir_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "C");
        }

        private void pic_Excluir_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "N");
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            popularLista();
        }

        public void popularLista()
        {
            contLogin = new ControleLogin();
            ListViewItem item;
            lista.Items.Clear();
            txt_ID.Clear();
            txt_Usuario.Clear();
            txt_Senha.Clear();
            txt_ConfirmPass.Clear();
            txt_Usuario.Focus();

            try
            {
                result = contLogin.consultarUsuario();
                this.mensagem = contLogin.mensagem;

                if (mensagem.Equals(""))
                {
                    foreach (DataRow linha in result.Rows)
                    {
                        item = new ListViewItem(linha.ItemArray.ElementAt(0).ToString());
                        item.SubItems.Add(linha.ItemArray.ElementAt(1).ToString());
                        item.SubItems.Add(linha.ItemArray.ElementAt(2).ToString());
                        lista.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique sua conexão com a internet!", "Erro ao tentar conectar com o banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void passConfig(Object sender)
        {

            PictureBox pass = sender as PictureBox;
            TextBox txt;
            string tag = (string)pass.Tag;

            if (tag.Equals("1"))
            {
                pass = pic_Pass;
                txt = txt_Senha;
            }
            else
            {
                pass = pic_Pass2;
                txt = txt_ConfirmPass;
            }

            if (senhaAberta == true)
            {
                pass.BackgroundImage = config.configurarBotoes("PASS", "F");
                pass.BackgroundImageLayout = ImageLayout.Stretch;
                senhaAberta = false;
                txt.UseSystemPasswordChar = true;
            }
            else
            {
                pass.BackgroundImage = config.configurarBotoes("PASS", "A");
                pass.BackgroundImageLayout = ImageLayout.Stretch;
                senhaAberta = true;
                txt.UseSystemPasswordChar = false;
            }
        }

        private void pic_Pass_Click(object sender, EventArgs e)
        {
            passConfig(sender);
        }

        private void pic_Pass2_Click(object sender, EventArgs e)
        {
            passConfig(sender);
        }

        private void pic_Inserir_Click(object sender, EventArgs e)
        {
            inserir();
        }
    }
}
