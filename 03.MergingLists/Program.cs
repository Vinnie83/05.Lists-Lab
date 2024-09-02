namespace _03.MergingLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();

            int count = firstList.Count;
            if (count < secondList.Count)
            {
                count = secondList.Count;   
            }

            for (int i = 0; i < count; i++)
            {
                if (i < firstList.Count)
                {
                    newList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    newList.Add(secondList[i]);
                }
               
            }

            Console.WriteLine(string.Join(" ", newList));

        }
    }
}