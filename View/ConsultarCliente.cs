using CRUD.Controller;
using CRUD.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD.View
{
    public partial class ConsultarCliente : Form
    {

        ConfigurarSistema config;
        ControlePrincipal contPrinc;
        Cliente cli;
        Principal principal;

        string tipo;
        string mensagem;
        DataTable resultDT;
        ArrayList lista;

        public ConsultarCliente(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;

            config = new ConfigurarSistema();
            mensagem = "";

            //Trazer a consulta
            consultaTodosClientes();
        }

        public void consultaTodosClientes()
        {
            contPrinc = new ControlePrincipal();
            ListViewItem item;
            listView.Items.Clear();

            resultDT = contPrinc.consultar();
            this.mensagem = contPrinc.mensagem;

            if (mensagem.Equals(""))
            {
                foreach (DataRow linha in resultDT.Rows)
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

        private void consultarCliente()
        {
            lista = new ArrayList();

            if (!txt_Pesquisar.Text.Equals(""))
            {
                ListViewItem item;
                listView.Items.Clear();
                lista = contPrinc.consultarCliente(txt_Pesquisar.Text, tipo);

                try
                {

                    if (lista.Count > 0)
                    {
                        foreach (Model.Cliente cli in lista)
                        {
                            item = new ListViewItem(cli.Id);
                            item.SubItems.Add(cli.Nome);
                            item.SubItems.Add(cli.Sobrenome);
                            listView.Items.Add(item);
                        }
                    }
                    else
                    {
                        this.mensagem = contPrinc.mensagem;
                        if (mensagem.Equals(""))
                        {
                            MessageBox.Show("Não há nenhum registro da pesquisa!", "CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não há nenhum registro da pesquisa!", "CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultaTodosClientes();
                }
            }
            else
            {
                consultaTodosClientes();
            }

            txt_Pesquisar.Clear(); //limpa o campo de pesquisa
        }

        private void editarCliente()
        {
            cli = new Cliente();

            if (listView.SelectedItems.Count > 0)
            {
                cli.Id = listView.SelectedItems[0].SubItems[0].Text;
                cli.Nome = listView.SelectedItems[0].SubItems[1].Text;
                cli.Sobrenome = listView.SelectedItems[0].SubItems[2].Text;

                DadosCliente edit = new DadosCliente(cli.Id, cli.Nome, cli.Sobrenome, this);
                edit.Show();
            }
            else
            {
                MessageBox.Show("Não há linha selecionada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void radioButtonSelect()
        {
            if (rd_ID.Checked)
            {
                tipo = rd_ID.Text;
            }
            else if (rd_Nome.Checked)
            {
                tipo = rd_Nome.Text;
            }
            else if (rd_Sobrenome.Checked)
            {
                tipo = rd_Sobrenome.Text;
            }
        }

        private void excluir()
        {
            if (listView.SelectedItems.Count > 0)
            {
                cli = new Model.Cliente();
                cli.Id = listView.SelectedItems[0].SubItems[0].Text;

                bool pop = contPrinc.excluir(cli.Id);

                if (pop)
                {
                    consultaTodosClientes();
                }

                //consultaCliente();
            }
            else
            {
                MessageBox.Show("Não há linha selecionada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*--EVENTO
         * --MOUSE
         * --RADIOBUTTON--*/
        private void rd_ID_Click(object sender, EventArgs e)
        {
            radioButtonSelect();
        }
        private void rd_Nome_Click(object sender, EventArgs e)
        {
            radioButtonSelect();
        }
        private void rd_Sobrenome_Click(object sender, EventArgs e)
        {
            radioButtonSelect();
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
            excluir();
        }



        /*--EVENTO
         * --MOUSE
         * --EDITAR--*/
        private void pic_Editar_Click(object sender, EventArgs e)
        {
            //Chamar o metodo para Editar
            editarCliente();
        }

        private void pic_Editar_MouseEnter(object sender, EventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "H");
        }

        private void pic_Editar_MouseLeave(object sender, EventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "N");
        }


        /*--EVENTO
         * --MOUSE
         * --PESQUISAR--*/
        private void pic_Pesquisar_MouseEnter(object sender, EventArgs e)
        {
            pic_Pesquisar.BackgroundImage = config.configurarBotoes("PESQUISAR", "H");
        }

        private void pic_Pesquisar_MouseLeave(object sender, EventArgs e)
        {
            pic_Pesquisar.BackgroundImage = config.configurarBotoes("PESQUISAR", "N");
        }

        private void pic_Pesquisar_Click(object sender, EventArgs e)
        {
            //Chamar a consulta
            consultarCliente();
        }

        private void pic_Pesquisar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Pesquisar.BackgroundImage = config.configurarBotoes("PESQUISAR", "C");
        }

        private void pic_Pesquisar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Pesquisar.BackgroundImage = config.configurarBotoes("PESQUISAR", "H");
        }


        /*--EVENTO
         * --MOUSE
         * --PESQUISAR--*/
        private void pic_Sair_Click(object sender, EventArgs e)
        {
            principal.popularLista();
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

        private void pic_Sair_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "C");
        }

        private void pic_Sair_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Sair.BackgroundImage = config.configurarBotoes("SAIR", "H");
        }

        private void pic_Editar_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "C");
        }

        private void pic_Editar_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Editar.BackgroundImage = config.configurarBotoes("EDITAR", "H");
        }

        private void pic_Excluir_MouseDown(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "C");
        }

        private void pic_Excluir_MouseUp(object sender, MouseEventArgs e)
        {
            pic_Excluir.BackgroundImage = config.configurarBotoes("EXCLUIR", "H");
        }
    }
}
