using DemoLinq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                    new Aluno()
                    {
                        Nome = "Maria",
                        Idade = 25,
                        Id = 1
                    },
                    new Aluno()
                    {
                        Nome = "Pedro",
                        Idade = 18,
                        Id = 2
                    },
                    new Aluno()
                    {
                        Nome = "Amanda",
                        Idade = 27,
                        Id = 3
                    },
            };

            var pedro = new Aluno()
            {
                Nome = "Pedro",
                Idade = 18
            };

            Dictionary<string, Aluno> aluno = new Dictionary<string, Aluno>();

            aluno.Add("Acesso Liberado", pedro);

        }
    }



    class Pessoa
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
    }

    class Aluno : Pessoa
    {
        public Aluno()
        {
        }
    }

    class Professor : Pessoa
    {
        public List<Aluno> Alunos { get; set; }

        public Professor()
        {
        }

        public Professor(List<Aluno> alunos)
        {
            Alunos = alunos;
        }
    }
}