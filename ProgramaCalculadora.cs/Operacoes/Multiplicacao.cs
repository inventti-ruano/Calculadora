namespace ProgramaCalculadora.cs.Operacoes
{
    class Multiplicacao : IOperacao
    {
        public double Calcular(double primeiroValor, double segundoValor)
        {
            return primeiroValor * segundoValor;
        }
    }
}