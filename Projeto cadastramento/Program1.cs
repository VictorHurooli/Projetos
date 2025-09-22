using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.Design;
class SistemaCadastro
{
    static void Main()
    {
        string emailCadastrado;
        string senhaCadastrada;
        bool emailFlag = false;
        bool senhaFlag = false;
        string confirma;
        bool confirmaflag = false;

        Console.WriteLine("Bem-Vindo ao sistema de cadastro");
        Console.Write("Cadastre seu email: ");
        emailCadastrado = Console.ReadLine(); //Lê email cadastrado
        while (emailFlag == false)
        {
            if (emailCadastrado.Contains("@"))  //Faz a verificação para inserir um email valido
            {
                emailFlag = true;
                break;
            }
            if (emailFlag == false)
            {
                Console.WriteLine("digite um email valido");
                emailCadastrado = Console.ReadLine();
            }
        }
        Console.Write("seu email é: " + emailCadastrado + " ?"); // Corrigir
        Console.WriteLine("Precione (S) para Confirmar ou (N) para sair."); //Funciona;
        confirma = Console.ReadLine();
        while (emailFlag == true) 
        {
            if (confirma == "S")
            {
                confirmaflag = true;
                break;
            }
            if (confirma == "N")
            {

                Console.WriteLine("digite um email(visual@gmail.com) e uma senha valida(ex:Senha@10): ");
                emailCadastrado = Console.ReadLine();

                if (emailCadastrado.Contains("@"))
                {
                    confirmaflag = true;
                    break;
                } 
                else
                {
                    Console.Clear();
                    Console.WriteLine("Digite novamente, exemplo:(visual@gmail.com)"); //Funciona\\
                }

            }
        }

        Console.Clear();
        Console.WriteLine("Email cadastrado."); //Informa que o email foi cadastrado com sucesso
        Console.WriteLine();
        Console.Write("Cadastre sua senha: ");
        senhaCadastrada = Console.ReadLine();    //Lê a senha cadastrada
        while (senhaFlag == false)
        {
            if (senhaCadastrada.Length >= 8) //Faz a verificação para inserir um senha valida
            {
                senhaFlag = true;
                Console.WriteLine("Senha cadastrada."); //Informa que o senha foi cadastrado com sucesso
                break;
            }
            if (senhaFlag == false)
            {
                Console.WriteLine("digite uma senha valida(ex:Senha@10)");
                senhaCadastrada = Console.ReadLine();
            }
        }

        bool acertou = false;
        int tentativas = 3;
        string login = emailCadastrado;
        string senha = senhaCadastrada;
        Console.WriteLine("Para que possoamos logar com seu email senha cadastrados digite-os: "); //Lê o email e a senha cadastrados
        login = Console.ReadLine();
        Console.WriteLine();
        senha = Console.ReadLine();

        while (tentativas > 0)      //Faz a verificação para inserir o login cadastrado 
        {
            bool errou = false;
            if (emailCadastrado != login)
            {
                errou = true;
                Console.WriteLine();
            }
            if (senhaCadastrada != senha)
            {
                errou = true;
                Console.WriteLine();
            }
            if (errou == false)
            {
                acertou = true;
                tentativas = 0;
            }
            if (errou == true)
            {
                tentativas--;
                Console.WriteLine("Senha ou Login incorretos");
                Console.WriteLine("tentaivas  restante: " + tentativas);
                if (tentativas > 0)         //Contas as tentativas de login feitas pelo usuário 
                {
                    Console.WriteLine("Digite seu Login e Senha");
                    login = Console.ReadLine();
                    Console.WriteLine();
                    senha = Console.ReadLine();
                }
             }
        }    
        if (acertou == true)
        {
            Console.WriteLine("Login efetuado com sucesso");
        }
        if (acertou == false)
        {
            Console.WriteLine("Bloqueado por excesso de tenativas");
        }
    }     
}
