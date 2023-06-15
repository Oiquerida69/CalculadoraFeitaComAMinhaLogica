using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_com_logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("digite um numero :");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite mais um numero :");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("escolha uma operação \n 1- soma \n 2- subtração \n 3- multiplicação \n 4 - divisão");
            double operação = double.Parse(Console.ReadLine());
            switch (operação)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
            }
            Console.ReadKey();
        }
            
    }
}
