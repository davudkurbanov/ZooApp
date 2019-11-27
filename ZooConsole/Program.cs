using System;
using Zoo.lib;

namespace ZooConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            PublicZoo zoo = new PublicZoo(39M);
            Console.WriteLine($"Hello Nightly Tourist!\n\n" +
                $"Buy a ticket for {zoo.EntranceFee} euro" +
                $"Take a look at our animals:\n\n");

            foreach (Lion lion in zoo.LionCage.Lions)
            {
                Console.WriteLine($"Grrrrr.... I am {lion.Name}, my sex is {lion.Sex}");
            }
        }
    }
}
