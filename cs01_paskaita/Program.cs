using System;

namespace cs01_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs01_paskaita");
            Console.WriteLine($"4 + 5 = {4 + 5}");

            //int age = 15;
            //string myName = "Vilmantas";
            Console.WriteLine("Stringas: Koks Jūsų vardas: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Integeris: Koks Jūsų amžius: ");
            int age = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed; // <-- paspalvoju consolės tekstą

            Console.WriteLine($"Mano vardas yra {myName} ir man yra {age} metų");
        }
    }
}

