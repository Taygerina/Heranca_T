using System;

namespace Herança
{
    class ContaJuridica
    {
        static void Main(string[] args)
        {
            //declarando o metodo dos usuarios
            Conta acc;
            acc = new Conta(1001, "Goku", 0.0);
            ContaJur bacc = new ContaJur (1002, "goten", 0.0, 500.0);
            
                Conta acc1 = bacc;
                Conta acc2 = new ContaJur(1003, "Trunks", 0.0, 200.00);
                Conta acc3 = new Contapoupanca(1004, "Vegeta", 0.0, 0.01);
                ContaJur acc4 = (ContaJur)acc2;
                 acc4.Emprestimo(100.0);

            //chamando para a tela o emprestimo
            if (acc3 is ContaJur)
            {
                ContaJur acc5 = (ContaJur)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            
            //chamando para a tela a atualização
            if (acc3 is Contapoupanca)
            {
                Contapoupanca acc5 = acc3 as Contapoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
               
        }
    }

}
  

