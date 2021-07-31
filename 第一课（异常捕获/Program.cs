using System;

namespace 第一课_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常捕获
            //语法上没有错误，在程序运行中出现了某些错误，不能在正常的运行。



            //1.异常捕获，
            /* 我们在程序中经常会出现各种个样的异常，如果你想你的程序稳定一些，
                 在你的代码中应该经常出现try-catch来进行异常捕获

                 哪行代码有可能出现异常，你就踹他一脚（try-catch）

                 语法：
             try
             {
                 可能会出现的代码；
                    .................
                    ...... 
             }
             catch
             {
                 出现异常后要执行的代码；
             }

            //try和catch中间不能有其他代码


             执行过程，如果try中的代码，没有出现异常，那么catch中的代码不会执行，
                 如果try中的代码出现了异常，那么这行出现异常的代码后面还有100行都不会执行了
                 而是直接跳转到catch中执行代码


             */
            /*    Console.WriteLine("请输入一个数字");
                  try
                  {
                      int number = Convert.ToInt32(Console.ReadLine());
                  }
                  catch 
                  {
                      Console.WriteLine("输入的内容不能够转换为数字");
                  }
                  Console.WriteLine(number * 2);   //变量的作用域，也就是你能够适用的范围
                  Console.ReadKey();
            */
            //变量的作用域，也就是你能够适用的范围
            //变量的作用域一般从生命他的那个括号开始到那个括号所对应的结束的括号结束
            //在这个范围内，我们可以访问并使用变量


            bool b = true;
            int number = 0 ;  //声明变量
            Console.WriteLine("请输入一个数字");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());////变量赋值
            }
            catch
            {
                Console.WriteLine("输入的内容不能够转换为数字");
                b = false;
            }

            //我们如果要执行下列代码需要满足某些条件
            //1.让代码满足某些条件去执行的话，使用bool类型
            if(b)
            {
                Console.WriteLine(number * 2);   //使用
            }
                Console.ReadKey();
            
        }
    }
}