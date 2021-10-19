using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Contapoupanca : Conta
    {
        //declarando as Variaveis de juros e poupança
        public double TaxaJuros { get; set; }

        public Contapoupanca(int numero, string titular, double saldo, double taxaJuros) : base (numero,titular,saldo)
        {
            TaxaJuros = taxaJuros;
        }
        //utilizando  Saldo
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
