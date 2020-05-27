﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_ProjetoDS_2020
{
    public class Conexao
    {

        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoDS_2020;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Não foi possivel conectar ao banco de dados");
            }
        }

    }
}
