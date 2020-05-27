using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ProjetoDS_2020
{
    public class DTO_Cadastro
    {
        public int idCadastro { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string senha { get; set; }
        public string confSenha { get; set; }
        public string CPF { get; set; }
    }
}
