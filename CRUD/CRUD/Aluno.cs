using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Aluno
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public int IdadeAluno { get; set; }
        
        public Aluno(int id, string nome, int idade)
        {
            IdAluno = id;
            NomeAluno = nome;
            IdadeAluno= idade;
        }
    }
}
