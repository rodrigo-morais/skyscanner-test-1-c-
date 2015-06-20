using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyscanner_test_1
{
    class Program
    {
        private static int solution(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return solution(n - 1) + int.Parse(Math.Pow(double.Parse(n.ToString()),2.0).ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            var n = 0;
            int.TryParse(Console.ReadLine(), out n);

            if(n == 0){
                Console.WriteLine("Not a number");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("The solution is: " + solution(n).ToString());
                Console.ReadLine();
            }

        }
    }
}
