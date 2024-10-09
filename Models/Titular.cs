using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class Titular
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string Telefone  {get;set;}
        public Endereco Endereco {get;set;}

   public Titular(string nome, string cpf, string telefone ) 
   {
       this.Nome = nome;
       this.CPF = cpf;
       this.Telefone = telefone;
      
   }
   public Titular(string nome, string cpf, string telefone, Endereco endereco ) 
   {
       this.Nome = nome;
       this.CPF = cpf;
       this.Telefone = telefone;
       this.Endereco = endereco;
   }

    }
}