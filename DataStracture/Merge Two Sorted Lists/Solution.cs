namespace DataStracture.Merge_Two_Sorted_Lists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode res = new();
            var current1 = list1;
            var current2 = list2;

            while (current1 != null)
            {
                while (current2 != null)
                {
                    if (current1.val <= current2.val)
                        res = current1;

                }
                current1 = current1.next;
            }
            return res;
        }
    }
}
