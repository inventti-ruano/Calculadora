using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaCalculadora.cs
{
    class Mensagens
    {
        public static void MostrarErro(CalculadoraException e)
        {
            Console.WriteLine("ERRO: " + e.Message());
            Console.WriteLine("ORIGEM: " + e.Source());
            Console.WriteLine("DADOS: " + e.StackTrace());
        }

        public static void OperacaoInvalida()
        {
            Console.WriteLine();
            Console.WriteLine("Operação inválida.");
        }

        public static void SolicitarOperacao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a operação desejada\n+  -  *  /: ");
            Console.Write("Operação: ");
        }

        public static void PerguntarNumero()
        {
            Console.WriteLine();
            Console.WriteLine("Informe um número para a calculadora.");
            Console.Write("Número: ");
        }

        public static void NumeroInvalido()
        {
            Console.WriteLine();
            Console.WriteLine("Número inválido.");
        }

        public static void MostrarResultado(string resultado)
        {
            Console.WriteLine();
            Console.WriteLine("O resultado da operação é: {0}.", resultado);
            Console.ReadKey();
        }
    }
}