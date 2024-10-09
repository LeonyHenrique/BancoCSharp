// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using BancoCSharp.Enums;
using BancoCSharp.Models;
    
        Console.WriteLine("******************************************");
        Console.WriteLine("************** BANCO CSHARP **************");
        Console.WriteLine("******************************************");
        Console.WriteLine();

        var endereco = new Endereco{
             Cep = "12345678",
            Rua = "são francisco",
            Numero = 222
        };
        var titular01 = new Titular("Leony Santos", "15218818712", "24993010362", endereco);
        var titular02 = new Titular("Luany Santos", "15218818712", "24993010362", endereco);
       
        var conta01 = new ContaCorrente(titular01, 100.0);

        var conta02 = new ContaInvestimento(titular02);
        var conta03 = new ContaPoupanca(titular02);

      
       

        System.Console.WriteLine();
    

