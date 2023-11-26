using DataStracture.LinkedList;
using DataStracture.LinkedList.LeetCode;

namespace DataStracture
{
    public class Program
    {
        public static void Main()
        {
            ListNode list1 = new()
            {
                val = -1,
                next = new ListNode
                {
                    val = 2
                }
            };


            ListNode list2 = new()
            {
                val = 2,
                next = new ListNode
                {
                    val = 4,
                    next = new ListNode
                    {
                        val = 14,
                        next = new ListNode
                        {
                            val = 9,
                            next = new ListNode
                            {
                                val = 46
                            ,
                                next = new ListNode
                                {
                                    val = 7
                                }
                            }
                        }
                    }
                }
            };

            SolutionReverseList solutionReverseList = new SolutionReverseList();
            Display(solutionReverseList.ReverseList(list2));
            return;
            SolutionRemoveNthFromEnd solutionRemoveNthFromEnd = new();
            var kkkk = solutionRemoveNthFromEnd.RemoveNthFromEnd(list2, 2);
            Display(kkkk);

            return;
            SolutionDeleteDuplicate solutionDeleteDuplicate = new();
            solutionDeleteDuplicate.DeleteDuplicates(list2);
            return;
            SolutionMergeTwoLists solution = new();
            var kk = solution.MergeTwoLists(list1, list2);
            return;
            LinkedListSingle<int> list = [1, 3, 4, 5, 7, 8, 11];
            Display(list, "List");
            list.Remove(11);
            Display(list, "Remove 11");
            int[] arr = new int[9];
            list.CopyTo(arr, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        private static void Display(ListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
        public static void Display(LinkedListSingle<int> list, string test)
        {
            Console.WriteLine(test);
            foreach (int item in list)
            {
                Console.WriteLine(item + "  ");
            }
            Console.WriteLine("----////-----");
            Console.WriteLine();

        }
    }
}