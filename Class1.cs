using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    //criação da class
    class Conta
    {
        //Declaração das variaveis numero, titular e saldo
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        //Criação do construtor 
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //metodo do Saque
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //metodo do deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }


    }


}

