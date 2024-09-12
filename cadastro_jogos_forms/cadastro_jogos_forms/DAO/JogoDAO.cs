using System;
using System.Collections.Generic;
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
        /// Exclui um aluno no banco de dados.
        /// </summary>
        public void Excluir(int id)
        {
            string sql = "delete jogos where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }
    }
}
