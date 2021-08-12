using System;

namespace 第十六课_continue和质数
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //练习1:用while continue实现计算 1到 100 (含)之间的除了能被 7 整除之外的所有整数的和
            //int sum = 0;
            //int i = 0;
            //while (i < 100)
            //{  
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //找出 100 内所有的质数
            //质数  :只能被 1 和这个数字本身整除的数字
            //2  3  5  7  9  11  13  17  19  21  23  27 29
            int x = 0;
            int i = 0;
            for (i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 && i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 || i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0)
                    {
                        i++;
                        continue;
                    }
                    x += i;

                }
            }

            Console.WriteLine(x);

            Console.ReadKey();








        }
    }
}
