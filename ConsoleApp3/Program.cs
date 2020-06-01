using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static int MinAbs(int[] arr, int n)
        {
            int index = 0;
            int min = arr[0];
            for (int i = 0; i < n; i++)
                if (Math.Abs(arr[i]) < min)
                { min = arr[i];
                    index = i;
                }
                    return index;
        }
        public static int Sum(int[] arr, int n)
        {
            int sum = 0;
            int index1 = -1;
            int index2 = -1;
            int i = 0;
            do
            {
                if (arr[i] < 0) index1 = i;
                i++;
            } while ((index1 == -1) && (i < n));
            i = n - 1;
            do
            {
                if (arr[i] < 0) index2 = i;
                i--;
            } while ((index1 == -1) && (i >= 0));

            
            
            if(index1 != -1)
            {
                for (int j = index1 + 1; j < index2; j++)
                    sum += arr[j];
            }
            return sum;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int min = -100, max = 100;
            Random realRnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = realRnd.Next(min, max + 1);
                Console.WriteLine("     " + arr[i]);

            }
            int minEl = MinAbs(arr, n);
            int sum = Sum(arr, n);
            Console.WriteLine("the index of the smallest number modulo is " + minEl);
            Console.WriteLine("the sum of elements between the first and the last positive number " + sum);



        }
    }
}
