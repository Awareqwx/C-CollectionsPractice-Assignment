using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {

        static void arrPrint(int[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        static void arrPrint(string[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static void arrPrint(bool[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static void arrPrint(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[");
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    if(j < arr.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
        }

        static void listPrint(List<string> lst)
        {
            Console.Write("<");
            for(int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i]);
                if(i < lst.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(">");
        }

        static void dictPrint(Dictionary<string, string> dict)
        {
            Console.Write("{  ");
            foreach(var elem in dict)
            {
                Console.Write(elem.Key + ":" + elem.Value + "  ");
            }
            Console.WriteLine("}");
        }

        static void Main(string[] args)
        {
            int[] oneToNine = new int[10];
            for(int i = 0; i < oneToNine.Length; i++)
            {
                oneToNine[i] = i;
            }
            arrPrint(oneToNine);
            Console.WriteLine();
            string[] names = new string[4];
            names[0] = "Tim";
            names[1] = "Martin";
            names[2] = "Nikki";
            names[3] = "Sara";
            arrPrint(names);
            Console.WriteLine();
            bool[] trueFalse = new bool[10];
            for(int i = 0; i < 10; i++)
            {
                trueFalse[i] = i % 2 == 0;
            }
            arrPrint(trueFalse);
            Console.WriteLine();
            int[,] multTable = new int[10, 10];
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    multTable[i - 1, j - 1] = i * j;
                }
            }
            arrPrint(multTable);
            Console.WriteLine();
            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Rocky Road");
            iceCream.Add("Mint Chip");
            iceCream.Add("Strawberry");
            iceCream.Add("Chocolate");
            Console.WriteLine(iceCream.Count);
            listPrint(iceCream);
            Console.WriteLine("Third element: " + iceCream[2]);
            iceCream.RemoveAt(2);
            listPrint(iceCream);
            Console.WriteLine();
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            Random r = new Random();
            for(int i = 0; i < 4; i++)
            {
                userInfo.Add(names[i], null);
                userInfo[names[i]] = iceCream[r.Next(0, 4)];
            }
            dictPrint(userInfo);
        }

    }
}
