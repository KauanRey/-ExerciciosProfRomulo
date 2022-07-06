using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolhinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exerícicio 2 - Crie na solution um novo projeto com o nome de ExerciciosProfRomulo.EscolinhaTicTic

             * Exercício 4 - Crie um programa para a escolinha Tic Tic
             calcular 3 notas de um aluno.
             Entrar com o nome do aluno e as três notas
             Mostrar a soma das notas e a média.

             * Exercício 5 - Considerando o exercício 4. A escolinha Tic Tic pediu para você verificar
             se o aluno foi aprovado ou reprovado.
             Considere a média >= 7 para que o aluno seja aprovado.
             */



            //declaração de variáveis
            string nomeDoAluno, resultado;
            double nota1, nota2, nota3;
            double media;

            //Entrada de Dados
            Console.WriteLine("Abençoado qual o seu nome:");
            nomeDoAluno = Console.ReadLine();
            Console.WriteLine("Digite três notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            /*if (media >= 7)
            {
                resultado = "aprovado";
            }
            else
            {
                resultado = "reprovado";
            }*/
            resultado = media >= 7 ? "aprovado" : "reprovado";

            Console.WriteLine($"O aluno {nomeDoAluno} obteve a média {media} e foi {resultado}");

            /*
            string[] alunos = { "João", "Maria", "José","Rômulo","Ramon","Bruno","William","Yedo","Jeferson" };
            //Console.WriteLine(alunos[1]);
            int cont=0;
            foreach (var item in alunos)
            {
                int r = item.StartsWith("R") ? cont++ : 0;

            }
            Console.WriteLine($"Foram {cont} alunos que tem o nome iniciando com a letra R ");

            foreach (var item in alunos)
            {
                if (item.StartsWith("R"))
                {
                    Console.WriteLine(item);
                }
                
            }*/
            Console.ReadKey();


        }

    }
}
