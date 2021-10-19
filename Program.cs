using System;

namespace Herança
{
    class ContaJuridica
    {
        static void Main(string[] args)
        {
            //Variavel
            ContaJur ContaJuridicaa;
            //mostra o metodo na tela.
            ContaJuridicaa = new ContaJur(8010, "LaraCroft", 100.0, 500.0);
            Console.WriteLine(value: ContaJuridicaa.Saldo);
        }
    }


}
  

