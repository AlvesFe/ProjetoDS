using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_ProjetoDS_2020;

namespace DAL_ProjetoDS_2020
{
    public class DAL_Login
    {
        public static string ValidarLogin(DTO_Login obj)
        {
            try
            {
                string script = "SELECT * FROM Usuario WHERE(userName = @login OR email = @login)" +
                    "AND senha = @senha";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //sempre nessa ordem, chamando o metodo de conectar
                cm.Parameters.AddWithValue("@login", obj.Usuario);
                cm.Parameters.AddWithValue("@senha", obj.Senha);
                //substitui as variaveis na instruçao sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a intruçao sql e atribui resultado no SqlDataReader

                while (dados.Read())
                //le a proxima linha do resultado da sua instruçao
                {
                    if (dados.HasRows)
                    //se der certo vai aparecer a message de conexao feita
                    {
                        return "login realizado com sucesso!";
                    }

                }
                throw new Exception("Usuário ou senha inválidos!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão, contate o suporte! " + ex.Message);
            }
            finally //finally acontece independente se acontece o try ou catch
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                //testando o estado da conexao, se é diferente de fechado
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
