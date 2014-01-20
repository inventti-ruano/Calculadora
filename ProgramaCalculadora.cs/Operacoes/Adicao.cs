namespace ProgramaCalculadora.cs.Operacoes
{
    class Adicao : IOperacao
    {
        public double Calcular(double primeiroValor, double segundoValor)
        {
            return primeiroValor + segundoValor;
        }
    }
}