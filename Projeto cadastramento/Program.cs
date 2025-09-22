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
                Console.WriteLine("digite um email(nome" +
                    "@gmail.com) e uma senha valida(ex:Senha@10): ");
                emailCadastrado = Console.ReadLine();
            }
        }
        Console.Write("seu email é: " + emailCadastrado + " ?"); // Pergunta ao usuario se o email escrito é certo
        Console.WriteLine("Precione (S) para Confirmar ou (N) para um novo cadastro."); //Pede a confirmaçao se (S) sim (N) Nao;        
        while (emailFlag == true)
        {
            confirma = Console.ReadLine();
            if (confirma == "S")
            {
                confirmaflag = true;
                break;
            }
            if (confirma == "N")
            {

                Console.WriteLine("digite um email(nome@gmail.com) e uma senha valida(ex:Senha@10): "); //Faz informativo de como seria um email correto
                emailCadastrado = Console.ReadLine();

                if (emailCadastrado.Contains("@"))  //Faz a verificação para inserir um email valido
                {
                    confirmaflag = true;
                    break;
                }
                while (confirmaflag == false)
                {
                    Console.Clear();
                    Console.WriteLine("Digite novamente, exemplo:(nome@gmail.com)"); //Uma nova verificaçao de email usando informativo de como seria um email correto
                    emailCadastrado = Console.ReadLine();
                    if (emailCadastrado.Contains("@"))
                    {
                        confirmaflag = true;
                        break;
                    }
                }
            }
            break;
        }

        Console.Clear();
        Console.WriteLine("Email cadastrado."); //Informa que o email foi cadastrado com sucesso mostrando novamente
        Console.WriteLine();
        Console.Write("Cadastre sua senha: ");
        senhaCadastrada = Console.ReadLine();    //Lê a senha cadastrada
        while (senhaFlag == false)
        {
            if (senhaCadastrada.Length >= 8) //Faz a verificação para inserir um senha valida
            {
                senhaFlag = true;
                Console.Clear();
                Console.WriteLine("Senha cadastrada."); //Informa que o senha foi cadastrada com sucesso
                Console.WriteLine();
                break;
            }
            if (senhaFlag == false)
            {
                Console.Clear();
                Console.WriteLine("digite uma senha valida(ex:Senha@10)"); //Faz informativo de como seria um senha correta
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
            Console.WriteLine("Login efetuado com sucesso"); //informa que o login foi efetuado
        }
        if (acertou == false)
        {
            Console.WriteLine("Bloqueado por excesso de tenativas"); //Informa que o login cadastrado foi bloqueado
        }
    }
}