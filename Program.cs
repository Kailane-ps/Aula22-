using System;

namespace _444
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O valor do Dolar para o Real é de");
            Console.WriteLine(conversor.DolarParaReal(52));
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O valor do Real para o Dolar é de");
            Console.WriteLine(conversor.RealParaDolar(52));
            Console.ResetColor();
            //MINHA PARTE

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O valor do Real para o Euro é de");
            Console.WriteLine(conversor.RealParaEuro(52));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O valor do Euro para o Real é de");
            Console.WriteLine(conversor.EuroParaReal(52));
            Console.ResetColor();
        }
    }
}
