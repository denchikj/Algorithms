namespace Algorithms.MergeKSortedLists
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;

            return MergeKHelper(lists, 0, lists.Length - 1);
        }

        static ListNode MergeKHelper(ListNode[] lists, int i, int j)
        {
            if (i == j) return lists[i];

            int mid = i + (j - i) / 2;
            var left = MergeKHelper(lists, i, mid);
            var right = MergeKHelper(lists, mid + 1, j);
            return MergeTwoLists(left, right);
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var current = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;
            return head.next;
        }

        static void Main(string[] args)
        {
            int sum = 0;

            var input = new ListNode[]
            {
                new ListNode(1, new ListNode(4, new ListNode(5, null))),
                new ListNode(1, new ListNode(3, new ListNode(4, null))),
                new ListNode(2, new ListNode(6, null))
            };

            var result = MergeKLists(input);

            while (result != null)
            {
                sum += result.val;
                result = result.next;
            }

            Console.WriteLine(sum);
        }
    }    
}