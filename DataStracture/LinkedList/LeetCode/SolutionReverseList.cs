namespace DataStracture.LinkedList.LeetCode
{
    public class SolutionReverseList
    {
        public ListNode ReverseList(ListNode head)
        {

            ListNode resultNode = null;
            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }
            return resultNode;

            //Stack<int> stack = new();
            //ListNode current = head;

            //if (head == null)
            //{
            //    return null;
            //}
            //while (current != null)
            //{
            //    stack.Push(current.val);
            //    current = current.next;
            //}

            //ListNode newHead = new(stack.Pop());
            //current = newHead;

            //while (stack.Count > 0)
            //{
            //    current.next = new(stack.Pop());
            //    current = current.next;
            //}

            //return newHead;
        }
    }
}
