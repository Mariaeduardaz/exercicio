using System;

namespace exercicioConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                int a, b, c;
            volta:
                Console.WriteLine("Digite os tres valores do seu triangulo para saber qual é seu lado");
                Console.WriteLine("Escreva o valor de a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o valor de b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva  o valor de c");
                c = int.Parse(Console.ReadLine());
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("Seu triangulo é equilatero\n");
                }

                else if (a != b && a != c && b != c)
                {
                    Console.WriteLine("Seu triangulo é escaleno\n");
                }

                else if (a == b && a != c || c == b && c != a || a == c && a != b)
                {
                    Console.WriteLine("Seu triangulo é isoceles\n");
                }
                
                else Console.WriteLine("Deu erro, tente novamente");
                
                goto volta;

              Console.ReadLine();
            } while (true);
            
            
        }  
    }
}
