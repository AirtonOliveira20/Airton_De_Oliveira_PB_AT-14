using Airton_de_Oliveira_PB_AT;
using System.Diagnostics;

namespace Airton_de_Oliveira_PB_AT_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Curso curso = CriarCurso();


            ExibirAluno(curso);

            ExibirGrade(curso);

        }

        public static void AdicionarAluno(Curso curso)
        {
            curso.AddAluno(new Aluno(20, "Matheus"));
            curso.AddAluno(new Aluno(21, "Alberto"));
            curso.AddAluno(new Aluno(22, "Fernando"));
            curso.AddAluno(new Aluno(23, "Elon"));
            curso.AddAluno(new Aluno(24, "Bill"));

        }


        public static Curso CriarCurso()
        {
            Curso curso = new Curso(1, "Engenharia de Software");
            AdicionarAluno(curso);

            Grade grade1 = CriarGrade();

            curso.Grade = grade1;

            return curso;
        }



        public static Grade CriarGrade()
        {
            Grade grade = new Grade(200, "Grade de teste");

            grade.AddDisciplina(new Disciplina(100, "Java"));
            grade.AddDisciplina(new Disciplina(101, "Csharp"));
            grade.AddDisciplina(new Disciplina(103, "Projeto de Bloco"));

            return grade;

        }

        public static void ExibirAluno(Curso curso)
        {
            Console.WriteLine(curso.ExibirAlunos());

        }

        public static void ExibirGrade(Curso curso)
        {
            Console.WriteLine(curso.ExibirGrade());

        }




    }
}
