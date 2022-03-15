using System;
using System.Collections.Generic;

namespace bewerbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze ludwig = new Katze("Säugetier", "Katze", "Löwe", "Ludwig");
            Katze josef = new Katze("Säugetier", "Katze", "Jaguar", "Josef");

            Nagetier manfred = new Nagetier("Säugetier", "Nagetier", "Maus", "Manfred");
            Nagetier natalie = new Nagetier("Säugetier", "Nagetier", "Nacktmull", "Natalie");

            Reptil anton = new Reptil("Reptil", "Alligator", "Anton");
            Reptil konrad = new Reptil("Reptil", "Krokodil", "Konrad");

            List<Tier> Zoo = new List<Tier>();

            Zoo.Add(anton);
            Zoo.Add(konrad);
            Zoo.Add(ludwig);
            Zoo.Add(josef);
            Zoo.Add(manfred);
            Zoo.Add(natalie);

            Console.WriteLine($"Der Zoo hat {Zoo.Count} Tiere:");
            Zoo.ForEach(i => Console.WriteLine("{0}\t", i));

            Console.ReadKey();
        }
    }
}
