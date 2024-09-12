using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_jogos_forms.DAO
{
    internal class ConexaoBD
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LUAN-REIS\\MSSQLSERVER01; Database=LP1; integrated security=true";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            // MessageBox.Show("Conexão bem-sucedida!");
            return conexao;
        }
    }
}
