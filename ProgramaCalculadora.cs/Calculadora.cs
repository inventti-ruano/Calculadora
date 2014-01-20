using System;
using ProgramaCalculadora.cs.Operacoes;

namespace ProgramaCalculadora.cs
{
    class Calculadora
    {
        private double primeiroNumero;
        private double segundoNumero;
        private char operacao;

        private double Somar()
        {
            try
            {
                return new Adicao().Calcular(this.primeiroNumero, this.segundoNumero);
            }
            catch (CalculadoraException e)
            {
                Mensagens.MostrarErro(e);
                return 0;
            }
        }

        private double Subtrair()
        {
            try
            {
                return new Subtracao().Calcular(this.primeiroNumero, this.segundoNumero);
            }
            catch (CalculadoraException e)
            {
                Mensagens.MostrarErro(e);
                return 0;
            }
        }

        private double Multiplicar()
        {
            try
            {
                return new Multiplicacao().Calcular(this.primeiroNumero, this.segundoNumero);
            }
            catch (CalculadoraException e)
            {
                Mensagens.MostrarErro(e);
                return 0;
            }
        }

        private double Dividir()
        {
            try
            {
                return new Divisao().Calcular(this.primeiroNumero, this.segundoNumero);
            }
            catch (CalculadoraException e)
            {
                Mensagens.MostrarErro(e);
                return 0;
            }
        }

        public bool RetornarSeOperacaoEValida(char operacaoInformada)
        {
            var retorno = operacaoInformada == '+'
                           || operacaoInformada == '-'
                           || operacaoInformada == '*'
                           || operacaoInformada == '/';
            if (retorno)
            {
                this.operacao = operacaoInformada;
            }
            return retorno;
        }

        public bool RetornarSeUmNumeroEValido(string numeroInformado)
        {
            try
            {
                var numeroFormatado = double.Parse(numeroInformado);
                return true;
            }
            catch (SystemException e)
            {
                return false;
            }
        }

        public void AtribuirNumerosParaCalcular(double primeiroValorInformado, double segundoValorInformado)
        {
            this.primeiroNumero = primeiroValorInformado;
            this.segundoNumero = segundoValorInformado;
        }

        public string MostrarResultadoFinal()
        {
            switch (this.operacao)
            {
                case '+':
                    return this.FormatarNumero(this.Somar());
                case '-':
                    return this.FormatarNumero(this.Subtrair());
                case '*':
                    return this.FormatarNumero(this.Multiplicar());
                case '/':
                    return this.FormatarNumero(this.Dividir());
                default:
                    return "";
            }
        }

        private string FormatarNumero(double numero)
        {
            return String.Format("{0:0.##}", numero);
        }
    }
}