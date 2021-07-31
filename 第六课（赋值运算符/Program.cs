using System;

namespace 第六课_赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 50;
            
            n = 100;//给变量重新赋值，一旦给一个变量重新赋值，老值就不存在了。取而代之就是新值
            
            
            /*如果这样写
            
            int n =100;  就错了，因为这等于给变量重复定义*/



            Console.WriteLine(n);
        }


    }
}
