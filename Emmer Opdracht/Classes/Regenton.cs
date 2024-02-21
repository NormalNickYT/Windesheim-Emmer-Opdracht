using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emmer_Opdracht.Abstraction;

namespace Emmer_Opdracht.Classes
{
    public enum RegentonCapacity
    {
        Eighty = 80,
        Hundred = 100,
        HundredTwenty = 120
    }

    public class Regenton : Holder
    {
        public Regenton(int capacity) : base(capacity)
        {
            if (!Enum.IsDefined(typeof(RegentonCapacity), capacity))
            {
                Console.WriteLine("The Capacity must be (80, 100, or 120)");
            }
        }

        public override string ToString()
        {
            return Enum.IsDefined(typeof(RegentonCapacity), Capacity) ? $"Regenton: {base.ToString()}" : null;
        }
    }
}
