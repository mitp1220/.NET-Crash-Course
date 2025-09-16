using System;
// Ex-1
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int i = 0;
//        while (i < 5)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }
//}

// EX-2
//using System;
// class Temp
//{
//    static void Main()
//    {
//        System.Console.Write("Enter the number you want to have :");
//        int i = int.Parse(System.Console.ReadLine());
//        while (i < 50)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }

//}

//EX-3
//class Temp
//{
//    static void Main()
//    {
//        int i = 1;
//        do
//        {
//            Console.WriteLine(i);
//            i++;
//        } while (i <= 5);
//    }
//}
// EX-4
//class Temp
//{
//    static void Main()
//    {
//        int i = 6;
//        do
//        {
//            Console.WriteLine(i);
//            i++;
//        } while (i <= 5);
//    }
//}


//EX-5


// EX-6
//using System;
//class Temp
//{
//    static void Main()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

// EX-7
//using System;
//class Temp
//{
//    static void Main()
//    {
//        for (int i = 0, j = 10; i < 10 && j > 0; i++, j--)
//        {
//            Console.WriteLine(i + " " + j);
//        }
//    }
//}

// EX-8
//using System;
//using System.Threading;
//class Temp
//{
//    static void Main()
//    {
//    outer:
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 10; j > 0; j--)
//            {
//                Console.WriteLine(i + " " + j);
//            }
//        }
//    }
//}

// EX-9
//using System;
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine(i);
//            if (i == 5)
//            {
//                break; // Exit the loop when i is 5
//            }
//        }
//        Console.WriteLine("Loop ended.");
//    }
//}

