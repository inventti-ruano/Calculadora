using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;

namespace ProgramaCalculadora.cs.Testes
{
    class CalculadoraTestes
    {
        [Test]
        public Calculadora iniciar_calculadora()
        {
            return new Calculadora();
        }

        [Test]
        public void iniciar_numeros_calculadora()
        {
            var calc = iniciar_calculadora();
            double primeiroValorInformado = 3, segundoValorInformado = 4;
            calc.AtribuirNumerosParaCalcular(primeiroValorInformado, segundoValorInformado);
        }

        //[Test]
        //public void somar_valores()
        //{
        //    double primeiroValorInformado = 3, segundoValorInformado = 4;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 7);
        //}

        //[Test]
        //public void somar_valores_quebrados()
        //{
        //    double primeiroValorInformado = 3.2, segundoValorInformado = 3.7;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 6.9);
        //}

        //[Test]
        //public void somar_valores_quebrados_2()
        //{
        //    double primeiroValorInformado = -3.2, segundoValorInformado = 3.7;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 0.5);
        //}

        //[Test]
        //public void somar_valores_quebrados_3()
        //{
        //    double primeiroValorInformado = 3.2, segundoValorInformado = -3.7;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -0.5);
        //}

        //[Test]
        //public void somar_valores_negativos()
        //{
        //    double primeiroValorInformado = -3, segundoValorInformado = 4;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 1);            
        //}

        //[Test]
        //public void somar_valores_negativos_2()
        //{
        //    double primeiroValorInformado = -3, segundoValorInformado = -4;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -7);
        //}

        //[Test]
        //public void somar_valores_negativos_3()
        //{
        //    double primeiroValorInformado = 3, segundoValorInformado = -4;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -1);
        //}

        //[Test]
        //public void somar_valores_negativos_4()
        //{
        //    double primeiroValorInformado = 4, segundoValorInformado = -4;
        //    var resultado = Calculadora.Somar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 0);
        //}

        //[Test]
        //public void subtrair_valores()
        //{
        //    double primeiroValorInformado = 10, segundoValorInformado = 5;
        //    var resultado = Calculadora.Subtrair(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 5);
        //}

        //[Test]
        //public void subtrair_valores_negativos()
        //{
        //    double primeiroValorInformado = -12, segundoValorInformado = 3;
        //    var resultado = Calculadora.Subtrair(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -9);
        //}

        //[Test]
        //public void subtrair_valores_negativos_2()
        //{
        //    double primeiroValorInformado = -12, segundoValorInformado = -12;
        //    var resultado = Calculadora.Subtrair(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -24);
        //}

        //[Test]
        //public void subtrair_valores_negativos_3()
        //{
        //    double primeiroValorInformado = 10, segundoValorInformado = -7;
        //    var resultado = Calculadora.Subtrair(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 3);
        //}

        //[Test]
        //public void subtrair_valores_negativos_4()
        //{
        //    double primeiroValorInformado = 7, segundoValorInformado = -7;
        //    var resultado = Calculadora.Subtrair(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 0);
        //}

        //[Test]
        //public void multiplicar_valores()
        //{
        //    double primeiroValorInformado = 10, segundoValorInformado = 7;
        //    var resultado = Calculadora.Multiplicar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 70);
        //}

        //[Test]
        //public void multiplicar_valores_negativos()
        //{
        //    double primeiroValorInformado = 5, segundoValorInformado = -7;
        //    var resultado = Calculadora.Multiplicar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -35);
        //}

        //[Test]
        //public void multiplicar_valores_negativos_2()
        //{
        //    double primeiroValorInformado = -5, segundoValorInformado = -7;
        //    var resultado = Calculadora.Multiplicar(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 35);
        //}

        //[Test]
        //public void dividir_valores()
        //{
        //    double primeiroValorInformado = 25, segundoValorInformado = 5;
        //    var resultado = Calculadora.Dividir(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, 5);
        //}

        //[Test]
        //public void dividir_valores_negativo()
        //{
        //    double primeiroValorInformado = 25, segundoValorInformado = -5;
        //    var resultado = Calculadora.Dividir(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -5);
        //}

        //[Test]
        //public void dividir_valores_negativo_2()
        //{
        //    double primeiroValorInformado = -25, segundoValorInformado = 5;
        //    var resultado = Calculadora.Dividir(primeiroValorInformado, segundoValorInformado);
        //    Assert.AreEqual(resultado, -5);
        //}

        [Test]
        public void operacao_eh_valida()
        {
            var operacaoInformada = '+';
            var calculadora = new Calculadora();
            var resultado = calculadora.RetornarSeOperacaoEValida(operacaoInformada);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void operacao_eh_invalida()
        {
            var operacaoInformada = 'a';
            var calculadora = new Calculadora();
            var resultado = calculadora.RetornarSeOperacaoEValida(operacaoInformada);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void retornar_se_eh_um_numero_valido_2()
        {
            var numeroInformado = "5";
            var calculadora = new Calculadora();
            var resultado = calculadora.RetornarSeUmNumeroEValido(numeroInformado);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void retornar_se_eh_um_numero_invalido_2()
        {
            var numeroInformado = "a";
            var calculadora = new Calculadora();
            var resultado = calculadora.RetornarSeUmNumeroEValido(numeroInformado);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void mostrar_resultado_final()
        {
            double primeiroNumero = 5, segundoNumero = 5;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('+');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, 10);
        }

        [Test]
        public void mostrar_resultado_final_2()
        {
            double primeiroNumero = -5, segundoNumero = 10;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('+');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, 5);
        }

        [Test]
        public void mostrar_resultado_final_3()
        {
            double primeiroNumero = 10, segundoNumero = -3;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('-');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, 7);
        }

        [Test]
        public void mostrar_resultado_final_4()
        {
            double primeiroNumero = -2, segundoNumero = -3;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('-');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, -5);
        }

        [Test]
        public void mostrar_resultado_final_5()
        {
            double primeiroNumero = -2, segundoNumero = -3;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('*');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, 6);
        }

        [Test]
        public void mostrar_resultado_final_6()
        {
            double primeiroNumero = 2, segundoNumero = -3;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('*');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, -6);
        }

        [Test]
        public void mostrar_resultado_final_7()
        {
            double primeiroNumero = 25, segundoNumero = -5;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('/');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, -5);
        }

        [Test]
        public void mostrar_resultado_final_8()
        {
            double primeiroNumero = -25, segundoNumero = -5;
            var calculadora = new Calculadora();
            calculadora.RetornarSeOperacaoEValida('/');
            calculadora.AtribuirNumerosParaCalcular(primeiroNumero, segundoNumero);
            var resultado = calculadora.MostrarResultadoFinal();

            Assert.AreEqual(resultado, 5);
        }

        [Test]
        public void montar_objeto_calculadora_com_mock()
        {
            var calc = new Mock<Calculadora>();
        }
    }
}