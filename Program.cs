using System;
using System.Collections.Generic;

namespace Expression_members
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bug spider = new Bug("Black Widow Spider", "Latrodectus hersperus", new List<string>() { "Praying Mantis", "birds" }, new List<string>() { "grasshopper", "fly" });

            Bug hornet = new Bug("European Hornet", "Vespa crabro", new List<string>() { "Praying Mantis", "Dragonfly" }, new List<string>() { "grasshopper", "yellow jacket" });

            Bug butterfly = new Bug("Monarch", "Danaus plexippus", new List<string>() { "Praying Mantis", "birds" }, new List<string>() { "liquids", "flower nectar" });

            Bug mantis = new Bug("'Praying' European Mantis", "Mantis religiosa", new List<string>() { "Praying Mantis", "birds" }, new List<string>() { "Praying Mantis", spider.Name, hornet.Name, butterfly.Name });

            Console.WriteLine(spider.FormalName);

            Console.WriteLine();
            Console.WriteLine($"{mantis.FormalName} feeds on {mantis.PreyList()} and is the prey of {mantis.PredatorsList()}");

            Console.WriteLine();
            Console.WriteLine(mantis.Eat("Pikachu"));
            Console.WriteLine(hornet.Eat("grasshopper"));

            Console.WriteLine();
            Console.WriteLine(mantis.Eat($"{spider.Name}"));
            Console.WriteLine(mantis.Eat($"{mantis.Name}"));
        }
    }
}