//EX-10
//using System;
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {

//            if (i == 5)
//            {
//                continue; // Skip the iteration of the loop when i is 5
//            }
//            Console.WriteLine(i);
//        }
//        Console.WriteLine("Loop ended.");
//    }
//}

// EX-11
//using System;
// class Program
//{
//    static void Main()
//    {
//    enterNumber:
//        Console.WriteLine("Enter number between 1 and 5");
//        string input = Console.ReadLine();
//        if (!int.TryParse(input, out int result) || result < 0 || result > 5)
//        {
//            goto enterNumber;
//        }
//    }
//}

// EX-12
//using System;
//class Program
//{
//    static void Main()
//    {
//        int i = 0;
//        int j = 10;
//        for (; i <= 10; i++)
//        {
//            for (; j > 0; j--)
//            {
//                if (i == j)
//                {
//                    goto OuterLoop; // Skip this i and go to next i
//                }
//                Console.WriteLine($"i = {i}, j = {j}");
//            }
//        }
//    OuterLoop:
//        Console.WriteLine("Loop ended.");
//    }
//}

// EX-13
//using System;
//class Program
//{
//    static void Main()
//    {
//        int i = 0;
//    OuterLoop:
//        for (; i <= 10; i++)
//        {
//            int j = 10;
//            for (; j > 0; j--)
//            {
//                if (i == j)
//                {
//                    i++;
//                    goto OuterLoop; // Skip this i and go to next i
//                }
//                Console.WriteLine($"i = {i}, j = {j}");
//            }
//        }
//        Console.WriteLine("Loop ended.");
//    }
//}

// EX=14
//class Temp
//{
//    static void Main()
//    {
//        string correctPin = "2345";
//        int attemptCount = 0;
//        const int maxAttempt = 3;
//        System.Console.WriteLine("Enter a pin");
//        while (attemptCount <= maxAttempt)
//        {
//            if (attemptCount == maxAttempt)
//            {
//                System.Console.WriteLine("Maximum attempts done! Card Blocked..");
//                break;
//            }
//            string enteredPin = System.Console.ReadLine();
//            attemptCount++;
//            if (string.IsNullOrEmpty(enteredPin))
//            {
//                attemptCount--;
//                System.Console.WriteLine("Empty Input!!");
//                continue;
//            }
//            if (enteredPin == correctPin)
//            {
//                System.Console.WriteLine("Access granted");
//                break;
//            }
//            else
//            {
//                Console.WriteLine($"Enter a correct pin, Attempts left {maxAttempt
//attemptCount}");
//            }
//        }
//    }
//}

// EX-15
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int i = 0;
//        for (; ; )
//        {
//            Console.WriteLine(i += 2);
//            if (i == 10)
//            {
//                break;
//            }
//        }
//    }
//}

// EX-16 2nd pdf(Array, List, & Dictionary)
//EG-1
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int[] number;
//        number = new int[5];
//        for (int i = 0; i < number.Length; i++)
//        {
//            System.Console.WriteLine($"Enter the {i} element");
//            number[i] = int.Parse(System.Console.ReadLine());
//        }
//        foreach (int i in number)
//        {
//            System.Console.Write(i + ",");
//        }
//    }
//}

// EG-2
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int[] arr = { 5, 3, 8, 1, 4 };
//        // 1. Array.Sort(arr)
//        Array.Sort(arr);
//        Console.WriteLine("Sorted: " + string.Join(", ", arr));
//        // Output: 1, 3, 4, 5, 8
//        // 2. Array.Reverse(arr)
//        Array.Reverse(arr);
//        Console.WriteLine("Reversed: " + string.Join(", ", arr));
//        // Output: 8, 5, 4, 3, 1
//        // 3. Array.IndexOf(arr, value)
//        int index = Array.IndexOf(arr, 4);
//        Console.WriteLine("Index of 4: " + index);
//        // Output: 2 (because after reverse, 4 is at index 2)
//        // 4. Array.Clear(arr, startIndex, length)
//        Array.Clear(arr, 1, 2); // clears elements at index 1 & 2
//        Console.WriteLine("After Clear: " + string.Join(", ", arr));
//        // Output: 8, 0, 0, 3, 1 (0 is default for int)
//        // 5. Array.Copy(source, destination, length)
//        int[] copyArray = new int[5];
//        Array.Copy(arr, copyArray, arr.Length);
//        Console.WriteLine("Copied array: " + string.Join(", ", copyArray));
//        // 6. Clone()
//        int[] clonedArray = (int[])arr.Clone();
//        clonedArray[0] = 999; // Changing cloned array won't affect original
//        Console.WriteLine("Cloned array: " + string.Join(", ", clonedArray));
//        Console.WriteLine("Original array after clone modification: " +
//string.Join(", ", arr));
//    }
//}

// EG=3
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int[,] rect = new int[2, 3]
//        {
// {1,2,3},
// {4,5,6}
//        };
//        int[][] jagged = new int[2][]
//        {
// new int[]{1,2,30 },
// new int[]{4,5,60 }
//        };
//        System.Console.WriteLine(rect[0, 2]);
//        System.Console.WriteLine(jagged[0][2]);
//    }
//}

// EG-4
//using System;
//class Temp
//{
//    static void Main()
//    {
//        int[,] rect = new int[2, 3]
//        {
//         {1,2,3},
//         {4,5,6}
//        };
//        int[][] jagged = new int[2][]
//        {
//         new int[]{1,2,30 },
//         new int[]{4,5,60 }
//        };
//        for (int i = 0; i < rect.GetLength(0); i++)
//        {
//            for (int j = 0; j < rect.GetLength(1); j++)
//            {
//                System.Console.Write(rect[i, j] + "\t");
//            }
//            System.Console.WriteLine();
//        }
//        foreach (int[] i in jagged)
//        {
//            foreach (int j in i)
//            {
//                System.Console.Write(j + "\t");
//            }
//            System.Console.WriteLine();
//        }
//    }
//}


// Lists
//EX-1
//using System;
//using System.Collections.Generic;
//class Lists
//{
//    static void Main()
//    {
//        var list1 = new List<string>(5) { "Ok", "Heelo" };
//        list1.Add("How");
//        foreach (var item in list1)
//        {
//            System.Console.WriteLine(item);
//        }
//        list1.Remove("Ok");
//        foreach (var item in list1)
//        {
//            System.Console.WriteLine(item);
//        }
//        System.Console.WriteLine(list1[list1.Count - 1]);
//    }
//}

// EX-2
//using System;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//class Program
//{
//    static void Main()
//    {
//        // 1. Initialize a list with initial values (strings)
//        var items = new List<string> { "apple", "banana", "cherry" };
//        // :contentReference[oaicite:0]{index=0}
//        // 2. Add elements
//        items.Add("date");
//        //element: contentReference[oaicite: 1]{ index = 1}
//        items.AddRange(new[] { "elderberry", "fig" });
//        //elements: contentReference[oaicite: 2]{ index = 2}
//        // 3. Insert at specific position
//        items.Insert(2, "blueberry");
//        // :contentReference[oaicite:3]{index=3}
//        // 4. Modify via index
//        items[1] = "blackberry";
//        // :contentReference[oaicite:4]{index=4}
//        // 5. Search operations
//        bool hasCherry = items.Contains("cherry");
//        // :contentReference[oaicite:5]{index=5}
//        int idx = items.IndexOf("fig");
//        // :contentReference[oaicite:6]{index=6}
//        int lastIdx = items.LastIndexOf("fig");
//        // :contentReference[oaicite:7]{index=7}
//        // 6. Find all items containing 'e'
//        var withE = items.FindAll(s => s.Contains("e"));
//        // :contentReference[oaicite:8]{index=8}
//        // 7. Remove elements
//        items.Remove("banana");
//        // Remove by value :contentReference[oaicite:9]{index=9}
//        items.RemoveAt(0);
//        // Remove by index :contentReference[oaicite:10]{index=10}
//        // Add single
//        // Add multiple
//        // 8. Sort and reverse
//        items.Sort();
//        // Ascending :contentReference[oaicite:11]{index=11}
//        items.Sort((a, b) => b.CompareTo(a));
//        // Descending using lambda :contentReference[oaicite:12]{index=12}
//        items.Reverse();
//        // Reverse list :contentReference[oaicite:13]{index=13}
//        // 9. Copy the list (shallow copy)
//        var copy = new List<string>(items);
//        // :contentReference[oaicite:14]{index=14}
//        // 10. Clear the list
//        items.Clear();
//        // :contentReference[oaicite:15]{index=15}
//        // Output to verify behavior
//        Console.WriteLine("Has 'cherry'? " + hasCherry);
//        Console.WriteLine($"Index of 'fig': {idx}, LastIndex: {lastIdx}");
//        Console.WriteLine("Items containing 'e': " + string.Join(", ", withE));
//        Console.WriteLine("Final copy list contents: " + string.Join(", ", copy));
//        Console.WriteLine("Original list count after Clear(): " + items.Count);
//    }
//}


// Dictionary
// EX-1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, string> dic = new Dictionary<int, string>()
// {{1,"Hello"},{2,"Hi"} };
//        var dic2 = new Dictionary<int, string>();
//        dic2.Add(3, "Hello");
//        dic2.Add(4, "Hello");
//        //dic2.Add(3, "Hi");
//        //System.Console.WriteLine(dic[1]);
//        //System.Console.WriteLine(dic2[3]);
//        foreach (KeyValuePair<int, string> kvp in dic)
//        {
//            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//        }
//        string x = null;
//        x = dic.TryGetValue(1, out string y) ? y : (string)null;
//        System.Console.WriteLine(x);
//    }
//}

// EX-2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        var i = new Dictionary<int, string>();
//        var j = new int[] { 1, 2, 3 };
//        var k = new string[] { "ABC", "PQR", "STU" };
//        for (int p = 0; p < j.Length; p++)
//        {
//            i.Add(j[p], k[p]);
//        }
//        ;
//        foreach (KeyValuePair<int, string> kvp in i)
//        {
//            Console.WriteLine(kvp.Key + ":" + kvp.Value);
//        }
//        i.Remove(1);
//        if (i.ContainsKey(1))
//        {
//            Console.WriteLine(i[0]);
//        }
//        else
//        {
//            System.Console.WriteLine("No key :1");
//        }
//    }
//}

// EX-3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        var dict = new Dictionary<string, string>();
//        dict.Add("OK", "ok");
//        dict.Add("HELLO", "hello");
//        foreach (var item in dict)
//        {
//            if (item.Value == "hello")
//            {
//                System.Console.WriteLine(item.Key);
//            }
//        }
//    }
//}


// OOPS

