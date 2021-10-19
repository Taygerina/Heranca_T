using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class ContaJur : Conta
    {
        public double EmprestimoLimite { get; set; }

        public ContaJur(int numero, string titular, double saldo, double emprestimoLimite) : base (numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(Double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }


    }
}
