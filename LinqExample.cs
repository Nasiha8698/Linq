using System;
using System.Linq;
using System.Text;

namespace LinqExample
{
    class program
    {
        Public Static void Main(string[] args)
        {

            var oddNums = Enumerable.Range(20, 20).Where(x => x % 2 != 0);

            foreach (int n in oddNums)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
