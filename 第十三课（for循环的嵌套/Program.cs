using System;

namespace 第十三课_for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            ////当遇到某个事情要执行一遍，二另外一个事情要做N遍的时候
            ////应该马上想到用for循环嵌套
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine("Hello World!");
            //    }
            //}
            //问题3：输出九九乘法表（循环的嵌套）
            Console.WriteLine("问题3：输出九九乘法表（循环的嵌套）");
            for (int i = 1; i < 10; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write("{0}x{1}={2}\t", i, a, i * a);
                }
                Console.WriteLine();
            }
            //请输入一个值
            //根据这个值可以输出以下加法表


            Console.WriteLine("问题4：请输入一个数字，系统将为您提供这个数的加法表");

            //    for (int i1 = Convert.ToInt32(Console.ReadLine()); i1 < 10; i1++)
            //    {
            //        for (int b = 1; b < 10; b++)
            //        {
            //            Console.Write("{0}+{1}={2}\t", i1, b, i1 + b);
            //        }
            //    }
            //    Console.WriteLine();
            //

            int  number = 0;
            int z = 1;
            for (number = Convert.ToInt32(Console.ReadLine()); z == 1; z++)
                Console.WriteLine("{0}的加法表为：",number);
            {
                for (int b =1; b < 10; b++)
                {
                    Console.Write("{0}+{1}={2}\t",number, b, number + b);
                }
            }
        }
    }
}
