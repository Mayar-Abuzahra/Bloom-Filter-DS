using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Bloom_Filter
{
    public class H2 : IHashFunction
    {
        public int Hash(string input, int array_size)
        {
            var charValues = input.Select(c => (int)c);
            var hash = charValues.Aggregate(1, (current, charValue) => (current * 19 + charValue) % array_size);
            return hash;
        }
    }
}
