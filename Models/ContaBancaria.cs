
namespace BancoCSharp.Models
{
    public abstract class ContaBancaria
    {
        #region Atributos
     public Titular Titular {get;set;}
     public double Saldo { get; private set; }
     public DateTime DataAbertura { get; private set; }
     protect List<Movimentacao> Movimentacoes {get; set;}
     protected readonly double VALOR_MINIMO = 10.0;

     #endregion

        #region Construtores
     public ContaBancaria(Titular titular, double saldoAbertura)
     {
        Titular = titular;
        Saldo = saldoAbertura;
        DataAbertura = DateTime.Now;
        Movimentacoes = new List<Movimentacao>()
        {
            new Movimentacao(Enums.TipoMovimentacao.ABERTURA_CONTA, SaldoAbertura);

        };

     }
     public ContaBancaria(Titular titular)
     {
        Titular = titular;
        Saldo = 0;
        DataAbertura = DateTime.Now;
        Movimentacoes = new List<Movimentacao>()
        {
            new Movimentacao(Enums.TipoMovimentacao.ABERTURA_CONTA, Saldo);

        };
     }

     #endregion

        #region Metodos

        public void Depositar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception ("O valor mínimo para depósito é  R$" + VALOR_MINIMO);
            }
            Saldo += valor;
            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.DEPOSITO, valorMovimentacao));
        }

        public double Sacar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception ("O valor mínimo para saque é  R$" + VALOR_MINIMO);
            }
            else if (valor > Saldo)
            {
                throw new Exception ("Saldo insificiente, seu saldo atual é de R$" + Saldo);
            }
            Saldo -= valor;

            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.SAQUE, valorMovimentacao));
       
            return valor;
        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
              if(valor < VALOR_MINIMO)
            {
                throw new Exception ("O valor mínimo para transferencia é R$" + VALOR_MINIMO);
            }
             else if (valor > Saldo)
            {
                throw new Exception ("Saldo insificiente para transferencia, seu saldo atual é de R$" + Saldo);
            }

            contaDestino.Depositar(valor);
            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.TRANSFERENCIA, valorMovimentacao));
       
        }
        
        public abstract void ImprimirExtrato();
       
        #endregion
     
    }
}