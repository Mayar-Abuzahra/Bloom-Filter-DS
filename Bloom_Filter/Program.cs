namespace Bloom_Filter
{
    internal class Program
    {
        static double FalsePositiveRate(int m, int n)
        {
            //2: number of hash functions
            double p = Math.Exp(-2.0 * n / m);
            return Math.Pow(1 - p, 2);
        }
        static void Main(string[] args)
        {
            bool[] bitarray = new bool[10];
            int arr_size = 10;

            //sample example
            string[] array = { "history", "abounds", "abundance", "tree", "bloom",
                               "blossom", "flower", "math", "power", "school"};

            BloomFilter bf = new BloomFilter();

            for (int i = 0; i < 10; i++)
            {
                bf.insert(bitarray, arr_size, array[i]);
            }
            Console.WriteLine($"False positive rate: {FalsePositiveRate(arr_size, array.Length):P2}");
        }
    }
}