namespace DataStracture
{
    public class Program
    {
        public static void Main()
        {
            LinkedListSingle<int> list = [1,3,4,5,7,8,11];
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