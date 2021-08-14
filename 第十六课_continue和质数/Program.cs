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
            int i = 0;
            int sum = 0;
            for (i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)   //假设i等于5/2
                {
                    if (i % j == 0)          //这个条件达不到
                    {
                        b = false;             //达不到就不用显示了，
                        break;             //直接退出
                    }
                    if (b)                   //上面的if不符合，进入下面的if
                    {
                        Console.WriteLine("答：100以内的质数有{0}", i);//条件符合打印出来
                        sum = i;

                        break;//取到了i的值以后 退出循环。斗则退出来之后进入J++  开始算5/3   5/4   
                    }
                }
            }
            sum += i;
            Console.WriteLine("这些质数相加起来的和是", sum);

            Console.ReadKey();








        }
    }
}
