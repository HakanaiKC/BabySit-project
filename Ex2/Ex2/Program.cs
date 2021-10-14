using System;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //int x, y;
            //x = Convert.ToInt32(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());           
            //for(int i = (int)x; i <= n; i++)
            //{
            //    y = i * i - (2 * i) + 1;
            //    Console.Write("{0} ",y);
            //}
            #endregion
            #region ex2
            //for(int i = 1; i <= 500; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.Write("{0} ", i);
            //}
            #endregion
            #region ex3
            //int user, pass;
            //int attempts = 0;

            //do
            //{
            //    user = Convert.ToInt32(Console.ReadLine());
            //    pass = Convert.ToInt32(Console.ReadLine());

            //    if ((user != 12) || (pass != 1234))
            //    {
            //        Console.WriteLine("Login failed");
            //        attempts++;
            //    }
            //}
            //while (((user != 12) || (pass != 1234)) && (attempts != 3));

            //if ((user == 12) || (pass == 1234))
            //    Console.WriteLine("Login successful");

            #endregion
            #region ex4
            //int num1, num2;
            //do
            //{
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //    if (num1 != 0)
            //    {
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Cannot divide by 0");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division is {0}", num1 / num2);
            //            Console.WriteLine("Remainder is {0}", num1 % num2);
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //while (num1 != 0);
            //Console.WriteLine("Goodbye!");
            #endregion
            #region ex5
            //int x = int.Parse(Console.ReadLine());
            //int x1 = x;
            //int y = int.Parse(Console.ReadLine());
            //for (int i = x; i <= y; i++)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();
            //while (x <= y)
            //{
            //    Console.Write("{0} ", x);
            //    x++;
            //}
            //Console.WriteLine();
            //do
            //{
            //    Console.Write("{0} ", x1);
            //    ++x1;
            //} while (x1 <= y);
            #endregion
            #region ex6
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0, max = arr[0], min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine("Sum: {0} {1}", arr.Sum(), sum);
            //double ave = sum / arr.Length;
            //Console.WriteLine("Mean: {0}", ave);
            //Console.WriteLine("Max: {0} {1}", arr.Max(), max);
            //Console.WriteLine("Min: {0} {1}", arr.Min(), min);
            #endregion
            #region ex7
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a > 0 ? "A is positive" : "A is not positive");
            //Console.WriteLine(b > 0 ? "B is positive" : "B is not positive");
            //Console.WriteLine((a > 0) && (b > 0) ? "Both are positive" : "Both are not positive");
            #endregion
            #region ex8
            //Console.Write("Enter quantity of values from the array of intergers: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] arr = new int[length];
            //for(int i = 0; i < length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //string num = "";
            //bool isFound = false;
            //do
            //{
            //    isFound = false;
            //    num = Console.ReadLine();
            //    if (num.Equals("end"))
            //    {
            //        break;
            //    }
            //    for(int i = 0; i < length; i++)
            //    {
            //        if (num.Equals(arr[i] +""))
            //        {
            //            Console.WriteLine("The number {0} exist", num);
            //            isFound = true;
            //            break;
            //        }
            //    }
            //    if (!isFound)
            //    {
            //        Console.WriteLine("Not existed");
            //    }
            //} while (true);
            #endregion
            #region ex9
            //int total = 10;
            //float[] numbers = new float[total];

            //float totalPositive = 0.0f, totalNegative = 0.0f;
            //int countPositive = 0, countNegative = 0;

            //for (int i = 0; i < total; i++)
            //{
            //    numbers[i] = Convert.ToSingle(Console.ReadLine());
            //}

            //for (int i = 0; i < total; i++)
            //{
            //    if (numbers[i] < 0) // Negative
            //    {
            //        totalNegative = totalNegative + numbers[i];
            //        countNegative++;
            //    }

            //    if (numbers[i] > 0) // Positive
            //    {
            //        totalPositive = totalPositive + numbers[i];
            //        countPositive++;
            //    }
            //}

            //Console.WriteLine("Average numbers negatives is {0}", totalNegative / countNegative);
            //Console.WriteLine("Average numbers positives is {0}", totalPositive / countPositive);
            #endregion
            #region ex10
            //int[,] arr = new int[2, 5];
            //double sum1 = 0;
            //double sum2 = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[0, i] = int.Parse(Console.ReadLine());
            //    sum1 += arr[0, i];
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[1, i] = int.Parse(Console.ReadLine());
            //    sum2 += arr[1, i];
            //}
            //Console.WriteLine("Average for group 1 is: {0}", sum1 / 5);
            //Console.WriteLine("Average for group 2 is: {0}", sum2 / 5);
            #endregion
            #region ex11

            //Car[] cars = new Car[3];

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[i] = new Car()
            //    {
            //        Model = Console.ReadLine(),
            //        YearOfProduction = int.Parse(Console.ReadLine())
            //    };
            //}

            //for (int i = 0; i < cars.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < cars.Length; j++)
            //    {
            //        if (cars[i].YearOfProduction > cars[j].YearOfProduction)
            //        {
            //            var aux = cars[i];

            //            cars[i] = cars[j];
            //            cars[j] = aux;
            //        }
            //    }
            //}
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    var car = cars[i];
            //    Console.WriteLine("Model: " + car.Model + ", " +
            //        "Year of production: " + car.YearOfProduction);
            //}
            #endregion
            #region ex12
            //string text = Console.ReadLine();
            //int position = Convert.ToInt32(Console.ReadLine());
            //char letter = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(ChangeLetter(text, position, letter));
            #endregion
            #region ex13
            //string text = Console.ReadLine();
            //Console.WriteLine(IsAlphabetic(text));
            #endregion
            #region ex14
            //string text = Console.ReadLine();
            //Console.WriteLine(IsNumber(text));
            #endregion
            #region ex15
            //double a = double.Parse(Console.ReadLine());
            //Cal(a);
            #endregion

        }
        public static string ChangeLetter(string text, int position, char letter)
        {
            text = text.Remove(position, 1);
            text = text.Insert(position, letter.ToString());

            return text;
        }

        public static bool IsAlphabetic(string text)
        {
            text.ToLower();
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] < 'a' || text[i] > 'z')
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsNumber(string text)
        {
            text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < '0' || text[i] > '1')
                {
                    return false;
                }
            }
            return true;
        }
        public static void Cal(double a)
        {
            Console.WriteLine(a * 2);
        }
    }
    class Car
    {
        public string Model;
        public int YearOfProduction;

        public Car()
        {

        }
    }
}

