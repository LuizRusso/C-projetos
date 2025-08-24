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
            //aula sobre variaveis e comentarios
            string namePerson = "Eduardo"; //uma variavel string serve para armazenar plavras inteiras
            int numberOne = 20; //armazena numeros inteiros
            double numberTwo = 10.5; // armazena numeros inteiros grandes
            char testDrive = 'A'; //armazena apenas um caractere 
            bool atividade = true; // armazena se a informação é verdadeira "true" ou falsa "false"

            Console.WriteLine($" {namePerson}, possui {numberOne} anos, ele quer fazer aula da categoria de {testDrive}, no dia {numberTwo}, entao {atividade} "); 

        }
    }
}
