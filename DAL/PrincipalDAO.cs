using CRUD.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;

namespace CRUD.DAL
{

    class PrincipalDAO : IDisposable
    {
        private ConexaoDAO con;
        private MySqlCommand cmd;
        private DataTable rd;
        private MySqlDataReader dr;
        private MySqlDataAdapter dAP;
        private Cliente cli;
        public String mensagem;
        public bool verificador;

        public PrincipalDAO()
        {
            this.mensagem = "";
            this.verificador = false;
        }

        public DataTable Consultar()
        {
            con = new ConexaoDAO();
            rd = new DataTable();

            String sql = "select * from Cliente";

            try
            {
                con.conectar();
                dAP = new MySqlDataAdapter(sql, con.sqlConexao);
                dAP.Fill(rd);

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
            return rd;
        }


        public ArrayList ConsultarID(string pesquisa)
        {
            string verifica = "^[0-9]";
            int id;

            if (Regex.IsMatch(pesquisa, verifica))
            {
                id = int.Parse(pesquisa);

                con = new ConexaoDAO();
                cmd = new MySqlCommand();

                cli = new Cliente();
                ArrayList listaClientes = new ArrayList();

                cmd.CommandText = "select * from Cliente where Id = @id";
                cmd.Parameters.AddWithValue("@id", pesquisa);

                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cli.Id = dr[0].ToString();
                            cli.Nome = dr[1].ToString();
                            cli.Sobrenome = dr[2].ToString();

                            listaClientes.Add(cli);
                        }

                        return listaClientes;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (MySqlException)
                {
                    this.mensagem = "Erro ao fazer a consulta no banco!";
                    return null;
                }
                finally
                {
                    con.desconectar();
                    dr.Close();
                }
            }
            else
            {
                this.mensagem = "Erro ao fazer a consulta no banco!";
                return null;
            }
        }


        public bool VerificarCliente(string nome, string sobrenome)
        {
            con = new ConexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "select * from Cliente where Nome =@nome and Sobrenome =@sobrenome";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "Já existe um registro com os mesmos dados!";
                    this.verificador = false;
                    return true;
                }
                else
                {
                    this.verificador = true;
                    return false;
                }
            }
            catch (MySqlException)
            {

                this.mensagem = "Erro ao fazer a consulta no banco!";
                return false;
            }
            finally
            {
                con.desconectar();
                dr.Close();
            }
        }

        public ArrayList ConsultarTipo(string pesquisa, string tipo)
        {
            con = new ConexaoDAO();
            cmd = new MySqlCommand();


            ArrayList listaClientes = new ArrayList();

            try
            {
                if (tipo.Equals("Nome"))
                {
                    cmd.CommandText = "select * from Cliente where Nome LIKE'%" + "@nome" + "%' order by Nome";
                    cmd.Parameters.AddWithValue("@nome", pesquisa);
                }
                else if (tipo.Equals("Sobrenome"))
                {
                    cmd.CommandText = "select * from Cliente where Sobrenome LIKE'%" + "@sobrenome" + "%' order by Nome";
                    cmd.Parameters.AddWithValue("@sobrenome", pesquisa);
                }

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cli = new Cliente();
                        cli.Id = dr[0].ToString();
                        cli.Nome = dr[1].ToString();
                        cli.Sobrenome = dr[2].ToString();

                        listaClientes.Add(cli);
                    }

                    return listaClientes;
                }
                else
                {
                    return null;
                }

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao fazer a consulta no banco!";
                return null;
            }
            finally
            {
                con.desconectar();
                dr.Close();
            }
        }

        public void Inserir(Cliente cli)
        {
            con = new ConexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "insert into Cliente (Nome, Sobrenome) values (@nome, @sobrenome)";
            cmd.Parameters.AddWithValue("@nome", cli.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", cli.Sobrenome);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                this.mensagem = "Cadastrado com sucesso!";
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

        public void Editar(Cliente cli)
        {
            con = new ConexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "update Cliente set Nome=@nome, Sobrenome=@sobrenome where Id =@id";
            cmd.Parameters.AddWithValue("@nome", cli.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", cli.Sobrenome);
            cmd.Parameters.AddWithValue("@id", cli.Id);

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
                cmd.CommandText = @"delete from Cliente where Id = @id";
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
                    con = null;
                    cmd = null;
                    rd = null;
                    dr = null;
                    dAP = null;
                    cli = null;
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.



                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~PrincipalDAO() {
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
