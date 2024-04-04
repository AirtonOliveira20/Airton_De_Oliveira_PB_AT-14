using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Grade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public List<Disciplina> Disciplinas;

        public Grade(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }

        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public override string ToString()
        {
            StringBuilder resposta = new StringBuilder();

            foreach (Disciplina aux in Disciplinas)
            {
                resposta.Append(aux.ToString());

            }
            return $"{resposta.ToString()}";
        }


    }
}
