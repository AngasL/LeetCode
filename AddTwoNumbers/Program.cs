using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var second = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var solution = new Solution();

            var result = solution.AddTwoNumbersAngas(first, second);//solution.AddTwoNumbersAngas(first, second);

            Console.WriteLine("result:");
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.Read();
        }
    }
}
