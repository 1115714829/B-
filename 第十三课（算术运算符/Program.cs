using System;

namespace 第十三课_算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*算术运算符
               +
               -
               *
               /
               %
            */
            int n1 = 10;
            int n2 = 3;
            int result = n1 / n2;
            Console.WriteLine(result);
            Console.ReadKey();
            //两个int类型  进行加减乘除 获得的值还是int（int是整数）


            //演示：某学生三门课成绩为， 语文：90  数学：80  英语：67 要求：编程求总分和平均分
            int chinese = 90;
            int mathematics = 80;
            int english = 67;
            Console.WriteLine("总成绩是{0}，平均成绩是{1}", chinese + mathematics + english,(chinese + mathematics + english)/3);

            //  在C#中百分号是取
            //  因为int类型是整数，所以用 取（百分号）得出来的结果也应该是整数类型

            //练习1：  定义两个数分别为100和20，打印出两个数的和

            int number1 = 100;
            int number2 = 20;
            Console.WriteLine("答，两个数的和是{0}",number1 + number2);
            Console.ReadKey();

            // 练习2：计算半径为5的圆的面积和周长并打印出来。pai为3.14 面积（pi*r*r）penmeter（周长）


            //等号两边数据类型必须一样


            int r = 5;
            double area = 3.14*r*r;
            
            double penmeter =2*3.14*r;
            Console.WriteLine("答，面积为{0},周长为{1}",area,penmeter);
            Console.ReadKey();


            //练习3：某商店T恤（T-shirt）的价格为35元/件，裤子（trousers）的价格为120元/条，小明在该店买了3件T恤和两条裤子，
            //请计算并显示小明应该付多少钱呢？
            //打8.8折后呢？

            double T_shirt = 35;
            double trousers = 120;

            Console.WriteLine("答：小明应该付{0}元钱，打8.8折后付{1}元钱", T_shirt*3+trousers*2,(T_shirt*3 + trousers*2)*0.88);

            //老师是这样写的

            double T_shirt1 = 35;
            double trousers2 = 120;
            double totalmony = 3 * T_shirt1+2*trousers2;
            Console.WriteLine("答：小明应该付{0}元钱",totalmony);
            Console.ReadKey();
            //打8.8折后是
            Console.WriteLine("打8.8折后是{0}元", totalmony * 0.88);
            Console.ReadKey();




        }
    }
}
