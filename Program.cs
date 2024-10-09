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

      
       

        System.Console.WriteLine("Saldo conta 01: " + conta01.Saldo);
        System.Console.WriteLine("Saldo conta 02: " + conta02.Saldo);

        System.Console.WriteLine("extrato Conta01: ");
        conta01.ImprimirExtrato();

        System.Console.WriteLine("extrato Conta02: ");
        conta02.ImprimirExtrato();
        System.Console.WriteLine("extrato Conta03: ");
        conta02.ImprimirExtrato();

        System.Console.WriteLine();
    

