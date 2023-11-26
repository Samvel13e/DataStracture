namespace DataStracture.LinkedList.LeetCode
{
    public class SolutionIsPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode current = head;
            ListNode reversedNode = null;
            while (current != null)
            {
                reversedNode = new ListNode(current.val, reversedNode);
                current = current.next;
            }

            while (reversedNode != null)
            {
                if (reversedNode.val != head.val) return false;
                reversedNode = reversedNode.next;
                head = head.next;
            }
            return true;
        }
    }
}
