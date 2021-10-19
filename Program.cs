using System;

namespace Herança
{
    class ContaJuridica
    {
        static void Main(string[] args)
        {
            ContaJur ContaJuridicaa;

            ContaJuridicaa = new ContaJur(8010, "LaraCroft", 100.0, 500.0);
            Console.WriteLine(value: ContaJuridicaa.Saldo);
        }
    }


}
  

