
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
            Console.WriteLine("--------------------------");
            Console.WriteLine("           LOGIN          ");
            Console.WriteLine("--------------------------");

            //solicitar o nome do usuario

            Console.WriteLine("Insira seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Nome do Usuario é {nome}");

            //solicitar idade do usuario 

            Console.WriteLine($"Insira sua idade");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A idade do usuario é {age}");


        }
    }
}
