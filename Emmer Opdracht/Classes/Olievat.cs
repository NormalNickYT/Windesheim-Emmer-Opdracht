using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emmer_Opdracht.Abstraction;

namespace Emmer_Opdracht.Classes
{
    public class Olievat : Holder
    {
        public Olievat() : base(159) { }
        public override string ToString()
        {
            return $"Olievat: " + base.ToString();
        }
    }
}
