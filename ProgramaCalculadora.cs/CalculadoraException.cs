using System;

namespace ProgramaCalculadora.cs
{
    class CalculadoraException : SystemException
    {
        public CalculadoraException() : base() {}
        public CalculadoraException(string message) : base(message) {}
        public CalculadoraException(string message, SystemException inner) : base(message, inner) { }

        public new string Message()
        {
            return "OCORREU UM ERRO AO CALCULAR:\n" + base.Message;
        }

        public new string Source()
        {
            return "ORIGEM DO ERRO:\n" + base.Source;
        }

        public new string StackTrace()
        {
            return "INFORMAÇÕES ADICIONAIS:\n" + base.StackTrace;
        }
    }
}