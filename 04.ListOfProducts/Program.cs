﻿namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);

            }

            products.Sort();

            for (int i = 0;i < products.Count;i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}"); 
            }

        }  

    }
}