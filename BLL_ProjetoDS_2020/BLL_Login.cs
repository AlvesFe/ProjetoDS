using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS_2020;
using DAL_ProjetoDS_2020;

namespace BLL_ProjetoDS_2020
{
    public class BLL_Login
    {
        public static string ValidarLogin(DTO_Login obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Usuario))
            {
                throw new Exception("Campo usuário vazio!");
            }
            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                throw new Exception("Campo senha vazio!");
            }

            return DAL_Login.ValidarLogin(obj);
        }
    }
}
