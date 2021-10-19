using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class ContaJur : Conta
    {
        //declaração das variaveis
        public double EmprestimoLimite { get; set; }

        //criação do construtor
        public ContaJur(int numero, string titular, double saldo, double emprestimoLimite) : base (numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        //finalização
        public void Emprestimo(Double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }


    }
}
