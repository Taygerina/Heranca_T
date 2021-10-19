using System;

namespace Herança
{
    class ContaJuridica
    {
        static void Main(string[] args)
        {
            Conta acc;
            acc = new Conta(1001, "Goku", 0.0);
            ContaJur bacc = new ContaJur (1002, "goten", 0.0, 500.0);
            
                Conta acc1 = bacc;
                Conta acc2 = new ContaJur(1003, "Trunks", 0.0, 200.00);
                Conta acc3 = new Contapoupanca(1004, "Vegeta", 0.0, 0.01);


        }
    }

}
  

