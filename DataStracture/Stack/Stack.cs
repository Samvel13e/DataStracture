namespace DataStracture.Stack
{
    public class Stack<T>
    {
        private class Node(T data, Node next)
        {
            public T _data = data;
            public Node _next = next;
        }
        private Node top;
        private int count;
        public Stack()
        {
            top = null;
            count = 0;
        }
        public void Push(T item)
        {
            top = new Node(item, top);
            count++;
        }
        public T Pop()
        {
            T result = top._data;
            top = top._next;
            count--;
            return result;
        }
        public T Peek()
        {
            return top._data;
        }
    }
}
