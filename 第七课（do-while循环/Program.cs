using System;

namespace 第七课_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //while循环特点 特点：先判断，在执行，有可能一边循环都不执行。
            //do-while循环
            /*  do-while语法
             *  do
             *  {
             *      循环体
             *  }while（循环条件）；
             *  执行过程：
             *  程序首先会执行do中的循环体，执行完成后去判断do-while循环的条件
             *  如果成立则继续执行do中的循环体，如果不成立，则跳出do-while循环
             *  特点：
             *  先循环，在判断，最少执行1遍循环体。
             *  
             */
            //提示输入用户名和密码，要求用户名等于admin密码等于888888
            //只要用户名错误或者密码错误就重新输入
            //但是最多只能输入3次
            int cishu1 = 0;
            string username = "";
            string passwd = "";
            do
            {
                Console.WriteLine("请输入用户名");
                username = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passwd = Console.ReadLine();
                cishu1++;
                if (username != "admin" || passwd != "888888")
                {
                    Console.WriteLine("密码输入错误");
                }
            } while (username != "admin" || passwd != "888888" && cishu1 < 3);
            if (cishu1 == 3)
            {
                Console.WriteLine("广咁多做咩啊，输入3次都能输入错？这都不会？回家呛条焦啦.");
            }
            if (username == "admin" && passwd == "888888")
            {
                Console.WriteLine("登陆成功");
            }


            /*练习
             * 1.不断要求用户输入学生姓名,输入q结束.
             * 2.不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出.
             * 3.不断要求用户输入一个数字〈假定用户输入的都是正整数>，当用户输入end的时候显示刚才输入的数字中的最大值
             */
            //不断要求用户输入学生姓名,输入q结束.


            //1.不断要求用户输入学生姓名,输入q结束.
            Console.WriteLine("请输入姓名,按Q结束程序");
            int number = 0;
            string jieshu = "";
            do
            {
                string name = Console.ReadLine();
                if (name == "q")
                {
                    Console.WriteLine("程序结束");
                    break;
                }
                else
                {
                    Console.WriteLine("请输入姓名,按Q结束程序");
                }
                number++;
            } while (number > 0);

            //2.不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出.
            //循环体：提示用户输入一个数字，接受 转换打印2倍
            //循环条件：输入的不能是Q
            Console.WriteLine("请输入任意纯数字，我们将打印这个数字的二倍");
            string num = "";
            int ci = 0;
            do
            {
                num = Console.ReadLine();
                ci++;
                if (num == "q")
                {
                    Console.WriteLine("您输入的是q，程序结束");
                    break;
                }
                else
                {
                    double jieguo = Convert.ToDouble(num) * 2;
                    Console.WriteLine("{0}这个数字的二倍是{1}", num, jieguo);
                }
            } while (ci > 0);

            //3.不断要求用户输入一个数字〈假定用户输入的都是正整数>，当用户输入end的时候显示刚才输入的数字中的最大值
            string shuzi = "";
            int cishu = 0;
            int max = 0;
            Console.WriteLine("请输入一个数字");
            do
            {
                shuzi = Console.ReadLine();
                cishu++;
                if (shuzi == "end")
                {
                    break;

                }
                int tmp = Convert.ToInt32(shuzi);
                if (max < tmp)
                {
                    max = tmp;
                }
            } while (shuzi != "end");
            Console.WriteLine("刚才输入的最大值是{0}", max);
        }
    }
}
