﻿using System;

namespace 第十一课_for循环_语法
{
    class Program
    {
        static void Main(string[] args)
        {
            //想控制台打印10遍   欢迎来到传智播客学习
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("欢迎来到智传播客");
            //    i++;
            //}


            //for 循环
            /* 语法
             *  for（表达式1；表达式2；表达式3；）
             *  {
             *          
             *  }
             *  
             *  表达式1 一般为声明循环变量，记录循环的次数（int i = 0 ；）
             *  表达式2 一般为循环条件（i<10）
             *  表达式3 一般为能够改变循环条件的代码，使循环条件终有一天不再成立（i++）
             *  
             *  执行过程：
             *  程序首先执行表达式1，声明了一个循环变量，用来记录循环的次数
             *  然后执行表达式2 判断循环条件是否成立，如果表达式2返回的结果为true
             *  则执行循环体，当执行完循环体后执行表达式3，然后执行表达式2继续判断循环条件是否成立，
             *  如果成立则继续执行循环体，如果不成立在，则跳出for循环.
             *  
             */





            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("欢迎来到传智播客{0}", i);
            }
        }
    }
}
