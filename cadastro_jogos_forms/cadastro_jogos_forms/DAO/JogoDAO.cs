using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastro_jogos_forms.Models;

namespace cadastro_jogos_forms.DAO
{
    internal class JogoDAO
    {
        private SqlParameter[] CriaParametros(JogoViewModel jogo)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", jogo.Id);
            parametros[1] = new SqlParameter("descricao", jogo.Descricao);
            parametros[2] = new SqlParameter("valor_locacao", jogo.ValorLocacao);
            parametros[3] = new SqlParameter("categoriaID", jogo.CategoriaId);
            parametros[4] = new SqlParameter("data_aquisicao", jogo.DataAquisicao);
            return parametros;
        }

        /// <summary>
        /// Insere um jogo no banco de dados
        /// </summary>
        public void Inserir(JogoViewModel Jogo)
        {
            string sql =
            "insert into jogos(id, descricao, valor_locacao, data_aquisicao, categoriaID) " +
            "values ( @id, @descricao, @valor_locacao, @data_aquisicao, @categoriaID)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(Jogo));
        }

        /// <summary>
        /// Altera um jogo no banco de dados
        /// </summary>
        public void Alterar(JogoViewModel Jogo)
        {
            string sql =
            "update jogos set descricao=@descricao, valor_locacao=@valor_locacao, " +
            "categoriaID=@categoriaID, data_aquisicao=@data_aquisicao where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(Jogo));
        }

        /// <summary>
        /// Exclui um jogo no banco de dados.
        /// </summary>
        public void Excluir(int id)
        {
            string sql = "delete jogos where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        /// <summary>
        /// Recebe uma registro e e preenche um objeto JogoVO
        /// </summary>
        /// <param name="registro">1 registro (linha) do DataTable</param>
        /// <returns>Objeto com os atributos preenchidos</returns>
        public static JogoViewModel MontaModel(DataRow registro)
        {
            JogoViewModel Jogo = new JogoViewModel();
            Jogo.Id = Convert.ToInt32(registro["id"]);
            Jogo.Descricao = registro["descricao"].ToString();
            Jogo.CategoriaId = Convert.ToInt32(registro["categoriaID"]);
            Jogo.ValorLocacao = Convert.ToDouble(registro["valor_locacao"]);
            Jogo.DataAquisicao = Convert.ToDateTime(registro["data_aquisicao"]);
            return Jogo;
        }


        /// <summary>
        /// Consulta um jogo com base eu seu id
        /// </summary>
        /// <param name="id">id do jogo</param>
        public JogoViewModel Consulta(int id)
        {
            string sql = "select * from jogos where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }



    }
}
