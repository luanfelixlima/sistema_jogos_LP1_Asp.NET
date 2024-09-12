using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_jogos_forms.Models
{
    internal class JogoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorLocacao { get; set; }
        public int CategoriaId { get; set; }
        public DateTime DataAquisicao { get; set; }
    }
}
