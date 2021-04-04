using CRUD.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL
{
    public class LoginDAO : IDisposable
    {
        public bool verificador = false;
        public String mensagem = "";
        private MySqlCommand cmd;
        private ConexaoDAO con;
        private MySqlDataReader rd;
        private DataTable dt;
        private MySqlDataAdapter dAP;

        public Boolean verificaLogin(String user, String pass)
        {
            cmd = new MySqlCommand();
            con = new ConexaoDAO();

            cmd.CommandText = "select * from Login where Usuario = @user and Senha = @pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            try
            {
                cmd.Connection = con.conectar();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    verificador = true;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao conectar com o banco de dados.";
            }

            return verificador;
        }

        public bool verificarUser(String user)
        {
            cmd = new MySqlCommand();
            con = new ConexaoDAO();

            cmd.CommandText = "select * from Login where Usuario = @user";
            cmd.Parameters.AddWithValue("@user", user);

            try
            {
                cmd.Connection = con.conectar();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    verificador = false;
                    this.mensagem = "Esse usuário já existe!";
                }
                else
                {
                    verificador = true;
                }

                con.desconectar();
                rd.Dispose();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao conectar com o banco de dados.";
            }

            return verificador;
        }

        public DataTable Consultar()
        {
            con = new ConexaoDAO();
            dt = new DataTable();

            String sql = "select * from Login";

            try
            {
                con.conectar();
                dAP = new MySqlDataAdapter(sql, con.sqlConexao);
                dAP.Fill(dt);

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao fazer a consulta no banco!";
                return null;
            }
            finally
            {
                con.desconectar();
            }
            return dt;
        }

        public String cadastrarLogin(String user, String pass)
        {
            cmd = new MySqlCommand();
            con = new ConexaoDAO();

            cmd.CommandText = "insert into Login (Usuario, Senha) values (@user,@pass)";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                this.mensagem = "Usuário cadastrado com sucesso!";
                this.verificador = true;

                con.desconectar();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao conectar com o banco de dados";
            }

            return mensagem;
        }

        internal void Editar(Usuario user)
        {
            con = new ConexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "update Login set Usuario=@user, Senha=@pass where Id = @id";
            cmd.Parameters.AddWithValue("@user", user.User);
            cmd.Parameters.AddWithValue("@pass", user.Pass);
            cmd.Parameters.AddWithValue("@id", user.Id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                this.mensagem = "Alteração realizada com sucesso!";
                this.verificador = true;
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao fazer a consulta no banco!";
            }
            finally
            {
                con.desconectar();
            }
        }

        public void Excluir(String i)
        {
            int id = int.Parse(i);

            con = new ConexaoDAO();
            cmd = new MySqlCommand();

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = @"delete from Login where Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                this.mensagem = "Registro excluído com sucesso!";
                verificador = true;
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao conectar com o banco.";
            }
            finally
            {
                con.desconectar();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                    rd = null;
                    con = null;
                    cmd = null;
                    dt = null;
                    dAP = null;
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~LoginDAO() {
        //   // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
        //   Dispose(false);
        // }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
