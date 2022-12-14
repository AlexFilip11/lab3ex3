using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie care va determina daca un numar este sau nu patrat perfect.Apelati o si afisati i rezultatul
            Console.WriteLine("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            PatratPerfect(numar);
        }
        static void PatratPerfect(int numar)
        {
            for(int i=1; i<=numar/2; i++)
            {
                if(i*i==numar)
                {
                    Console.WriteLine("Numarul este un patrat perfect");
                    break;
                }
                else if(i==numar/2)
                {
                    Console.WriteLine("Numarul nu este un patrat perfect");
                }
            }
            
        }
    }
}
