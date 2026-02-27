using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUnifev.Mapeamento
{
    /// <summary>
    /// Classe de mapeamento do aluno, para o banco de dados.
    /// </summary>
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }
        }
        public Boolean Ativo { get; set; }
    }
}
