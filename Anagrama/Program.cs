using System;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para formar um anagrama: ");
            var palavra = Console.ReadLine();

            var gerador = new GeradorAnagramas(LeitorDicionario.LerDicionario());
            
            Console.WriteLine("Palavras encontradas:");
            foreach (var item in gerador.GerarAnagramas(palavra))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
