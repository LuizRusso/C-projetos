using SistemaOne.Mapeamento;
using System;
using System.Collections.Generic;

namespace SistemaOne.Negocio
{
    public class AlunoDAO
    {
        public List<Aluno> ListarFake(int qtde = 10)
        {
            List<Aluno> alunos = new List<Aluno>();
            var rand = new Random();

            for (int i = 1; i <= qtde; i++)
            {
                Aluno aluno = new Aluno();

                aluno.Id = i;
                aluno.Nome = "Aluno " + aluno.Id;
                aluno.Telefone = rand.Next(990000000, 999999999).ToString();

                aluno.DataNascimento = new DateTime(
                    rand.Next(1900, 2026),
                    rand.Next(1, 13),
                    rand.Next(1, 28)
                );

                aluno.Ativo = aluno.Id % 2 == 0;

                alunos.Add(aluno);
            }

            return alunos;
        }
    }
}