using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                String nums = Console.ReadLine();
                int num = Convert.ToInt32(nums);
                sum += num;

                if (num == 999)
                {
                    Console.WriteLine(sum- 999);
                    break;
                }
                else nums = Console.ReadLine(); num = Convert.ToInt32(nums); sum += num;
            }
        }
    }
}
