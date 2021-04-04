using CRUD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.View
{
    public partial class NovoUsuario : Form
    {

        ControleLogin controle;
        ConfigurarSistema config;
        String mensagem = "";

        public NovoUsuario()
        {
            InitializeComponent();
            config = new ConfigurarSistema();
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            txt_Usuario.Focus();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            cadastrarNovoUsuario();
        }

        private void txt_Usuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                e.Cancel = false;
                txt_Usuario.Focus();
                errorProvider.SetError(txt_Usuario, "O campo não pode estar vazio!");
                pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "D");
                pic_Salvar.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_Usuario, null);
                pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "N");
                pic_Salvar.Enabled = true;
            }
        }

        private void cadastrarNovoUsuario()
        {
            controle = new ControleLogin();

            String user = txt_Usuario.Text.Trim();
            String pass = txt_Senha.Text.Trim();
            String confirmPass = txt_ConfirmeSenha.Text.Trim();

            if (controle.confirmSenha(pass, confirmPass))
            {
                mensagem = controle.cadastrar(user, pass);

                if (!mensagem.Equals(""))
                {
                    if (controle.verificador)
                    {
                        MessageBox.Show(mensagem, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Usuario.Clear();
                        txt_ConfirmeSenha.Clear();
                        txt_Senha.Clear();
                        txt_Usuario.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("A senha não confere!", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ConfirmeSenha.Clear();
                txt_Senha.Clear();
                txt_Senha.Focus();
            }
        }

        private void pic_Salvar_Click(object sender, EventArgs e)
        {
            cadastrarNovoUsuario();
        }


        private void pic_Salvar_MouseEnter(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Salvar_MouseLeave(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "N");
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            txt_Usuario.BackColor = Color.LightCyan;
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            txt_Usuario.BackColor = Color.White;
        }

        private void txt_Senha_Enter(object sender, EventArgs e)
        {
            txt_Senha.BackColor = Color.LightCyan;
        }

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
            txt_Senha.BackColor = Color.White;
        }

        private void txt_ConfirmeSenha_Enter(object sender, EventArgs e)
        {
            txt_ConfirmeSenha.BackColor = Color.LightCyan;
        }

        private void txt_ConfirmeSenha_Leave(object sender, EventArgs e)
        {
            txt_ConfirmeSenha.BackColor = Color.White;
        }
    }
}
