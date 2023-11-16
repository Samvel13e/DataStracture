namespace DataStracture
{
    public class Program
    {
        public static void Main()
        {
            LinkedList<int> list = [1, 5, 52, 10, 17];
            Display(list, "List");
            list.Remove(5);
            Display(list, "Remove 5 ");
            int[] arr = new int[5];
            list.CopyTo(arr, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Display(LinkedList<int> list, string test)
        {
            Console.WriteLine(test);
            foreach (int item in list)
            {
                Console.WriteLine(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}