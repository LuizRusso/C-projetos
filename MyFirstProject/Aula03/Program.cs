using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            dynamic variable = 20; //variavel dinamica, comsidera sempre quem é o ultimo
                                   //var, obj sao variaveis nao recomendadas para usarm apenas no const
            int number = 20;

            Console.WriteLine($"O valor da variavel é {number}");

            int number1 = 10;

            Console.WriteLine($"O valor da variavel é {number1}");

            string nome= "Luiz com Z";

            Console.WriteLine($"teste com {nome}");
            
            string nome1 = "Luiz Henrique";

            Console.WriteLine($"teste completo com {nome1}");

        }
    }
}