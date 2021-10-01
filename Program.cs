using System;

namespace ComparacaoIfElseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.Write("Digite o mês desejado: ");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            if(mes == 1)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            else if(mes == 2)
            {
                Console.WriteLine("Este mês tem 28 dias ou 29 dias nos anos bissextos");
            }
            else if(mes == 3)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
             else if(mes == 4)
            {
                Console.WriteLine("Este mês tem 30 dias");
            }
            else if(mes == 5)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            else if(mes == 6)
            {
                Console.WriteLine("Este mês tem 30 dias");
            }
            else if(mes == 7)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            else if(mes == 8)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            else if(mes == 9)
            {
                Console.WriteLine("Este mês tem 30 dias");
            }
            else if(mes == 10)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            else if(mes == 11)
            {
                Console.WriteLine("Este mês tem 30 dias");
            }
            else if(mes == 12)
            {
                Console.WriteLine("Este mês tem 31 dias");
            }
            Console.WriteLine("");
        }
    }
} 
