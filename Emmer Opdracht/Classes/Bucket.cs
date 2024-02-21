using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emmer_Opdracht.Abstraction;

namespace Emmer_Opdracht.Classes
{
    public class Bucket : Holder
    {

        public Bucket() : base(12)
        {
        }

        public Bucket(int capacity) : base(capacity)
        {
            if (capacity < 10)
            {
                Console.WriteLine("Minimum should be atleast 10");
            }
            else if (capacity > 2500)
            {
                Console.WriteLine("Max is 2500");
            }
        }

        // Can be filled by another bucket
        public void Fill(Bucket bucket)
        {
            Fill(bucket.Size);
            // Other bucket should be fully emptied
            bucket.Empty();
        }

        public override string ToString()
        {
            return $"Bucket: " + base.ToString();
        }
    }

}