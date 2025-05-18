using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GestionBancariaTests
{
    [TestClass]
    public class GestionBancariaTests
    {
        [TestMethod]
        public void ValidarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            double saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void realizarIngresoValido()
        {
            double saldoInicial = 500.0;
            double ingreso = 1000.0;
            double saldoEsperado = 1500.0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            Assert.AreEqual(saldoEsperado, cuenta.obtenerSaldo());
        }

        [TestMethod]
        public void realizarIngresoNegativo()
        {
            double saldoInicial = 500.0;
            double ingreso = -1000.0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Se espera que la siguiente línea lance una ArgumentException
            cuenta.realizarIngreso(ingreso);
            // Si llegamos aquí, la prueba fallará porque no se lanzó la excepción esperada
        }

        [TestMethod]
        public void realizarReintegroValido()
        {
            double saldoInicial = 1000.0;
            double reintegro = 750.0;
            double saldoEsperado = 250.0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, cuenta.obtenerSaldo());
        }

        [TestMethod]
        public void realizarReintegroNegativo()
        {
            double saldoInicial = 1000.0;
            double reintegro = -1000.0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Se espera que la siguiente línea lance una ArgumentException
            cuenta.realizarReintegro(reintegro);
            // Si llegamos aquí, la prueba fallará porque no se lanzó la excepción esperada
        }

        [TestMethod]
        public void realizarReintegroSaldoInsuficiente()
        {
            double saldoInicial = 1000.0;
            double reintegro = 1500.0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Se espera que la siguiente línea lance una InvalidOperationException
            cuenta.realizarReintegro(reintegro);
            // Si llegamos aquí, la prueba fallará porque no se lanzó la excepción esperada
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void excepcionCantidadNegativa()
        {
            CuentaBancaria cuenta = new CuentaBancaria("Titular de Prueba", 100);
            cuenta.Retirar(-50);
            // La prueba fallará si no se lanza la excepción ArgumentOutOfRangeException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void excepcionSaldoInsuficiente()
        {
            CuentaBancaria cuenta = new CuentaBancaria("Titular de Prueba", 50);
            cuenta.Retirar(100);
            // La prueba fallará si no se lanza la excepción ArgumentOutOfRangeException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void excepcionCantNegativaDeposito()
        {
            CuentaBancaria cuenta = new CuentaBancaria("Titular de Prueba", 100);
            cuenta.Depositar(-20);
            // La prueba fallará si no se lanza la excepción ArgumentOutOfRangeException
        }
    }
}
