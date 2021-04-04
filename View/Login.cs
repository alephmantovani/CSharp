using CRUD.Controller;
using CRUD.DAL;
using CRUD.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmLogin : Form
    {
        ConfigurarSistema config;
        Thread t;
         
        public frmLogin()
        {
            InitializeComponent();
            config = new ConfigurarSistema();
            txt_Usuario.Focus();
        }
                
                
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void entrarPrincipal()
        {
            ControleLogin controle = new ControleLogin();
            controle.acessar(txt_Usuario.Text, txt_Senha.Text);

            ConexaoDAO conect = new ConexaoDAO();

            if (controle.mensagem.Equals(""))
            {
                if (controle.verificador)
                {
                    MessageBox.Show("Logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal.user = txt_Usuario.Text;
                    this.Close();

                    t = new Thread(janelaPrincipal);
                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                }
                else
                {
                    MessageBox.Show("Login não encontrado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void janelaPrincipal()
        {
            Application.Run(new Principal());
            
        }

        private void encerrarApp()
        {
            Application.Exit();
        }

        /*--EVENTOS
         * --TEXTBOX
         * --USUARIO e SENHA--*/
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

        /*--EVENTOS
         * --MOUSE
         * --SAIR--*/
        private void pic_Sair_MouseLeave(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "N");
        }

        private void pic_Sair_MouseEnter(object sender, EventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "H");
        }

        private void pic_Sair_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "C");
        }

        private void pic_Sair_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "H");
        }

        private void pic_Sair_Click(object sender, EventArgs e)
        {
            encerrarApp();
        }

        /*--EVENTOS
         * --MOUSE
         * --ENTRAR--*/
        private void pic_Entrar_Click(object sender, EventArgs e)
        {
            entrarPrincipal();
        }

        private void pic_Entrar_MouseLeave(object sender, EventArgs e)
        {
            pic_Entrar.BackgroundImage = config.configurarBotoes("ENTRAR", "N");
        }

        private void pic_Entrar_MouseEnter(object sender, EventArgs e)
        {
            pic_Entrar.BackgroundImage = config.configurarBotoes("ENTRAR", "H");
        }

        private void pic_Entrar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Entrar.BackgroundImage = config.configurarBotoes("ENTRAR", "C");
        }

        private void pic_Entrar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Entrar.BackgroundImage = config.configurarBotoes("ENTRAR", "H");
        }

    }
}
