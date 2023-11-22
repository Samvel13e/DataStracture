namespace DataStracture.LeetCode
{
    public class SolutionReverseList
    {
        public ListNode ReverseList(ListNode head)
        {
            Stack<int> stack = new();
            ListNode current = head;

            if (head == null)
            {
                return null;
            }
            while (current != null)
            {
                stack.Push(current.val);
                current = current.next;
            }

            ListNode newHead = new(stack.Pop());
            current = newHead;

            while (stack.Count > 0)
            {
                current.next = new(stack.Pop());
                current = current.next;
            }

            return newHead;
        }
    }
}
