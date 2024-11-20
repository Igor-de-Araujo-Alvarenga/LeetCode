using IntroductionAlgorithms.Algorithms;

namespace IntroductionAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sort = new InsertionSort();

            var sorted = sort.Sort(new int[] {10,9,8,7,6,5,4,3,2,1} );
            var sortedDesc = sort.SortDesc(new int[] { 4, 8, 1, 20 });
        }
    }
}