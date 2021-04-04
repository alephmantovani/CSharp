using CRUD.Controller;
using CRUD.Model;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace CRUD.View
{
    public partial class Principal : Form
    {
        ConfigurarSistema config;
        String mensagem;
        public static String user;
        
        DataTable result;
        ControlePrincipal contPrinc;
        Cliente cli;
        
        public delegate void AtualizarDataHoraAtual(Control componente, string propriedades, object valor);
        private Thread t;

        public Principal()
        {
            InitializeComponent();
            config = new ConfigurarSistema();

            //Inspeção da Thread para atualizar a data e hora
            t = new Thread(new ThreadStart(dataHoraAtualThread));
            t.IsBackground = true;

            mensagem = "";

            configurarUsuario();
        }

        private void configurarUsuario()
        {
            lbl_User.Text = config.configurarUsuario(user);
            lbl_HoraAtual.Text = config.dataHoraAtual();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            t.Start();
            popularLista();
        }

        /*---BOTAO INSERIR---
         * --EVENTOS DO MOUSE---*/
        private void pic_Inserir_Click(object sender, EventArgs e)
        {
            inserir();
        }
        private void pic_Inserir_MouseLeave(object sender, EventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("INSERIR", "N");
        }

        private void pic_Inserir_MouseEnter(object sender, EventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("INSERIR", "H");
        }

        private void pic_Inserir_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("INSERIR", "C");
        }

        private void pic_Inserir_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Inserir.BackgroundImage = config.configurarBotoes("INSERIR", "H");
        }

        /*---BOTAO EDITAR---
         * --EVENTOS DO MOUSE---*/
        private void pic_Editar_MouseEnter(object sender, EventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "H");
        }

        private void pic_Editar_MouseLeave(object sender, EventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "N");
        }


        private void pic_Editar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void pic_Editar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "C");
        }

        private void pic_Editar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "H");
        }


        /*---BOTAO EXCLUIR---
         * --EVENTOS DO MOUSE---*/
        private void pic_Excluir_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void pic_Excluir_MouseLeave(object sender, EventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "N");
        }


        private void pic_Excluir_MouseEnter(object sender, EventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "H");
        }

        private void pic_Excluir_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "C");
        }

        private void pic_Excluir_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "H");
        }


        /*---BOTAO BUSCAR---
         * --EVENTOS DO MOUSE---*/
        private void pic_Buscar_Click(object sender, EventArgs e)
        {
            ConsultarCliente cliente = new ConsultarCliente(this);
            cliente.Show();
        }

        private void pic_Buscar_MouseEnter(object sender, EventArgs e)
        {
            pic_Buscar.BackgroundImage = config.configurarBotoes("BUSCAR", "H");

        }

        private void pic_Buscar_MouseLeave(object sender, EventArgs e)
        {
            pic_Buscar.BackgroundImage = config.configurarBotoes("BUSCAR", "N");
        }

        private void pic_Buscar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Buscar.BackgroundImage = config.configurarBotoes("BUSCAR", "C");
        }

        private void pic_Buscar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Buscar.BackgroundImage = config.configurarBotoes("BUSCAR", "H");
        }


        /*EVENTOS
         * DO LINK
         */
        private void link_Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void link_NovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarUsuario novoU = new ConsultarUsuario("INSERIR");
            novoU.Show();
        }

        private void link_Consultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarUsuario consU = new ConsultarUsuario("EDITAR");
            consU.Show();
        }

        private void inserir()
        {
            //Chama o Form para Inserir o cadastro
            DadosCliente ins = new DadosCliente(this);
            ins.Show();
        }

        private void excluir()
        {
            cli = new Cliente();

            if (listView.SelectedItems.Count > 0)
            {
                cli.Id = listView.SelectedItems[0].SubItems[0].Text;

                contPrinc = new ControlePrincipal();
                bool pop = contPrinc.excluir(cli.Id);
                
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


        private void editar()
        {
            cli = new Cliente();

            if (listView.SelectedItems.Count > 0)
            {
                cli.Id = listView.SelectedItems[0].SubItems[0].Text;
                cli.Nome = listView.SelectedItems[0].SubItems[1].Text;
                cli.Sobrenome = listView.SelectedItems[0].SubItems[2].Text;

                //Form para Alterar os dados
                DadosCliente edit = new DadosCliente(cli.Id, cli.Nome, cli.Sobrenome, this);
                edit.Show();
            }
            else
            {
                MessageBox.Show("Não há linha selecionada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void popularLista()
        {
            contPrinc = new ControlePrincipal();
            ListViewItem item;
            listView.Items.Clear();

            try
            {

                result = contPrinc.consultar();
                this.mensagem = contPrinc.mensagem;

                if (mensagem.Equals(""))
                {
                    foreach (DataRow linha in result.Rows)
                    {
                        item = new ListViewItem(linha.ItemArray.ElementAt(0).ToString());
                        item.SubItems.Add(linha.ItemArray.ElementAt(1).ToString());
                        item.SubItems.Add(linha.ItemArray.ElementAt(2).ToString());
                        listView.Items.Add(item);
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


        public void dataHoraAtualThread()
        {
            while (true) atualizarDataHoraAtual(lbl_HoraAtual, "Text", DateTime.Now.ToString());
        }


        public void atualizarDataHoraAtual(Control componente, string propriedades, object valor)
        {
            if (componente.InvokeRequired)
            {
                AtualizarDataHoraAtual delegado = new AtualizarDataHoraAtual(atualizarDataHoraAtual);
                componente.Invoke(delegado, new object[] { componente, propriedades, valor });
            }
            else
            {
                Type t = componente.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propriedades.ToUpper())
                    {
                        p.SetValue(componente, valor, null);
                    }
                }
            }
        }

        
    }
}
