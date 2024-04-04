using Airton_de_Oliveira_PB_AT_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Curso
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Grade Grade { get; set; }

        List<Aluno> Alunos = new List<Aluno>();



        public Curso(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public string ExibirAlunos()
        {
            StringBuilder resposta = new StringBuilder();

            foreach (Aluno aux in Alunos)
            {
                resposta.Append(aux.ToString());

            }
            return $"Nome do curso: {Nome}\nAlunos matriculados: \n{resposta.ToString()}";
        }

        public string ExibirGrade()
        {

            return $"==========\n\nNome do curso: {Nome}\nDisciplinas alocadas: \n{Grade.ToString()}";

        }

        public void AdicionarGrade(Grade grade)
        {
            Grade = grade;

        }

    }
}
