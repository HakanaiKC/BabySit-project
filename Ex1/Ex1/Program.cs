using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //Console.WriteLine(24 / 5);
            #endregion
            #region ex2
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            #endregion
            #region ex3
            //Console.WriteLine("Input the first number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first number: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            //Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            //Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            //Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            //Console.WriteLine("{0} mod {1}={2}", a, b, a % b);
            #endregion
            #region ex4
            //Console.WriteLine("Input the first number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first number: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first number: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first number: ");
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4}",a,b,c,d,(a+b+c+d)/4);
            #endregion
            #region ex5
            //int n, reverse = 0, temp;
            //Console.Write("Input a number: ");
            //n = int.Parse(Console.ReadLine());
            //while (n != 0)
            //{
            //    temp = n % 10;
            //    reverse = reverse * 10 + temp;
            //    n /= 10;
            //}
            //Console.Write("The number in reverse order is : " + reverse);
            #endregion
            #region ex6
            //Console.Write("Input the number of elements to store in the array :");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //Console.WriteLine("Input {0} number of elements in the array : ", n);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("element - {0} : ",i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The values store into the array are: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0} ", array[i]);
            //}
            //Console.WriteLine("The values store into the array in reverse are: ");
            //for (int i = n; i > 0; i--)
            //{
            //    Console.Write("{0} ", array[i]);
            //}
            #endregion
            #region ex7
            //Console.Write("Input the number of elements to store in the array :");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //Console.WriteLine("Input {0} number of elements in the array : ", n);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("element - {0} : ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The Even elements are: ");
            //for (int i = 0; i < n; i++)
            //{
            //    if(i % 2 == 0) 
            //        Console.Write("{0} ", array[i]);
            //}
            //Console.WriteLine("/nThe Odd elements are : ");
            //for (int i = 0; i < n; i++)
            //{
            //    if (i / 2 == 0)
            //        Console.Write("{0} ", array[i]);
            //}
            #endregion
            #region ex8
            //int[] array = new int[100];
            //int i, n, p, x;

            //Console.Write("Input the size of array : ");
            //n = int.Parse(Console.ReadLine());

            //Console.Write("Input {0} elements in the array in ascending order:\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Input the value to be inserted : ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Input the Position, where the value to be inserted :");
            //p = int.Parse(Console.ReadLine());

            //Console.Write("The current list of the array :\n");
            //for (i = 0; i < n; i++)
            //    Console.Write("{0} ", array[i]);

            //for (i = n; i >= p; i--)
            //    array[i] = array[i - 1];

            //array[p - 1] = x;

            //Console.Write("\n\nAfter Insert the element the new list is :\n");
            //for (i = 0; i <= n; i++)
            //    Console.Write("{0} ", array[i]);
            #endregion
            #region ex9
            //string str = "Fpt@university";
            //Console.WriteLine(str.Remove(0, 1));
            //Console.WriteLine(str.Remove(3,1));
            //Console.WriteLine(str.Remove(str.Length-1, 1));
            #endregion
            #region ex10
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            #endregion
            #region ex11
            //string text;
            //string[] stringList;
            //int index = 0, max = 0;
            //text = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            //Console.Write("Test data: {0}", text);
            //stringList = text.Split(' ');
            //for (int i = 0; i < stringList.Length; i++)
            //{
            //    if (stringList[i].Length > max)
            //    {
            //        max = stringList[i].Length;
            //        index = i;
            //    }
            //}
            //Console.WriteLine("\nSample Output: {0} ", stringList[index]);
            #endregion
            #region ex12
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("Original String: " + line);
            string result = "";
            string[] words = line.Split(' ');   
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            Console.WriteLine("\nReverse String: " + result);
            #endregion
        }
        public static string first_last(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
