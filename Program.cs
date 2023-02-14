using System;
namespace aula1
{
    class Program
    {

        /* Comentário
         * em bloco
         */
        static void Main(string[] args)
        {
            //tipo_dado nome_variavel
            //int idade;
            //Comentário de linha
            //Console.WriteLine("Hello World!");
            // O comando Console.WriteLine escreve uma linha no condole.
            //Console.WriteLine("Parabéns pelo seu primeiro código!");

            int n1, n2, resultado;
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine("Soma = " + resultado);
            //Console.WriteLine("A soma = " + resultado.ToString()) ;
            resultado = n1 - n2;
            Console.WriteLine("Subtração  = " + resultado);

            resultado = n1 * n2;
            Console.WriteLine("Multiplicação = " + resultado);

            resultado = n1 / n2;
            Console.WriteLine("Divisão = " + resultado);

        }
    }
}