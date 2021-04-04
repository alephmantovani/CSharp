using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD.Controller
{
    public class ConfigurarSistema
    {
        Image bot;
        string pasta_Imagens;

        public ConfigurarSistema()
        {
        }

        public String dataHoraAtual()
        {
            return DateTime.Now.ToString();
        }


        public String configurarUsuario(String user)
        {
            if (user != null)
            {
                return "Olá, " + user.ToUpper() + "!";
            }
            else
            {
                return "Olá, Usuário!";
            }
        }

       
        public Image configurarBotoes(String botao, String estado)
        {
            //Configurar o caminho da pasta imagens dos botoes
            pasta_Imagens = Application.StartupPath + @"\Imagens\";

            try
            {
                switch (botao)
                {
                    case "INSERIR":
                        //Botão INSERIR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Inserir.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Inserir.png");
                        }
                        else if (estado.Equals("D"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Disable_Inserir.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Inserir.png");
                        }

                        break;
                    case "EDITAR":
                        //Botão EDITAR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Editar.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Editar.png");
                        }
                        else if (estado.Equals("D"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Disable_Editar.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Editar.png");
                        }

                        break;
                    case "EXCLUIR":
                        //Botão EXCLUIR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Excluir.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Excluir.png");
                        }
                        else if (estado.Equals("D"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Disable_Excluir.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Excluir.png");
                        }

                        break;
                    case "BUSCAR":
                        //Botão BUSCAR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Buscar.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Buscar.png");
                        }
                        if (estado.Equals("D"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Disable_Buscar.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Buscar.png");
                        }

                        break;
                    case "SALVAR":
                        //Botão SALVAR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Salvar.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Salvar.png");
                        }
                        else if (estado.Equals("D"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Disable_Salvar.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Salvar.png");
                        }

                        break;
                    case "SAIR":
                        //Botão SAIR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Sair.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Sair.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Sair.png");
                        }

                        break;
                    case "ENTRAR":
                        //Botão ENTRAR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Normal_Entrar.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_High_Entrar.png");
                        }
                        else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "botao_Click_Entrar.png");
                        }

                        break;
                    case "PESQUISAR":
                        //Botão PESQUISAR

                        if (estado.Equals("N"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "Pesquisa.png");
                        }
                        else if (estado.Equals("H"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "PesquisaHigh.png");
                        }else if (estado.Equals("C"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "PesquisaClick.png");
                        }
                        break;
                    case "PASS":
                        //Botão PASSWORD

                        if (estado.Equals("A"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "olhoPassTrue.png");
                        }
                        else if (estado.Equals("F"))
                        {
                            bot = Image.FromFile(pasta_Imagens + "olhoPassFalse.png");
                        }
                        
                        break;
                    default:
                        bot = null;
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro no Switch" + "-"+botao +"-"+ estado);
            }
            return bot;
        }

    }

}
