using System;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {

            Tests test = new Tests();

            test.TestFillDictionaryFromSource(); 
            test.TestCountDictionaryRegistriesWithValueType(); 
            test.TestSortDictionaryRegistries();

            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");
        }
    }
}