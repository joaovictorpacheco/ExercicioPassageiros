﻿using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declação de variáveis

            string[] nomes = new string[5];
            string[] origem = new string [5];
            string[] destino = new string[5];
            string[] data = new string[5];


            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-----Sistema de passagens aéreas-----");
            Console.WriteLine("-------------------------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            
            } while (!senhaValida);
             Console.Clear();
             //Criar o menu
             int escolha;
             int contador = 0;
             do
             {

                 Console.WriteLine("Menu Inicial");
                 Console.WriteLine("Selecione uma opção");
                 Console.WriteLine("[1] - Cadastrar passagem");
                 Console.WriteLine("[2] - Listar Passagens");
                 Console.WriteLine("[0] - Sair");
                 escolha = int.Parse(Console.ReadLine());

                 switch (escolha)
                 {
                     case 1:
                     //Cadastrar passagem
                     string resposta;

                     do
                     {
                         if(contador<5)
                         {Console.WriteLine($"Digite o nome do {contador+1}º Passageiro");
                         nomes[contador] = Console.ReadLine();
                         Console.WriteLine($"Digite a origem do {contador+1}º Passageiro");
                         origem[contador] = Console.ReadLine();
                         Console.WriteLine($"Digite o destino do {contador+1}º Passageiro");
                         destino[contador] = Console.ReadLine();
                         Console.WriteLine($"Digite a data do vôo do {contador+1}º Passageiro");
                         data[contador] = Console.ReadLine();
                         contador++;                        
                         }else{
                             Console.WriteLine("Limite excedido de passagens");
                             break;
                         }
                         Console.WriteLine("Gostaria de cadastrar um novo passageiro s/n");
                         resposta = Console.ReadLine();
                     } while (resposta == "s");

                     break;
                case 2:
                     //Listar as passagens
                            for (var i = 0; i < 5; i++)
                            {
                                Console.WriteLine($"Passageiros {nomes[i]}");
                            };
                    break;
                case 0:
                    //Sair
                    Console.WriteLine("Obrigado! Volte sempre!");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
                 }
             } while (escolha !=0);



            //Funções
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    Console.WriteLine("Achei");
                    return true;
                }else{
                    Console.WriteLine("Seha Incorreta");
                    return false;
                }
            }// fim do efetuar login
            
        }
    }
}
