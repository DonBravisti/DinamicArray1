using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var list = Console.ReadLine().Split().ToList().ConvertAll(Convert.ToInt32);

            var m = Convert.ToInt32(Console.ReadLine());
            var list1 = Console.ReadLine().Split().ToList().ConvertAll(Convert.ToInt32);

            var res = new List<int>();
            int u1 = 0, u2 = 0;

            while (u1 < list.Count && u2 < list1.Count)
            {
                if(list[u1] == list1[u2])
                {
                    res.Add(list[u1]);
                    u1++; u2++;
                }
                else
                {
                    if (list[u1] > list1[u2]) u2++;
                    else u1++;
                }
            }

            foreach (var item in res)
                Console.Write("{0} ", item);
        }
    }
}
