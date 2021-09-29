/*
Simon Rimpi Heinonen
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Hello World!");
            while(running)
            {

                Console.WriteLine("What do you want to do?" +
                    "\n0:Exit\n1:Exception" +
                    "\n2:Array Example" +
                    "\n3:Dictionary Example" +
                    "\n4:String List Example" +
                    "\n5:Speed test between string and Stringbuilder" +
                    "\n6:Stringbuilder write At position" +
                    "\n7:Append Name To SB" +
                    "\n8:Append Name To String" +
                    "\n9:Convert String To SB" +
                    "\n10:Change Letter At" +
                    "\n11:Random example" +

                    "\n");


                int action = GetIntFromUser();
                switch (action)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        PlayException();
                        break;

                    case 2:
                        PlayWithArray();
                        break;

                    case 3:
                        PlayWithDictionary();
                        break;

                    case 4:
                        PlayWithStringList();
                        break;

                    case 5:
                        StringbuildVersusString();
                        break;

                    case 6:
                        PrintSBAtPosition();
                        break;

                    case 7:
                        StringBuilder strB = new StringBuilder("Mitt namn:");
                        Console.WriteLine(strB);

                        AppendNameToSB(strB);
                        Console.WriteLine("Append name:"+strB);
                        Console.Read();

                        break;

                    case 8:
                        string str = "Mitt namn:";
                        Console.WriteLine(str);
                        // need to have a return when appending to str.
                        str = AppendNameToStr(str);
                        Console.WriteLine("Append name:" + str);
                        Console.Read();
                        break;

                    case 9:
                        string myOwnString = "My lovely string";
                        StringBuilder myStrB = new StringBuilder();
                        myStrB = ConvertStringToSB(myOwnString);
                        Console.Read();
                        break;

                    case 10:
                        StringBuilder strBChangeLetter = new StringBuilder("ABCDEFG");
                        ChangeLetterAt(2, 'ö', strBChangeLetter);
                        Console.WriteLine(strBChangeLetter);
                        Console.Read();
                        break;

                    case 11:
                        RandomExamples();
                        Console.Read();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;

                }

            }



        }

        static void RandomExamples()
        {
            Random rnd = new Random(10);
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
            string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

            int mIndex = rnd.Next();
            int fIndex;
            Console.WriteLine("Next():"+mIndex);

            mIndex = rnd.Next(10);
            Console.WriteLine("Max Value -> Next(10):" + mIndex);

            mIndex = rnd.Next(-10, 0);
            Console.WriteLine("Min -10, Max 0 -> Next(-10, 0):" + mIndex);

            mIndex = rnd.Next(malePetNames.Length);
            fIndex = rnd.Next(femalePetNames.Length);

            Console.WriteLine("Pet names of the day: ");
            Console.WriteLine("For a male: {0}", malePetNames[mIndex]);
            Console.WriteLine("For a female: {0}", femalePetNames[fIndex]);

        }

        static void ChangeLetterAt(int position, char letter, StringBuilder yourStringBuilder)
        {
            yourStringBuilder[position] = letter;
        }

        // Does not work!
        //static void AppendNameToStr(string str)
        //{
        //    string str1 = "Simon";
        //    str += str1;
        //}
        static string AppendNameToStr(string str)
        {
            string str1 = "Simon";
            str += str1;
            return str;
        }

        static void AppendNameToSB(StringBuilder strB)
        {
            strB.Append("Simon");
        }

        static StringBuilder ConvertStringToSB(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            
            return strB;
        }

        static void PrintSBAtPosition()
        {
            StringBuilder strB = new StringBuilder("Lexicon");
            Console.WriteLine("String is " + strB.ToString());

            for (int i = 0; i < strB.Length; i++)
            {
                char charAt = strB[i];

                Console.WriteLine("Char at position " + i + " is " + charAt);
            }
            Console.Read();
        }

        static void StringbuildVersusString()
        {
            string testSubjectString = "Lexicon";

            DateTime startString = DateTime.Now;
            Console.WriteLine("Start:" + startString);
            for(int i = 0; i < 200000; i++ )
            {
                testSubjectString += "!";
            }

            DateTime endString = DateTime.Now;
            Console.WriteLine(endString-startString);

            StringBuilder testSubjectStringBuilder = new StringBuilder("Lexicon");
            DateTime startSB = DateTime.Now;
            Console.WriteLine("Start:" + startSB);
            for (int i = 0; i < 200000; i++)
            {
                testSubjectStringBuilder.Append("!");
            }
            DateTime endSB = DateTime.Now;
            Console.WriteLine(endSB - startSB);


            Console.Read();
        }

        static void PlayException()
        {
            int[] array = new int[10];
            Console.WriteLine(array.Length);
            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    array[i] = 10;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void PlayWithArray()
        {
            Console.WriteLine("PlayWithArray, Create an array. Add value to all the slots. Do multiplication table and print it out.");

            int[,] multipleTable = new int[10, 10];

            for (int i = 0; i < multipleTable.GetLength(0); i++)
            {
                for (int y = 0; y < multipleTable.GetLength(1); y++)
                {
                    multipleTable[i, y] = (y + 1) * (i + 1);
                }
            }

            for (int i = 0; i < multipleTable.GetLength(0); i++)
            {
                for (int y = 0; y < multipleTable.GetLength(1); y++)
                {
                    Console.WriteLine(multipleTable[y, i]);

                }
                Console.WriteLine();
            }
        }

        static void PlayWithDictionary()
        {
            Console.WriteLine("PlayWithDictionary, Create a dictionary. Add a key paired with a value. Write that name and key to the console.");

            // key = position
            // value = person's name
            Dictionary<string, int> population = new Dictionary<string, int>();

            population.Add("Skövde", 0);
            population.Add("Göteborg", 0);

            population["Skövde"] = 1000;
            foreach (KeyValuePair<string, int> city in population)
            {
                Console.WriteLine(city.Key + " - " + city.Value);
            }
        }

        static void PlayWithStringList()
        {
            Console.WriteLine("PlayWithString, add a name in a list of strings. Write that name out.");
            List<string> petNames = new List<string>();
            petNames.Add("Max");
            petNames.Add(Console.ReadLine());

            foreach (string name in petNames)
            {
                Console.WriteLine(name);
            }
            var names = petNames.FindAll(s => s.Equals("Max"));
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
