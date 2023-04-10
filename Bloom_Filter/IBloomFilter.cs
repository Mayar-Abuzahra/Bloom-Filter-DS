using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloom_Filter
{
    public interface IBloomFilter
    {
        void insert(bool[] bit_array, int array_size, string s);
        bool look_up(bool[] bit_array, int array_size, string s);
    }
}
