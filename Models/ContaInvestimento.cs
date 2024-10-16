using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaInvestimento : ContaBancaria
    {
        public ContaInvestimento(Titular titular) 
        : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        }

         public override void ImprimirExtrato()
        {
        Console.WriteLine("******************************************");
        Console.WriteLine("************** Ectrato CInvs *************");
        Console.WriteLine("******************************************");
        Console.WriteLine();

        System.Console.WriteLine("Gerado em: " + DateTime.Now);
        System.Console.WriteLine();

        foreach(var Movimentacao in Movimentacoes)
        {
            Console.WriteLine(Movimentacao.ToString());
        }
        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine("************ Fim do Extrato **************");
        Console.WriteLine("******************************************");
        Console.WriteLine();
        }
    }
}