using System;

namespace 第五课练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：对学员的结业考试成绩测评
            /*    成绩>=90  :A
             * 90>成绩>=80  :B
             * 80>成绩>=70  :C
             * 70>成绩>=60  :D
             * 60>成绩>=50  :E
             */
            Console.WriteLine("请输入你的成绩");
            int 成绩 = Convert.ToInt32(Console.ReadLine());
            bool 评级A = 成绩 > 90 || 成绩 == 90;
            bool 评级B = 成绩 > 80 || 成绩 == 80;
            bool 评级C = 成绩 > 70 || 成绩 == 70;
            bool 评级D = 成绩 > 60 || 成绩 == 60;
            bool 评级E = 成绩 > 50 || 成绩 == 50;
#region  这是else的做法
            if (评级A == true)
            {
                Console.WriteLine("你好，你的测评成绩是A");
            }
            else
            {
                if (评级B == true)
                {
                    Console.WriteLine("你好，你的测评成绩是B");
                }
                else
                {
                    if (评级C == true)
                    {
                        Console.WriteLine("你好，你的测评成绩是C");
                    }
                    else
                    {
                        if (评级D == true)
                        {
                            Console.WriteLine("你好，你的测评成绩是D");
                        }
                        else
                        {
                            if (评级E == true)
                            {
                                Console.WriteLine("你好，你的测评成绩是E");
                            }
                        }
                    }

                }
            }
            #endregion



#region  下面是esle-if的做法
            if (评级A == true)
            {
                Console.WriteLine("a");
            }
            else if (评级B == true)
            {
                Console.WriteLine("B");
            }
            else if(评级C==true)
            {
                Console.WriteLine("c");
            }
            else if(评级D==true)
            {
                Console.WriteLine("d");
            }
            else if(评级E==true)
            {
                Console.WriteLine("e");
            }


            #endregion



            /* 1.比较3个数字的大小 不考虑相等
             * 2.提示用户输入密码，如果密码是“88888”则提示正确，否则要求在出入一次，
             *   如果是“88888”提示正确，否则错误，程序结束（如果我的密码里有英文还要转换吗？密码：abc1）
             * 3.提示用户输入用户名，然后提示输入密码，如果用户名是admin并且密码是888888，则提示正确，否则，如果用户名不是admin还是
             *   提示用户 “用户名不存在” 如果用户名是admin则提示密码错误。
             * 4.提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果用户小于10岁，则告知不允许查看，如果大于等于10岁
             *   并且小于18，则提示用户是否继续查看，（yes、no），如果输入的是yes 则提示用户请查看，否则提示，退出，你放弃查看
             */
# region 第一题
            //分别提升用户输入3个数字，我们接受并转换int类型
            Console.WriteLine("请输入第一个数字");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字") ;
            int number3 = Convert.ToInt32(Console.ReadLine());
            //三种情况 应该使用if else-if
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("最大的是{0}", number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("最大的是{0}",number2);
            }

            else if(number3>number2&&number3>number1)
            {
                Console.WriteLine("最大的是{0}", number3);
            }

            #endregion
#region   第二题 
            //提示用户输入密码，如果密码是“88888”则提示正确，否则要求在出入一次，
            //如果是“88888”提示正确，否则错误，程序结束（如果我的密码里有英文还要转换吗？密码：abc1）
            Console.WriteLine("请输入密码");
            string pass = Console.ReadLine();
            if (pass == "88888")
            {
                Console.WriteLine("输入正确");
            }
            else 
            {
                Console.WriteLine("输入错误，请重新输入");
                pass = Console.ReadLine();
                if (pass == "88888") 
                {
                    Console.WriteLine("密码正确");
                }
                else
                {
                    Console.WriteLine("密码错误，程序结束");
                }
            }

            #endregion
#region  第三题
            //提示用户输入用户名，然后提示输入密码，如果用户名是admin并且密码是888888，则提示正确，否则，如果用户名不是admin还是
            //提示用户 “用户名不存在” 如果用户名是admin则提示密码错误。
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            if (name == "admin" && pwd == "888888")//第一种情况
            {
                Console.WriteLine("登陆成功");
            }
            else if (name == "admin")
            {
                Console.WriteLine("密码输入错误，程序退出");
            }
            else if (pwd == "888888")
            {
                Console.WriteLine("用户名错误，程序退出");
            }
            else if (name != "admin" && pwd != "888888")
            {
                Console.WriteLine("用户名密码全部错误，程序退出");
            }
            #endregion
#region 第四题
            Console.WriteLine("请输入年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age < 10)
            {
                Console.WriteLine("未成年人不允许查看");
            }
            else 
            {
                Console.WriteLine("当前内容少儿不宜，是否继续查看？看的话输入yes，否则输入no");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("好的你可以继续查看，但请注意身体健康");
                }
                else 
                {
                    Console.WriteLine("很有自知之明，程序即将关闭");
                }
            }
            #endregion

        }
    }
}
