using System;

namespace 第二个项目_运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.类型相兼容的两个变量 ，可以使用自动类型转换，或者强制类型转换，但是如果两个变量不兼容
             * 比如 string类型与int类型  或者string类型与 double类型，
             * 如果两个类型变量不兼容，这个时候我们可以使用一个叫做convert的转换工厂进行转换
             * 注意：使用convert进行类型转换，也是需要一个满足条件：
             * /////需要转的的字符串不能有英文，因为假设你如果转换到int或者double类型，这两个类型是不能有字母的，这是数字类型
             * 例如下列距离就是错误的
             * 
             * 
             * string s= "123abc";              ///这里是123abc
             * double d = Convert.ToDouble(s);   ///这里就不能正常转换，因为double是不能包含字母的
             * Console.WriteLine(d);
             * Console.ReadKey();
             * 
             * 
             */
            string s = "123";
            //将字符串类型转换成int类型或者double类型
            double d = Convert.ToDouble(s);  //to是转换 double是double类型，大白话的to翻译成  把  把这个类型转换成double类型的意思
            Console.WriteLine(d);
            Console.ReadKey();

            int b = Convert.ToInt32(s);
            Console.WriteLine(b);
            Console.ReadKey();



            /*截止到目前，学习了三种类型转换
             * 显式类型转换
             * 隐式类型转换
             * convert类型转换
              
            */


            //练习： 让用户输入姓名，语文，数学，英语 三门课的成绩，然后给用户显示：XX,你的总成绩为XX分，平均成绩为XX分。

            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string chinese = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string english = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string mathematics = Console.ReadLine();

            int chinese1 = Convert.ToInt32(chinese);
            int english1 = Convert.ToInt32(english);
            int mathematics1 = Convert.ToInt32(mathematics);

            Console.WriteLine("你好，你的姓名是{0}，你的语文成绩为{1}，你的英语成绩为{2}，你的数学成绩为{3}，你的总成绩是{4}，平均成绩为{5}分。",name,chinese,english,mathematics,(chinese1 + english1 + mathematics1),(chinese1+english1+mathematics1)/3);
            Console.ReadKey();






        }
    }
}
