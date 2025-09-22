using System;
using System.Security.Cryptography;
class SistemaMenu
{
    static void Main()
    {
        string escolha = "zero";
        float conta = 0;
        string comanda = "";

        Console.WriteLine("Selecione opções do Cardápio");
        Console.WriteLine();
        Console.WriteLine("1 - Hamburguer (R$ 15,00)");
        Console.WriteLine("2 - Batata Frita (R$ 8,00)");
        Console.WriteLine("3 - Refrigerante (R$5,00)");
        Console.WriteLine("4 - Sorvete (R$6,00)");
        Console.WriteLine("5 - Finalizar Pedido");
        Console.WriteLine();
        while (escolha != "5")
        {
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    conta = conta + 15.00;
                    comanda = comanda + "Hamburguer, ";
                    Console.WriteLine("Hamburguer anotado");
                    Console.WriteLine("Sua pedido ate o momento: " + comanda);
                    Console.WriteLine("Total: " + conta);
                    Console.WriteLine("Algo mais?");
                    break;
                case "2":
                    conta = conta + 8.00;
                    comanda = comanda + "Batata Frita, ";
                    Console.WriteLine("Batata Frita anotado");
                    Console.WriteLine("Sua pedido ate o momento: " + comanda);
                    Console.WriteLine("Total: " + conta);
                    Console.WriteLine("Algo mais?");
                    break;
                case "3":
                    conta = conta + 5.00;
                    comanda = comanda + "Refrigerante, ";
                    Console.WriteLine("Refrigerante anotado");
                    Console.WriteLine("Sua pedido ate o momento: " + comanda);
                    Console.WriteLine("Total: " + conta);
                    Console.WriteLine("Algo mais?");
                    break;
                case "4":
                    conta = conta + 6.00;
                    comanda = comanda + "Sorvete, ";
                    Console.WriteLine("Sorvete anotado");
                    Console.WriteLine("Sua pedido ate o momento: " + comanda);
                    Console.WriteLine("Total: " + conta);
                    Console.WriteLine("Algo mais?");
                    break;
                case "5":
                    Console.WriteLine("Pedido em preparo");
                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    Console.WriteLine("1 - Hamburguer (R$ 15,00)");
                    Console.WriteLine("2 - Batata Frita (R$ 8,00)");
                    Console.WriteLine("3 - Refrigerante (5,00)");
                    Console.WriteLine("4 - Sorvete (R$6,00)");
                    Console.WriteLine("5 - Finalizar Pedido");
                    break;
            }
        }
        if (conta > 50)
        {
            float Desconto = conta * (10/100);
            conta = conta - Desconto;
            Console.WriteLine("Totalll: " + Desconto);
        }
    }
}

