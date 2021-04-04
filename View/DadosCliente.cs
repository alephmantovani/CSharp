using CRUD.Controller;
using CRUD.Model;
using System;
using System.Windows.Forms;

namespace CRUD.View
{
    public partial class DadosCliente : Form
    {

        ConfigurarSistema config;
        ControlePrincipal contPrinc;
        Cliente cli;
        ConsultarCliente cons;
        Principal princ;

        String id, nome, sobrenome, mensagem;
        bool verificador, tipo;

        public DadosCliente(string id, string nome, string sobrenome, ConsultarCliente cons)
        {
            InitializeComponent();

            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cons = cons;

            this.mensagem = "";
            this.verificador = false;
            tipo = false; //Define que o metodo será de INSERIR

            configurarTextFields();
            config = new ConfigurarSistema();
        }

        public DadosCliente(Principal princ)
        {
            InitializeComponent();

            this.princ = princ;

            //Form atualizado para INSERIR
            lblTitulo.Text = "Cadastrar novo cliente";
            this.Text = "Cadastrar Novo Cliente";
            txt_ID.Enabled = false;

            this.mensagem = "";
            this.verificador = false;
            tipo = true; //Define se o metodo será de INSERIR

            txt_Nome.Focus();
            config = new ConfigurarSistema();
        }

        public DadosCliente(string id, string nome, string sobrenome, Principal princ)
        {
            InitializeComponent();

            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.princ = princ;

            this.mensagem = "";
            this.verificador = false;
            tipo = false; //Define se o metodo será de INSERIR

            configurarTextFields();
            config = new ConfigurarSistema();
        }

        private void configurarTextFields()
        {
            txt_ID.Text = id;
            txt_Nome.Text = nome;
            txt_Sobrenome.Text = sobrenome;
            txt_Nome.Focus();
        }

        private bool conferirAlteracoes()
        {
            /*Se os dois campos de texto estiverem com os mesmos textos vindo do contrutor
             * retorna TRUE caso os dois campos forem iguais
             * retorna FALSE caso qualquer um dos campos forem diferentes*/
            return (txt_Nome.Text.Equals(nome) && (txt_Sobrenome.Text.Equals(sobrenome)));
        }

        private void cadastrarNovoCliente()
        {
            if (string.IsNullOrEmpty(txt_Nome.Text) || string.IsNullOrEmpty(txt_Sobrenome.Text))
            {
                MessageBox.Show("Nenhum dado pode ser nulo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nome.Focus();
            }
            else
            {
                cli = new Cliente();
                cli.Nome = txt_Nome.Text;
                cli.Sobrenome = txt_Sobrenome.Text;

                //Chamar o metodo para inserir
                contPrinc = new ControlePrincipal();
                contPrinc.inserir(cli);
                this.verificador = contPrinc.verificador;

                if (verificador)
                {
                    if (princ != null)
                    {
                        princ.popularLista();
                    }

                    DialogResult resp = MessageBox.Show("Deseja cadastrar outro usuário?", "INSERIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        txt_Nome.Clear();
                        txt_Sobrenome.Clear();
                        txt_Nome.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    txt_Nome.Clear();
                    txt_Sobrenome.Clear();
                    txt_Nome.Focus();
                }
            }
        }
        private void salvarAlteracoes()
        {
            //Confere se houve alterações
            if (conferirAlteracoes())
            {
                MessageBox.Show("Não foram feitas alterações ainda!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nome.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Nome.Text) || string.IsNullOrEmpty(txt_Sobrenome.Text))
                {
                    MessageBox.Show("Nenhum dado pode ser nulo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Nome.Focus();
                }
                else
                {
                    cli = new Cliente();
                    cli.Id = txt_ID.Text;
                    cli.Nome = txt_Nome.Text;
                    cli.Sobrenome = txt_Sobrenome.Text;

                    //Chamar o metodo para alterar
                    contPrinc = new ControlePrincipal();
                    contPrinc.editar(cli);
                    this.verificador = contPrinc.verificador;
                    this.mensagem = contPrinc.mensagem;

                    if (verificador)
                    {
                        MessageBox.Show(mensagem, "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (cons != null)
                        {
                            cons.consultaTodosClientes();
                        }
                        else if (princ != null)
                        {
                            princ.popularLista();
                        }
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
        }


        private void pic_Salvar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "C");
        }

        private void pic_Salvar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Salvar_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                cadastrarNovoCliente();
            }
            else
            {
                salvarAlteracoes();
            }

        }

        private void pic_Salvar_MouseEnter(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "H");
        }

        private void pic_Salvar_MouseLeave(object sender, EventArgs e)
        {
            pic_Salvar.BackgroundImage = config.configurarBotoes("SALVAR", "N");
        }
    }
}
