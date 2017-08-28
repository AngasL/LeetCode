using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbersDanica(ListNode l1, ListNode l2)
        {
            var result = new ListNode(l1.val + l2.val);
            var root = result;

            while (l1.next != null || l2.next != null || result.val / 10 > 0)
            {
                var next = new ListNode(0);
                
                if (l1.next != null && l2.next != null)
                {
                    l1 = l1.next;
                    l2 = l2.next;
                    int more = result.val / 10;
                    next.val = l1.val + l2.val + more;
                }
                else if (l1.next != null)
                {
                    l1 = l1.next;
                    next.val = l1.val + result.val / 10;

                }
                else if (l2.next != null)
                {
                    l2 = l2.next;
                    next.val = l2.val + result.val / 10;
                }
                else
                {
                    next.val = result.val / 10;
                }
                result.val = result.val % 10;
                result.next = next;
                result = next;
            }

            return root;
        }

        public ListNode AddTwoNumbersAngas(ListNode l1, ListNode l2)
        {
            var result = new ListNode(l1.val + l2.val);
            var root = result;

            while (l1.next != null || l2.next != null)
            {
                if (l1.next != null && l2.next != null)
                {
                    l1 = l1.next;
                    l2 = l2.next;

                    var next = new ListNode(l1.val + l2.val);
                    result.next = next;
                    result = next;
                }
                else if (l1.next == null)
                {
                    result.next = l2.next;
                    break;
                }
                else
                {
                    result.next = l1.next;
                    break;
                }
            }

            result = root;
            while (result != null)
            {
                if (result.val >= 10)
                {
                    result.val = result.val - 10;
                    if (result.next != null)
                    {
                        result.next.val = result.next.val + 1;
                        result = result.next;
                    }
                    else
                    {
                        result.next = new ListNode(1);
                    }
                }
                else
                {
                    result = result.next;
                }
            }
            return root;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
