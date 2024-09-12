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

        // Impede do usu�rio receber erros por preenchimento errado
        public void ValidaJogo(JogoViewModel a)
        {
            if (a.Id < 0)
                throw new Exception("Id n�o pode ser negativo!");
            if (string.IsNullOrEmpty(a.Descricao))
                throw new Exception("Informe a descri��o!");
            if (a.ValorLocacao < 0)
                throw new Exception("Valor da loca��o n�o pode ser negativa!");
            if (a.CategoriaId <= 0)
                throw new Exception("C�digo da categoria n�o ser negativo!");
            if (a.DataAquisicao > DateTime.Now)
                throw new Exception("Data de Aquisi��o inv�lida!");
        }

        // Converte os valores recebidos em propriedades do objeto
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

        // Inserir os dados no DB
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

        // Alterar os dados no DB
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

        // Excluir os dados no DB
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dao.Excluir(Convert.ToInt32(id.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void PreencheTela(JogoViewModel a)
        {
            if (a != null)
            {
                id.Text = a.Id.ToString();
                descricao.Text = a.Descricao;
                categoria.Text = a.CategoriaId.ToString();
                data.Text = a.DataAquisicao.ToShortDateString();
                valor.Text = a.ValorLocacao.ToString();
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                JogoViewModel a = dao.Consulta(Convert.ToInt32(id.Text));
                if (a != null)
                    PreencheTela(a);
                else
                    MessageBox.Show("Registro n�o encontrado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                List<JogoViewModel> jogos = dao.ConsultaGeral();
                string jogosStr = "";
                if (jogos != null)
                {
                    foreach (JogoViewModel jogo in jogos)
                    {
                        jogosStr += dao.JogoString(jogo);
                    }
                    MessageBox.Show(jogosStr);
                }
                else
                    MessageBox.Show("Registro n�o encontrado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
