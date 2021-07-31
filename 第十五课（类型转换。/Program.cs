using System;

namespace 第十五课_类型转换_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            double d = n1 / n2;
            Console.WriteLine(d);
            Console.ReadKey();
            //结果是3，因为右边的n1和n2是int类型，所以尽管他们相除，但是依然得到的整数，所以左面的double也会等于3，先出结果才会赋值给double


            //如果其中一个操作数提升为double类型，则整个表达式都为double类型

            int u1 = 10;
            int u2 = 3;
            double z = u1*1.0 / u2;
            Console.WriteLine(z);
            Console.ReadKey();
            //将一个整数类型最快速的变成double类型可以在后面乘以一个1.0


            int a1 = 10;
            int a2 = 3;
            double e= a1 * 1.0 / a2;
            Console.WriteLine("{0:0.00}",e);  //保留几位小数，需要在后面加个0 例如：0.00就是保留两位小数
            Console.ReadKey();

        }
    }
}
