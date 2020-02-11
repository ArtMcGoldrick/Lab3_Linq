using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            //Linq Query
            //var ouptut = from number in numbers
            //             where number > 5
            //             orderby number descending
            //             select number;

            var output = numbers
                .Where(num => num > 5)
                .OrderByDescending(n => n);

            foreach (int number in output)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
