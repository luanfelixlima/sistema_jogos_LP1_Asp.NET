using System.Xml.Linq;
using cadastro_jogos_forms.DAO;
using cadastro_jogos_forms.Models;

namespace cadastro_jogos_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ValidaJogo(JogoViewModel a)
        {
            if (a.Id < 0)
                throw new Exception("Id não pode ser negativo!");
            if (string.IsNullOrEmpty(a.Descricao))
                throw new Exception("Informe a descrição!");
            if (a.ValorLocacao < 0)
                throw new Exception("Valor da locação não pode ser negativa!");
            if (a.CategoriaId <= 0)
                throw new Exception("Código da categoria não ser negativo!");
            if (a.DataAquisicao > DateTime.Now)
                throw new Exception("Data de Aquisição inválida!");
        }


        private JogoViewModel PreencheDadosVO()
        {
            JogoViewModel Jogo = new JogoViewModel();
            Jogo.Id = Convert.ToInt32(id.Text);
            Jogo.CategoriaId = Convert.ToInt32(categoria.Text);
            Jogo.ValorLocacao = Convert.ToDouble(valor.Text);
            Jogo.Descricao = descricao.Text;
            Jogo.DataAquisicao = Convert.ToDateTime(data.Text);
            return Jogo;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencheDadosVO();
                ValidaJogo(jogo);
                JogoDAO dao = new JogoDAO();
                dao.Inserir(jogo);
                MessageBox.Show("Inserido com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencheDadosVO();
                ValidaJogo(jogo);
                JogoDAO dao = new JogoDAO();
                dao.Alterar(jogo);
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dao.Excluir(Convert.ToInt32(id.Text));
                MessageBox.Show("Excluído com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
