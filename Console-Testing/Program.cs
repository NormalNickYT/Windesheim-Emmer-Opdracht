using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Emmer_Opdracht.Classes;

namespace Emmer_Opdracht
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test Buckets
            var buckets = new List<Bucket>();
            buckets.Add(new Bucket(20));
            buckets.Add(new Bucket(100));
            buckets.Add(new Bucket(2400));

            // Can't set Capacity when Object created this is a Requirement
            /*buckets[0].Capacity = 10;*/

            buckets[0].Fill(100);
            buckets[1].Fill(200);
            buckets[2].Fill(300);

            // Try filling the Bucket with another Bucket the other bucket should be emptied
            buckets[2].Fill(buckets[0]);

            // Can we remove some Quantity of the Size
            buckets[2].Empty(50);

            foreach (var bucket in buckets)
            {
                Console.WriteLine(bucket);
            }

            Console.WriteLine("We will now empty the buckets");

            buckets[0].Empty();
            buckets[1].Empty();
            buckets[2].Empty();

            foreach (var bucket in buckets)
            {
                Console.WriteLine(bucket);
            }

            Console.WriteLine("We will now test possible errors for the Bucket");
            // Test buckets with possible errors
            var bucketsError = new List<Bucket>();
            // Can't be less than 10
            bucketsError.Add(new Bucket(5));
            // Can't be more than 2500
            bucketsError.Add(new Bucket(2600));
            // Can't be Negative
            bucketsError.Add(new Bucket(-5));

            // Test if we can Empty more than we have in Size of that bucket
            bucketsError.Add(new Bucket(300));
            bucketsError[3].Empty(400);

            // Here we will test Olievat en Regenton
            // Olievat is standard 159
            Olievat oilbarrel = new Olievat();
            oilbarrel.Fill(100);
            Console.WriteLine(oilbarrel);

            // Capacity is 90 not possible 
            Regenton regenton = new Regenton(90);
            regenton.Fill(200);
            Console.WriteLine(regenton);

            // Capacity is 80 works
            Regenton regenton1 = new Regenton(80);
            regenton1.Fill(80);
            Console.WriteLine(regenton1);


        }
    }
}
