using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Linq_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mary", "Joseph", "Micheal", "Sarah", "Margaret", "John" };

            var query = names
            .OrderByDescending(n => n);
            //.Where(n => n < "M");

            foreach (var item in query)
            {
                Console.WriteLine(item);

            }
        }
    }
}
