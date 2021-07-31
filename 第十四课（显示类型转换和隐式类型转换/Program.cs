using System;

namespace 第十四课_显示类型转换和隐式类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //上一课练习题
            //练习3：某商店T恤（T-shirt）的价格为35元/件，裤子（trousers）的价格为120元/条，小明在该店买了3件T恤和两条裤子，
            //请计算并显示小明应该付多少钱呢？
            //打8.8折后呢？

            double T_shirt = 35;
            double trousers = 120;

            Console.WriteLine("答：小明应该付{0}元钱，打8.8折后付{1}元钱", T_shirt * 3 + trousers * 2, (T_shirt * 3 + trousers * 2) * 0.88);

            //老师是这样写的

            int T_shirt1 = 35;
            int trousers2 = 120;
            int totalmony = 3 * T_shirt1 + 2 * trousers2;
            Console.WriteLine("答：小明应该付{0}元钱", totalmony);
            Console.ReadKey();
            //打8.8折后是
            double realmoney = totalmony * 0.88;       //我们要求等号两边参与运算的操作数的类型必须一致，如果不一致，满足下列条件会发生自动类型转换

            Console.WriteLine("打8.8折后是{0}元", realmoney);
            Console.ReadKey();

            //一.隐式类型转换
            //等号两边数据类型必须一致
            //我们要求等号两边参与运算的操作数的类型必须一致，如果不一致，满足下列条件会发生自动类型转换
            //或者称为 隐式类型转换
            // 1.两种类型兼容           例如int 和 double 兼容 （都是数字类型）
            // 2.目标类型大于源类型     例如：double > int  （土话就是，小的转大的）

            /*
            int number = 10;
            double d = number;  //隐式类型转换
            这两句就是隐式类型，把int类型转换成了double类型。

            */
            //二.显式类型转换
            //1.两种类型相兼容   int--double
            //2.大的转成小的  double--int



            //语法：
            //（待转换的类型）要转换的值；


            double d = 303.6;
            //double-----int//强制类型转换， 显式类型转换
            int n = (int)d;
            Console.WriteLine("强制转换完成，把double转换成了int类型，值是{0}", n);
            Console.ReadKey();
            

            /*总结：
             * 1.自主类型转换 ： int---->double
             * 2.显式类型转换 ： double----int
            */





        }
    }
}
