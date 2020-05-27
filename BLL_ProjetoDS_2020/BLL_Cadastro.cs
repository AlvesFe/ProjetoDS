using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjetoDS_2020;
using DTO_ProjetoDS_2020;

namespace BLL_ProjetoDS_2020
{
    public class BLL_Cadastro
    {
        public static string ValidarCadastro(DTO_Cadastro obj)
        {
            if (string.IsNullOrWhiteSpace(obj.nome))
            {
                throw new Exception("Campo nome vazio!");
            }
            if (string.IsNullOrWhiteSpace(obj.userName))
            {
                throw new Exception("Campo Usuário vazio!");
            }
            if (obj.userName.Length < 6)
            {
                throw new Exception("Campo usuário deve ter ao minimo 6 caracteres!");
            }
            if (string.IsNullOrWhiteSpace(obj.email))
            {
                throw new Exception("Campo e-mail vazio!");
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                throw new Exception("Campo CPF vazio!");
            }
            if (obj.CPF.Length != 14)
            {
                throw new Exception("Campo CPF deve conter 11 numeros!");
            }
            if (string.IsNullOrWhiteSpace(obj.senha))
            {
                throw new Exception("Campo senha vazio!");
            }
            if (obj.senha.Length < 8)
            {
                throw new Exception("Campo senha deve ter ao minimo 8 caracteres!");
            }
            if (string.IsNullOrWhiteSpace(obj.confSenha))
            {
                throw new Exception("Campo confirmar senha vazio!");
            }
            if (obj.senha != obj.confSenha)
            {
                throw new Exception("Campo senha e confirmar senha não conferem!");
            }

            return DAL_Cadastro.ValidarCadastro(obj);
        }
    }
}
