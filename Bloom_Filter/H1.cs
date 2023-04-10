using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bloom_Filter
{
    public class H1 : IHashFunction
    {
        public int Hash(string input, int array_size)
        {
            int hash = input.Sum(c => (int)c) % array_size;
            return hash < 0 ? hash + array_size : hash;
        }
    }
}
