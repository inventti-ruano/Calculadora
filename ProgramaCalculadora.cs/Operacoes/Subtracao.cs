namespace ProgramaCalculadora.cs.Operacoes
{
    class Subtracao : IOperacao
    {
        public double Calcular(double primeiroValor, double segundoValor)
        {
            if (primeiroValor < 0 && segundoValor < 0)
            {
                primeiroValor = primeiroValor * -1;
                segundoValor = segundoValor * -1;

                return (primeiroValor + segundoValor) * -1;
            }
            if (primeiroValor < 0 && segundoValor > -1)
            {
                primeiroValor = primeiroValor * -1;
                return (primeiroValor - segundoValor) * -1;
            }
            if (primeiroValor > -1 && segundoValor < 0)
            {
                segundoValor = segundoValor * -1;
                return primeiroValor - segundoValor;
            }
            return primeiroValor - segundoValor;
        }
    }
}