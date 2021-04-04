using CRUD.DAL;
using CRUD.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace CRUD.Controller
{
    public class ControlePrincipal
    {
        PrincipalDAO prinDAO;
        public String mensagem;
        public bool verificador;

        public ControlePrincipal()
        {
            mensagem = "";
            verificador = false;
        }

        public DataTable consultar()
        {
            prinDAO = new PrincipalDAO();

            if (prinDAO.mensagem.Equals(""))
            {
                return prinDAO.Consultar();
            }
            else
            {
                this.mensagem = prinDAO.mensagem;
                return null;
            }
        }

        internal void inserir(Cliente cli)
        {
            prinDAO = new PrincipalDAO();

            //Confere se o Cliente já existe no Banco de Dados
            if (prinDAO.VerificarCliente(cli.Nome, cli.Sobrenome))
            {
                this.mensagem = prinDAO.mensagem;
                this.verificador = prinDAO.verificador;
                MessageBox.Show(mensagem, "INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                prinDAO.Inserir(cli);
                this.mensagem = prinDAO.mensagem;
                this.verificador = prinDAO.verificador;

                if (verificador)
                {
                    MessageBox.Show(mensagem, "INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool excluir(String id)
        {
            prinDAO = new PrincipalDAO();
            bool pop = false;

            DialogResult opc = new DialogResult();
            opc = MessageBox.Show("Tem certeza que deseja excluir esse registro?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                prinDAO.Excluir(id); //EXCLUI O REGISTRO

                if (!prinDAO.mensagem.Equals(""))
                {
                    this.mensagem = prinDAO.mensagem;
                    this.verificador = prinDAO.verificador;

                    if (verificador)
                    {
                        MessageBox.Show(mensagem, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pop = true;
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pop = false;
                    }
                }
            }
            return pop;
        }

        internal void editar(Cliente cli)
        {
            prinDAO = new PrincipalDAO();
            prinDAO.Editar(cli);

            if (!prinDAO.mensagem.Equals(""))
            {
                this.mensagem = prinDAO.mensagem;
                this.verificador = prinDAO.verificador;
            }
        }

        public ArrayList consultarCliente(string pesquisa, string tipo)
        {
            prinDAO = new PrincipalDAO();
            ArrayList lista = new ArrayList();

            if (tipo.Equals("Código"))
            {
                lista = prinDAO.ConsultarID(pesquisa);
            }
            else if (tipo.Equals("Nome"))
            {
                lista = prinDAO.ConsultarTipo(pesquisa, tipo);
            }
            else if (tipo.Equals("Sobrenome"))
            {
                lista = prinDAO.ConsultarTipo(pesquisa, tipo);
            }


            this.mensagem = prinDAO.mensagem;

            if (mensagem.Equals(""))
            {
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}
