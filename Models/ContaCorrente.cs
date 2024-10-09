
namespace BancoCSharp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) 
        : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoAbertura) 
        : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
        Console.WriteLine("******************************************");
        Console.WriteLine("************** Ectrato Cc ****************");
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