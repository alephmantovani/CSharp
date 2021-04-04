using CRUD.DAL;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Controller
{
    public class ControleLogin
    {
        public bool verificador = false;
        public String mensagem = "";
        private LoginDAO loginDAO;

        public bool acessar(String user, String pass)
        {
            loginDAO = new LoginDAO();

            verificador = loginDAO.verificaLogin(user, pass);

            if (!loginDAO.mensagem.Equals(""))
            {
                this.mensagem = loginDAO.mensagem;
            }

            return verificador; ;
        }

        public DataTable consultarUsuario()
        {
            loginDAO = new LoginDAO();

            if (loginDAO.mensagem.Equals(""))
            {
                return loginDAO.Consultar();
            }
            else
            {
                this.mensagem = loginDAO.mensagem;
                return null;
            }
        }

        public String cadastrar(String user, String pass) 
        {
            loginDAO = new LoginDAO();

            verificador = loginDAO.verificarUser(user);

            if (verificador)
            {
                loginDAO.cadastrarLogin(user, pass);
                this.mensagem = loginDAO.mensagem;
                this.verificador = loginDAO.verificador;
            }
            else
            {
                this.mensagem = loginDAO.mensagem;
                this.verificador = loginDAO.verificador;
            }

            return mensagem;
        }

        internal void editar(Usuario user)
        {
            loginDAO = new LoginDAO();
            loginDAO.Editar(user);

            if (!loginDAO.mensagem.Equals(""))
            {
                this.mensagem = loginDAO.mensagem;
                this.verificador = loginDAO.verificador;
            }
            
        }

        public bool confirmSenha(String pass, String confirmPass) => pass.Equals(confirmPass);
        

        public bool excluir(String id)
        {
            loginDAO = new LoginDAO();
            bool pop = false;

            DialogResult opc = new DialogResult();
            opc = MessageBox.Show("Tem certeza que deseja excluir esse registro?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                loginDAO.Excluir(id); //EXCLUI O REGISTRO

                if (!loginDAO.mensagem.Equals(""))
                {
                    this.mensagem = loginDAO.mensagem;
                    this.verificador = loginDAO.verificador;

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

    }
}
