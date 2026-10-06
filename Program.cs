using System;
using System.Collections.Generic;

namespace Week2Workshop
{
    // Task workshop: Circle class with a constant PI
    class Circle
    {
        public const double PI = 3.14;

        public static double Area(double radius)
        {
            return PI * radius * radius;
        }

        public static double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ---------- Task 1: Variables + string interpolation ----------
            Console.WriteLine("--- Task 1 ---");
            string userName = "Bhaskar";
            int luckyNumber = 7;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---------- Task 2: Constants ----------
            Console.WriteLine("\n--- Task 2 ---");
            Console.WriteLine($"PI = {Circle.PI}");
            Console.WriteLine($"Area (r=5) = {Circle.Area(5)}");
            Console.WriteLine($"Perimeter (r=5) = {Circle.Perimeter(5)}");

            // Uncomment the next line to see the compilation error:
            // Circle.PI = 3.14159;
            // Error CS0131: The left-hand side of an assignment must be a variable,
            // property or indexer. A const is fixed at compile time, so its value
            // can never be changed after it is declared.

            // ---------- Task 3: Data types and type conversion ----------
            Console.WriteLine("\n--- Task 3 ---");
            byte b = 200;
            short s = -12000;
            int i = 100000;
            long l = 9876543210L;
            float f = 3.14f;
            double d = 3.14159265359;
            decimal m = 99.99m;
            char c = 'A';
            bool flag = true;

            Console.WriteLine($"byte    : {b}");
            Console.WriteLine($"short   : {s}");
            Console.WriteLine($"int     : {i}");
            Console.WriteLine($"long    : {l}");
            Console.WriteLine($"float   : {f}");
            Console.WriteLine($"double  : {d}");
            Console.WriteLine($"decimal : {m}");
            Console.WriteLine($"char    : {c}");
            Console.WriteLine($"bool    : {flag}");

            int number = 42;
            string numberAsString = number.ToString();   // int -> string
            Console.WriteLine($"int 42 converted to string: \"{numberAsString}\" (type: {numberAsString.GetType().Name})");

            string piText = "3.14";
            double piValue = double.Parse(piText, System.Globalization.CultureInfo.InvariantCulture);   // string -> double
            Console.WriteLine($"string \"3.14\" converted to double: {piValue} (type: {piValue.GetType().Name})");

            // ---------- Task 4: Arrays ----------
            Console.WriteLine("\n--- Task 4 ---");
            int[] numbers = { 9, 3, 7, 1, 5 };

            Array.Sort(numbers);       // ascending
            Console.WriteLine("Sorted (ascending):");
            PrintArray(numbers);

            Array.Reverse(numbers);    // reverse the sorted array
            Console.WriteLine("Reversed (descending):");
            PrintArray(numbers);

            int searchFor = 7;
            int index = Array.IndexOf(numbers, searchFor);
            Console.WriteLine($"Index of {searchFor} in the array: {index}");

            // ---------- Task 5: DateTime and TimeSpan ----------
            Console.WriteLine("\n--- Task 5 ---");
            DateTime birthDate = new DateTime(2004, 1, 1);   // change to your real birthdate
            DateTime now = DateTime.Now;

            TimeSpan difference = now - birthDate;
            int ageInYears = (int)(difference.TotalDays / 365.25);

            Console.WriteLine($"Birthdate    : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Current date : {now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Age in years : {ageInYears}");

            DateTime birthPlus10 = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {birthPlus10:yyyy-MM-dd}");

            // ---------- Task 6: List and Dictionary ----------
            Console.WriteLine("\n--- Task 6 ---");
            List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Apple");

            Console.WriteLine("Fruits in list:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                { 1, "Mango" },
                { 2, "Apple" },
                { 3, "Banana" }
            };
            fruitDict.Add(4, "Orange");

            Console.WriteLine("Fruit dictionary:");
            foreach (KeyValuePair<int, string> pair in fruitDict)
            {
                Console.WriteLine($"ID: {pair.Key}, Fruit: {pair.Value}");
            }

            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine($"  [{k}] = {arr[k]}");
            }
        }
    }
}