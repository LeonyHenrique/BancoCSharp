
using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public class Movimentacao
    {
        private DateTime DataHoraMovimentacao {get;set;}
        private TipoMovimentacao TipoMovimentacao{get;set;}
        private double ValorMovimentacao{get;set;}

        public Movimentacao(TipoMovimentacao tipoMovimentacao, double valorMovimentacao)
        {
            TipoMovimentacao = tipoMovimentacao;
            DataHoraMovimentacao = DateTime.Now;
            ValorMovimentacao = valorMovimentacao;
        }

        public override string ToString()
        {
            var valorMovimentacao = (this.TipoMovimentacao == TipoMovimentacao.SAQUE || 
                                     this.TipoMovimentacao == TipoMovimentacao.TRANSFERENCIA)
            ? "-R$" + ValorMovimentacao
            : "R$" + ValorMovimentacao;

            return $"{DataHoraMovimentacao} hs | {TipoMovimentacao}  |  {valorMovimentacao}";
        }
    }
}