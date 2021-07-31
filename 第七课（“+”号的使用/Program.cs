using System;

namespace 第七课____号的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "温振华";
            Console.WriteLine("你好" + name+"5");
            Console.ReadKey();
            /*在C#当中+号有两个作用
                +号的作用
                1.连接  当+号两边是字符串的时候，加号就起到连接的作用
                2.相加  当两面没有字符串（是数字）的时候是相加的意思
            */
            Console.WriteLine(5 + 5);//这是相加（括号内没有字符串）
            Console.ReadKey();
            Console.WriteLine(5 + "5");//这是连接（括号内有字符串）
            Console.ReadKey();

        }
    }
}
