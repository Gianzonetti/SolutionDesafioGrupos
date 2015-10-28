using DesafioAlunos.Classes;
using DesafioOrganizarGrupos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlunos
{
    class Program
    {

        static void Main(string[] args)
        {
            int numeroDeAluno = 0;
            List<Aluno> turma = new List<Aluno>();


            // Informando quantos alunos vai ter na turma
            do
            {
                Console.WriteLine("Informe a quantidade de alunos na turma: ");
                numeroDeAluno = int.Parse(Console.ReadLine());
            } while (numeroDeAluno <= 0);

            // Adicionando os alunos
            AlunoOperation.AddAlunoTurma(numeroDeAluno, turma);

            // Vai informar o numero de grupos que quer.
            int numeroDeGrupos = 0;
            Console.Clear();

            do
            {
                Console.WriteLine("Informe o numero de grupos que deseja formar: ");
                numeroDeGrupos = int.Parse(Console.ReadLine());
            } while (numeroDeGrupos <= 0);

            List<Aluno>[] grupos = new List<Aluno>[numeroDeGrupos];

            for (int i = 0; i < numeroDeGrupos; i++)
            {
                grupos[i] = new List<Aluno>();
            }
            // Separação dos alunos

            AlunoOperation.OrganizaGrupos(turma, grupos, numeroDeGrupos);

            // Apresentando os grupos

            ApresentarGrupos(numeroDeGrupos, grupos);

            Console.ReadKey();
        }



        /// <summary>
        ///  Apresenta os alunos pertencentes a cada grupo
        /// </summary>
        /// <param name="numeroDeGrupos"></param>
        /// <param name="grupos"></param>
        private static void ApresentarGrupos(int numeroDeGrupos, List<Aluno>[] grupos)
        {
            for (int i = 0; i < numeroDeGrupos; i++)
            {
                Console.WriteLine("\n -GRUPO {0} \n", i);
                foreach (var aluno in grupos[i])
                {
                    Console.WriteLine(aluno.Nome);
                }
            }
        }
    }
}
