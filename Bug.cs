using System;
using System.Collections.Generic;

namespace Expression_members
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "";
        public string Species { get; } = "";
        public ICollection<string> Predators { get; } = new List<string>();
        public ICollection<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        public string FormalName
        {
            get
            {
                return $"{this.Name} the {this.Species}";
            }
        }
        public List<Bug> BugsList = new List<Bug>();

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            Name = name;
            Species = species;
            Predators = predators;
            Prey = prey;
        }

        // Convert this method to an expression member 
        public string PreyList() => String.Join(", ", Prey);

        // Convert this method to an expression member
        public string PredatorsList() => String.Join(", ", Predators);

        // Convert this to expression method (hint: use a C# ternary)
        public string Eat(string food)
        {
            return this.Prey.Contains(food) ? $"{this.Name} at the {food}" : $"{this.Name} is still hungary";
        }

    }
}