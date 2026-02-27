using SistemaUnifev.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUnifev.Negocio
{
    public class AlunoDAO
    {
        public List<Aluno> ListarFake(int qntd = 10)
        {
            List<Aluno> alunos = new List<Aluno>();

            var rand = new Random();
            for (int  i = 0;  i < qntd;  i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = i+1;
                aluno.Nome = $"Aluno {aluno.Id}";
                aluno.Telefone = rand.Next(990000000, 999999999).ToString();
                aluno.DataNascimento =
                    Convert.ToDateTime(
                        rand.Next(1,28).ToString() +
                        "/" +
                        rand.Next(1,12).ToString() +
                        "/" +
                        rand.Next(1990, 2026));

                aluno.Ativo = aluno.Id % 2 == 0;
                alunos.Add(aluno);
            }

            return alunos;
        }
    }
}
