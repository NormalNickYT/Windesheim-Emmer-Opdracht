using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmer_Opdracht.Abstraction
{
    public class Holder : IHolder
    {
        // Make private fields
        private int _capacity; 
        private int _size;

        public int Capacity
        {
            get => _capacity;
            private set
            {
                if (value < 0)
                    Console.WriteLine("Capacity can't be negative");
                _capacity = value;
            }
        }

        public int Size 
        {
            get => _size;
            set {
                if (value < 0)
                    Console.WriteLine("Size can't be negative");
                _size = value;
            }
        }

        public Holder(int capacity)
        {
            Capacity = capacity;
            Size = 0;
        }

        public void Empty(int quantity)
        {
            if (quantity < Size)
            {
                Size -= quantity;
            }
            else
            {
                Console.WriteLine("Can't Empty that high of a quantity");
            }
        }

        public void Empty()
        {
            Size = 0;
        }

        public void Fill(int quantity)
        {
            Size += quantity;
        }

        public void Fill()
        {
            Size = _capacity;
        }

        public override string ToString()
        {
            return $"is filled for: Size: {Size} Capacity: {Capacity}";
        }
    }
}
