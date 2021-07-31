using System;

namespace 第四课__变量的使用规则
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //声明或者定义了整数类型的变量
            number = 200;
            Console.WriteLine(number);  //打印输出，使用这个变量
            Console.ReadKey();
            /*	
             1. 给变量赋值之前必须要定义或声明变量
             2.波浪线：如果代码中出现红色波浪线，意味着出现了语法错误
             3.如果代码中出现绿色的波浪线，说明代码语法并没有错误，只不过可能会出现错误，但是不一定出现错误，称为警告线
             4.如果使用变量的话必须要先声明在赋值
            */
        }
    }
}
