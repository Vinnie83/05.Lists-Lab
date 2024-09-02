namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {

                string line = Console.ReadLine();   

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch(tokens[0])
                {

                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToAssert = int.Parse(tokens[1]);
                        int indexToAssert = int.Parse(tokens[2]);
                        numbers.Insert(indexToAssert, numberToAssert);
                        break;
                }


            }

            Console.WriteLine(string.Join(" ", numbers));  
        }
    }
}