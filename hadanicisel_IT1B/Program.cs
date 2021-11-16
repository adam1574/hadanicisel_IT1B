using System;

namespace hadanicisel_IT1B
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int Nahcislo = random.Next(1, 100);
            int tipcislo;
            bool neuhodl = true;
            Console.WriteLine("hádání čísla");
            Console.WriteLine("..............");
            Console.WriteLine($"myslim si cislo od 1 do 100");
            while (true)

            {
                
                Console.WriteLine("tipni hodnotu");
                tipcislo = int.Parse(Console.ReadLine());
                if (tipcislo < Nahcislo)
                {
                    Console.WriteLine("to je malo");

                }

                else if (tipcislo > Nahcislo)
                {
                    Console.WriteLine("to je moc");

                }
                else
                {
                    Console.WriteLine("TREFA!!!!!!");
                }


            }
            
            
        }
    }
}
