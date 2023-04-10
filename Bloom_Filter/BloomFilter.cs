using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloom_Filter
{
    public class BloomFilter : IBloomFilter
    {
        public void insert(bool[] bit_array, int array_size, string s)
        {
            if (look_up(bit_array, array_size, s))
            {
                Console.WriteLine("element exists");
                return;
            }
            H1 h1 = new H1();
            H2 h2 = new H2();
            int first_hash_value = h1.Hash(s, array_size);
            int second_hash_value = h2.Hash(s, array_size);
            bit_array[first_hash_value] = true;
            bit_array[second_hash_value] = true;
            Console.WriteLine("inserted");

        }
        public bool look_up(bool[] bit_array, int array_size, string s)
        {
            H1 h1 = new H1();
            H2 h2 = new H2();
            int first_hash_value = h1.Hash(s, array_size);
            int second_hash_value = h2.Hash(s, array_size);
            return bit_array[first_hash_value] && bit_array[second_hash_value];
        }
    }
}
