using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmer_Opdracht.Abstraction
{
    public interface IHolder
    {
        int Capacity { get; }
        int Size { get; set; }

        void Fill();
        void Empty(); 

    }
}
