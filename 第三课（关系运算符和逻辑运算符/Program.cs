using System;

namespace 第三课_关系运算符和逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //关系运算符
            /*
             * <
             * >
             * >=
             * <=
             * ==
             * !=
             * 关系运算符是用来描述两个事物之间的关系
             * 有关系运算符连接的表达式，称为关系表达式
             */
            //大象的重量（1500）>老鼠的重量（1）

            //关系表达式的结果是bool类型
            bool b = 1500 > 1;
            Console.WriteLine(b);           //正确，返回的结果是ture
            Console.ReadKey();

            //兔子的寿命（3）>乌龟的寿命（1000）
            bool shouming = 3 > 1000;
            Console.WriteLine(shouming);    //错误，返回的是false
            Console.ReadKey();



            /*bool类型
             * 在C#中我们用bool类型来描述对或错。
             * bool类型的值只有两个  一个 ture  一个false。
             */

            //逻辑与算符
            /*
             * &&逻辑与
             * ||逻辑或
             * ！逻辑非
            有逻辑运算符连接的表达式叫做逻辑表达式
            逻辑运算符两边放的一般都是关系表达式，或者bool的值
            */



            /*复合赋值运算符
             * +=                 
             * -=
             * *=
             * /=
             * %*
             * 这是二元运算符
             */



            //练习1：让用户输入老苏的语文和数学成绩，输出以下判断是否正确，正确输出True，错误输入出false
            // 1.老苏的语文和数学成绩都大于90
            Console.WriteLine("请输入你的语文成绩");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩");
            int math = Convert.ToInt32(Console.ReadLine());
            bool b1 = chinese > 90 && math > 90;
            Console.WriteLine(b1);
            Console.ReadKey();


            // 2.语文或者数学有一门是大于90分的。
            bool b2 = chinese > 90 || math > 90;
            Console.WriteLine(b2);
            Console.ReadKey();





        }
    }
}
