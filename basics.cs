using System;
using System.Numerics;
using System.Linq;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Basics
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("calculate the average !");
            Console.Write("How many numbers do you want? Type in :");
            // 需要转换，因为读入的是字符串，这一点很像java
            int n = Convert.ToInt32(Console.ReadLine());
            double[] nums = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("put the number you want!");
                nums[i] = Convert.ToDouble(Console.ReadLine());
            }
            double avg = nums.Average();
            // 普通写法
            Console.Write("avg is " + avg + "\n");
            // 使用占位符写法
            Console.Write($"avg is {avg} \n");
            // 转义字符
            Console.Write($"avg is {avg}" + " \"this is it\"\n");
            // 下面使用foreach语法
            foreach (double x in nums)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n" + nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.Write("Next some two dimensional arrays!\n");
            int[,] multiDarr = {{1,2,3},{4,5,6}};
            for (int i = 0; i < multiDarr.GetLength(0); i++)
            {
                for (int j = 0; j < multiDarr.GetLength(1); j++)
                {
                    Console.Write(multiDarr[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}