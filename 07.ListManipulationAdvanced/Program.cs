namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            bool isChanged = false;
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Contains":
                        int numberToContain = int.Parse(tokens[1]);
                        Console.WriteLine(numbers.Contains(numberToContain) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        GetSum(numbers);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numberToFilter = int.Parse(tokens[2]);
                        FilterNumbers(numbers, condition, numberToFilter);
                        break;
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void FilterNumbers(List<int> numbers, string condition, int numberToFilter)
        {
            List<int> result = new List<int>();
            switch (condition)
            {
                case ">":
                    result = numbers.Where(n => n > numberToFilter).ToList();
                    break;
                case "<":
                    result = numbers.Where(n => n < numberToFilter).ToList();
                    break;
                case ">=":
                    result = numbers.Where(n => n >= numberToFilter).ToList();
                    break;
                case "<=":
                    result = numbers.Where(n => n <= numberToFilter).ToList();
                    break;
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void GetSum(List<int> numbers)
        {
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> numbers)
        {
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static void PrintEven(List<int> numbers)
        {
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }

}
