﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
           //ConcaternarPalavras();
           //VerificarAulaEtec();
           CalcularMedia();

        }

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

                if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Final de Semana! Hoje não tem aula! Revisarei exercícios.");
                }
                else
                {
                    Console.WriteLine("Dia de semana! Bora pra Etec!");
                }

        }


        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

                if(media >= 7)
                    Console.WriteLine("Aprovado");
                else if(media < 7 && media >= 4)
                    Console.WriteLine("Recuperação");
                else
                    Console.WriteLine("Reprovado");
        }



        public static void ConcaternarPalavras()
        {
             Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
                    Console.WriteLine(frase1);
                    Console.WriteLine(" ");

                Console.WriteLine("Quanto custa um dólar em reais? ");
                decimal valorDolarReais = decimal.Parse(Console.ReadLine());
                string frase2 = string.Format("Hoje é {0:dddd}, o dólar está custando {1:c2} ", DateTime.Now, valorDolarReais);
                    Console.WriteLine(frase2);

                Console.WriteLine(" ");
                string cabecalho = string.Format("{0:dddd},{0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
                    Console.WriteLine(cabecalho.ToUpper());
        }

        // BATATA, PATATA, POTATO, POMME DE TERRE, KARTOFELL
        // Maçã. Apple. Apfel. Pomme. Manzana.











    } 
}
