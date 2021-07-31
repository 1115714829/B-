using System;

namespace 第三课_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("第三课");

            //变量类型 起个变量名；
            //变量名 = 值
            //100
            //官方语言：生命或者定义了一个int类型的变量
         //   int number;//在内存中开辟了一块能够存储整数的空间
            //官方语言：给这个变量进行赋值
         //   number = 100;//表示吧100存储到了这个空间内
            //“等号”表示赋值的意思

            //int n = 100；


            int number = 700;
            int n = 700;
            double xiaoshuleixing = 2.51;//小数类型
            decimal monmey = 100m;
            string name = "张三";
            char Gender = '男';
            //其中  number  n  decimal monmey xiaoshuleixing monmey name gender 为变量名称

            //int 是整数的意思，不能有小数   数据范围为-2147483648~2147483647
            //double 是小数类型  既能存储整数，也可以存储小数
            //decimal 是金钱类型 ，后面需要加个m
            //srring 是字符串类型  可以存储多个字符，要用英文半角双引号
            //char 是字符类型  智能存储单个字符，用英文半角但引号存储


        }
    }
}
