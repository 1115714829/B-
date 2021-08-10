using System;

namespace 第十五课_B站57课_for循环的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：循环录入5个人的年龄并计算平均年龄，如果输入的数据出现负数或大于100的数，立即停止输入并报错
            //练习2：在while中用break时限要求用户一直输入用户名和密码，只要不是admin、888888 就一直提示要求重新
            //       输入，如果正确则提示登陆成功
            //练习3: 1~100之间的整数相加，得到累加值大于20的当前数（比如1+2+3+4+5+6=21）结果6


            //练习1：循环录入5个人的年龄并计算平均年龄，如果输入的数据出现负数或大于100的数，立即停止输入并报错
            Console.WriteLine("练习1：循环录入5个人的年龄并计算平均年龄，如果输入的数据出现负数或大于100的数，立即停止输入并报错");
            Console.WriteLine("请输入年龄");
            //循环体：循环录入5人的年龄  输入的数据出现负数或大于100
            //循环条件：i < 5   
            int ci = 0;
            for (int i = 0; ci < 5; ci++)
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i < 0 || i > 100)//检查i是否出现负数或大于100
                {
                    Console.WriteLine("你输入的年龄不正确，程序退出");
                    break;
                }
                else
                {
                    Console.WriteLine("您输入的年龄为{0}", i);
                }
            }

            //练习2：在while中用break时限要求用户一直输入用户名和密码，只要不是admin、888888 就一直提示要求重新
            //       输入，如果正确则提示登陆成功.

            //循环条件：账号密码要输入正确，不正确就一直循环
            //循环体：一直输入账号密码，直到正确
            Console.WriteLine("练习2：在while中用break时限要求用户一直输入用户名和密码，只要不是admin、888888 就一直提示要求重新输入，如果正确则提示登陆成功");
            string usename = "";
            string passwd = "";
            do
            {
                Console.WriteLine("请输入用户名");
                usename = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passwd = Console.ReadLine();
                if (usename != "admin" || passwd != "888888")
                {
                    Console.WriteLine("账号或密码输入错误，请重新输入");

                }
                else
                {
                    Console.WriteLine("登陆成功");
                    break;
                }
            } while (usename != "admin" && passwd != "888888");
            Console.ReadKey();
            //练习3: 1~100之间的整数相加，得到累加值大于20的当前数（比如1+2+3+4+5+6=21）结果6

            Console.WriteLine("练习3: 1~100之间的整数相加，得到累加值大于20的当前数（比如1+2+3+4+5+6=21）结果6");
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum = i;
                
                if (sum > 20)
                {
                    
                    Console.WriteLine("大于20的当前数是{0}", i);
                }
                else
                {
                    sum += i;
                }
            }
        }



    }
}

