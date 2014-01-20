using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaCalculadora.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            Console.WriteLine("-- CALCULADORA --");
            Mensagens.SolicitarOperacao();
            var operacao = char.Parse(Console.ReadLine());

            while (!calc.RetornarSeOperacaoEValida(operacao))
            {
                Console.Clear();
                Mensagens.OperacaoInvalida();
                Mensagens.SolicitarOperacao();
                operacao = char.Parse(Console.ReadLine());
            }

            double primeiroNumero, segundoNumero;
            string primeiroNumeroStr, segundoNumeroStr;
            Mensagens.PerguntarNumero();
            primeiroNumeroStr = Console.ReadLine();

            while (!calc.RetornarSeUmNumeroEValido(primeiroNumeroStr))
            {
                Console.Clear();
                Mensagens.NumeroInvalido();
                Mensagens.PerguntarNumero();
                primeiroNumeroStr = Console.ReadLine();
            }
            primeiroNumero = double.Parse(primeiroNumeroStr);

            Mensagens.PerguntarNumero();
            segundoNumeroStr = Console.ReadLine();

            while (!calc.RetornarSeUmNumeroEValido(segundoNumeroStr))
            {
                Console.Clear();
                Mensagens.NumeroInvalido();
                Mensagens.PerguntarNumero();
                segundoNumeroStr = Console.ReadLine();
            }
            segundoNumero = double.Parse(segundoNumeroStr);
            calc.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            Mensagens.MostrarResultado(calc.MostrarResultadoFinal());
        }
    }
}