using System;

namespace 第五课_break的用法和练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1到100之间所有整数的和
            //循环条件：i<=100
            //循环体：1+2+3+4+.....  //其实就是循环累加的过程
            int i = 1;
            int 总和 = 0;
            while (i <= 100)
            {
                总和 += i;
                i++;
            }
            Console.WriteLine("1到100之间的所有整数的和是{0}", 总和);


            //求1到100之间所有偶数的和
            //循环条件：i<=100
            //循环体：2+4+6+8.....  //其实就是循环累加的过程
            int i1 = 1;
            int sum = 0;
            while (i1 <= 100)
            {
                if (i1 % 2 == 0)     //奇数就是改一下bool表达式  就是改成 !=0  
                {
                    sum += i1;
                }
                i1++;
            }
            Console.WriteLine("1到100之间的所有偶数的和是{0}", sum);





            /*  break
             *  1.可以跳出switch case结构
             *  2.跳出当前while循环。
             *  
             *  break 一般不单独使用，而是跟着if判断一起使用，表示当满足某些条件的时候，就不在循环了。
            */

            int q = 1;
            int j = 1;
            while (q <= 10) 
            {
                while (j <= 10)
                {
                    Console.WriteLine("这是里面的循环");
                    j++;
                    break;//这个就是跳出当前while循环，如果没有这个break程序会限制性当前while循环，直到条件不能满足
                }
                Console.WriteLine("这是外面的循环");
                q++;
            }



            int z = 0;
            while(i<10)
            {
                Console.WriteLine("Hello,酷狗");
                break;  //这个break没有任何实际意义，因为本身他就执行1次。
                //break 一般不单独使用，而是跟着if判断一起使用，表示当满足某些条件的时候，就不在循环了。
            }

        }
    }
}
