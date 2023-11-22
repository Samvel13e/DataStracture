namespace DataStracture.LinkedList.LeetCode
{
    internal class SolutionRemoveNthFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Queue<int> queue = new();
            ListNode current = head;

            if (head == null)
            {
                return null;
            }
            while (current != null)
            {
                queue.Enqueue(current.val);
                current = current.next;
            }

            if (queue.Count == n)
            {
                return head.next;
            }

            ListNode newHead = new();
            for (int i = 0; i < queue.Count; i++)
            {
                if (i != n)
                {
                    newHead.next = new(queue.ElementAt(i));
                }
            }
            return newHead.next;
            //ListNode newHead = new(queue.Dequeue());
            //current = newHead;
            //var count = 1;
            //while (queue.Count > 0)
            //{
            //    current.next = new(queue.Dequeue());
            //    if (count != n)
            //    {
            //        current = current.next;
            //    }
            //    count++;
            //}
            //return newHead;
        }
        //public ListNode RemoveNthFromEnd(ListNode head, int n)
        //{
        //    ListNode newHead = ReverseList(head);
        //    ListNode current = newHead;
        //    ListNode previous = null;
        //    int count = 0;
        //    while (current != null)
        //    {
        //        count++;
        //        if (count == n)
        //        {
        //            if (previous == null)
        //            {
        //                newHead = newHead.next;
        //                break;
        //            }
        //            else
        //            {
        //                previous.next = current.next;
        //                break;
        //            }
        //        }
        //        previous = current;
        //        current = current.next;
        //    }
        //    return ReverseList(newHead);
        //}

        //public ListNode ReverseList(ListNode head)
        //{
        //    Stack<int> stack = new();
        //    ListNode current = head;

        //    if (head == null)
        //    {
        //        return null;
        //    }
        //    while (current != null)
        //    {
        //        stack.Push(current.val);
        //        current = current.next;
        //    }

        //    ListNode newHead = new(stack.Pop());
        //    current = newHead;

        //    while (stack.Count > 0)
        //    {
        //        current.next = new(stack.Pop());
        //        current = current.next;
        //    }

        //    return newHead;
        //}
    }
}
