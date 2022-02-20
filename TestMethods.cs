using System.Collections.Generic;
using System;
namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            int numero;
            int tmp = 0;

            Stack<int> numbers = new Stack<int>();
            Stack<int> menosuno = new Stack<int>();


            while (numero >= 0)
            {
                numbers.Push(numero);     
                tmp = numbers.Peek();
                

                if(numbers.Contains() >= tmp)
                {
                    menosuno.Push(-1);
                }
                else
                {
                    menosuno.Push(tmp);
                }
            }

            foreach (int num in menosuno)
                Console.WriteLine("->{0}" ,num);

            Console.WriteLine("------");

            foreach (int num in numbers)
                Console.WriteLine("->{0}" ,num);

            Stack<int> result = menosuno;

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            //Console.WriteLine(" Array: ");//remove

            EValueType currType = 0;

            for (int i = 0; i < sourceArr.Length; i++)
            {
                int currNum = sourceArr[i];

                if (currNum % 2 == 0)
                {
                    currType = EValueType.Two;
                }
                else if (currNum % 3 == 0)
                {
                    currType = EValueType.Three;
                }
                else if (currNum % 5 == 0)
                {
                    currType = EValueType.Five;
                }
                else if (currNum % 7 == 0)
                {
                    currType = EValueType.Seven;
                }
                else if (currNum % currNum == 0)
                {
                    currType = EValueType.Prime;
                }

                result.Add(currNum, currType);

            }

            //foreach (var item in result)//remove
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);

            //}

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int typeCount = 0;

            foreach (var item in sourceDict)
            {
                if (item.Value == type)
                {
                    typeCount++;
                }
            }

            //if (typeCount > 1)//remove
            //{
            //    Console.WriteLine("there are " + typeCount + " " + type);

            //}
            //else
            //{
            //    Console.WriteLine("there is " + typeCount + " " + type);

            //}

            return typeCount;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            int[] keysArray = new int[sourceDict.Count];

            int auxIndex = 0;
            foreach (var item in sourceDict)
            {
                keysArray[auxIndex] = item.Key;
                auxIndex++;
            }

            //Console.WriteLine("array desordenado");//remove

            //for (int i = 0; i < keysArray.Length; i++)//remove
            //{
            //    Console.WriteLine(i + " = " + keysArray[i]);

            //}

            Array.Sort(keysArray);
            Array.Reverse(keysArray);

            //Console.WriteLine("array ordenado");//remove

            //for (int i = 0; i < keysArray.Length; i++)
            //{
            //    Console.WriteLine(i + " = " + keysArray[i]);

            //}

            for (int i = 0; i < keysArray.Length; i++)
            {
                int currKey = keysArray[i];
                result.Add(currKey, sourceDict[currKey]);

            }

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }
    }
}