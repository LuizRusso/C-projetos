using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOne.Mapeamento
{
    /// <summary>
    /// Classe de mapeamento do aluno
    /// </summary>
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                return DateTime.Today.Year - DataNascimento.Year;
            }
        }

        public bool Ativo { get; set; }
    }
}