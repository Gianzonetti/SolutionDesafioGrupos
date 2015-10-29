using DesafioOrganizarGrupos.Classes;
using System;
using System.Collections.Generic;

namespace DesafioAlunos.Classes
{
    public static class AlunoOperation
    {

        /// <summary>
        /// Cria um objeeto de aluno.
        /// </summary>
        /// <param name="aluno"></param>
        /// <param name="i"></param>
        public static void AddAluno(Aluno aluno, int i)
        {
            do
            {
                Console.WriteLine("Informe o nome do {0}° aluno: ", i + 1);
                aluno.Nome = Console.ReadLine();
            } while (aluno.Nome == string.Empty);
        }


        /// <summary>
        /// Organiza os alunos nos grupos
        /// </summary>
        /// <param name="turma"></param>
        /// <param name="grupos"></param>
        /// <param name="numeroDeGrupos"></param>

        public static void OrganizaGrupos(List<Aluno> turma, List<Aluno>[] grupos, int numeroDeGrupos)
        {
            Random rand = new Random();
            int idGrupo = 0;

            Stack<int> pilha = new Stack<int>();
            foreach (var item in turma)
            {
                do
                {
                    idGrupo = rand.Next(numeroDeGrupos);
                } while (!NaoRepetirRandom(idGrupo, pilha, numeroDeGrupos));

                grupos[idGrupo].Add(item);


            }
        }


        /// <summary>
        /// Vai adicionar os alunos dentro da lista Turma.
        /// </summary>
        /// <param name="numeroDeAluno"></param>
        /// <param name="turma"></param>
        public static void AddAlunoTurma(int numeroDeAluno, List<Aluno> turma)
        {
            for (int i = 0; i < numeroDeAluno; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Nome = string.Empty;

                Console.Clear();

                AlunoOperation.AddAluno(aluno, i);

                turma.Add(aluno);
            }
        }


        /// <summary>
        /// Validação para o random não repetir numero do grupo.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="pilha"></param>
        /// <param name="numeroDeGrupos"></param>
        /// <returns></returns>
        public static bool NaoRepetirRandom(int i, Stack<int> pilha, int numeroDeGrupos)
        {

            if (pilha.Count == numeroDeGrupos)
                pilha.Clear();

            if (pilha.Contains(i))
                return false;
            else
                pilha.Push(i);
            return true;
        }


    }
}

