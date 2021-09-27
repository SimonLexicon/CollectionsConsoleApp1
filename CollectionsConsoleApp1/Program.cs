using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(GetIntFromUser());
            //int[] array = new int[10];
            //Console.WriteLine(array.Length);
            //try
            //{
            //    for(int i = 0; i <= array.Length; i++)
            //    {
            //        array[i] = 10;
            //    }
            //}
            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Something went wrong");
            //}
            //int[,] multipleTable = new int[10,10];

            //for (int i = 0; i < multipleTable.GetLength(0); i++)
            //{
            //    for (int y = 0; y < multipleTable.GetLength(1); y++)
            //    {
            //        multipleTable[i, y] = (y + 1) * (i + 1);
            //    }
            //}

            //for (int i = 0; i < multipleTable.GetLength(0); i++)
            //{
            //    for(int y = 0; y < multipleTable.GetLength(1); y++)
            //    {
            //        Console.WriteLine(multipleTable[y, i]);

            //    }
            //    Console.WriteLine();
            //}
            // key = position
            // value = person's name
            //Dictionary<string, int> population = new Dictionary<string, int>();

            //population.Add("Skövde", 0);
            //population.Add("Göteborg", 0);

            //population["Skövde"] = 1000;
            //foreach(KeyValuePair<string, int> city in population)
            //{
            //    Console.WriteLine(city.Key + " - " + city.Value);
            //}
            List<string> petNames = new List<string>();
            petNames.Add("Max");
            petNames.Add(Console.ReadLine());

            foreach(string name in petNames)
            {
                Console.WriteLine(name);
            }
            var names = petNames.FindAll(s=> s.Equals("Max"));
            Console.ReadKey();

        }

        static int GetIntFromUser()
        {
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("Your value was too long.");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Could not parse, value was NULL");
            }
            catch(FormatException)
            {
                Console.WriteLine("Format was wrong.");
            }

            return number;
        }
    }
}
