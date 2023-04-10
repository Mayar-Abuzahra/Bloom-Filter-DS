using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloom_Filter
{
    public interface IHashFunction
    {
        public int Hash(string input, int array_size);
    }
}
