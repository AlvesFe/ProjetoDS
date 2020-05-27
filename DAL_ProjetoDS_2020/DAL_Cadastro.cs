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
    public class DAL_Cadastro
    {
        public static string ValidarCadastro(DTO_Cadastro obj)
        {
			try
			{
                string script = "INSERT INTO Usuario(nome, email, userName, senha, CPF) VALUES (@nome, @email, @userName, @senha, @CPF)";

                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());

                cm.Parameters.AddWithValue("@nome", obj.nome);
                cm.Parameters.AddWithValue("@email", obj.email);
                cm.Parameters.AddWithValue("@userName", obj.userName);
                cm.Parameters.AddWithValue("@senha", obj.senha);
                cm.Parameters.AddWithValue("@CPF", obj.CPF);
                cm.ExecuteNonQuery();

                return "Cadastro realizado com sucesso!";
            }
            catch (Exception ex)
			{

				throw new Exception("Erro de conexão, contate o suporte! " + ex.Message);
			}
            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
