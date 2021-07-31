using System;

namespace 第四课_闰年判断
{
    class Program
    {
        static void Main(string[] args)
        {
            //闰年判断
            //写下判断闰年的表达式，设代判断的年份变量为year
            //闰年的判断（符合下面两个条件之一）：
            Console.WriteLine(" 请输入你要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //1.年份能够被400整除.(2000)
            //2.年份能够被4整除，但不能被100整除.（2008）

            bool b = (year % 400 == 0) || ( year%4 == 0 && year % 100 !=0);
            Console.WriteLine(b);
            Console.ReadKey();

            //在一个表达式中，逻辑与的优先级要高于逻辑或。
        }
    }
}
