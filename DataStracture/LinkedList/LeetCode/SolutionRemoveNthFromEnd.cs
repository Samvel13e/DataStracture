﻿namespace DataStracture.LinkedList.LeetCode
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
            current = newHead;
            int i = 0;
            int queueCount = queue.Count;
            while (queue.Count > 0)
            {
                i++;
                if (queueCount - i + 1 != n)
                {
                    current.next = new(queue.Dequeue());
                    current = current.next;
                }
                else
                    queue.Dequeue();
            }
            return newHead.next;
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
