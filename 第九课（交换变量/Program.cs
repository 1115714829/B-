using System;

namespace 第九课_交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            /*
               int temp = n1;
               n1 = n2;
               n2 = temp;


               Console.WriteLine("交换后，n1的值是{0}，n2的值是{1}", n1, n2);
               Console.ReadKey();

            */
            //举例， 比如需要把一杯雪碧（n1）和一杯可乐可乐（n2）替换一下位置，正确的做法是，先拿一个新的空杯子（temp）
            //先把n1倒进temp，这个时候n1就空了，然后把n2倒进n1，最后再把temp倒入n2  
            //所以代码应该这样写

            /* int n1 = 10;
               int n2 = 20;

               int temp = n1;
               n1 = n2;
               n2 = temp;
            */

            //面试问题 ： 请交换两个int类型的变量，要求：不使用第三方变量

            n1 = n1 - n2;//这时候n1等于-10  n2等于20
            n2 = n1 + n2;//这时候n1等于-10  n2等于10
            n1 = n2 + n2;//这时候n1等于20   n2等于10
            Console.WriteLine("交换后，n1的值是{0}，n2的值是{1}", n1, n2);





        }
    }
}
