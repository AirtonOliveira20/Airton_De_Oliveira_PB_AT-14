﻿using Airton_de_Oliveira_PB_AT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }


        public override string ToString()
        {
            return $"\nNome: {Nome}\nMatricula: {Matricula}\n";
        }


    }
}
