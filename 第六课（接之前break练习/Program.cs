using System;

namespace 第六课_接之前break练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 练习：
             * 1.打印100次，衣衣和我是一对，你群谁也别想抢走。
             * 2.输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
             * 3.老师问学生，这道题你会做了吗？如果学生回答“会了(y)”，则可以放学，
             *   如果学生不会做(n)，泽老师在讲一遍，再问学生是否会做了.....
             *   直到学生会为会为止，才可以放学。
             *   直到学生会或老师给他讲了10遍还不会，都要放学。
             * 4.2006年培养学员80000人，每年增长25%，请问按此正常速度，到哪一年培训学员人数
             *   将达到200000人？
             */
            //#region 练习1
            ////1.打印100次，衣衣和我是一对，你群谁也别想抢走。
            ////循环体：衣衣和我是一对，你群谁也别想抢走。
            ////循环条件：打印10次<=10
            //int 悦 = 0;
            //while (悦 < 10)
            //{
            //    悦++;
            //    Console.WriteLine("衣衣和我是一对，你群谁也别想抢走\t 第{0}次。", 悦);
            //}
            //#endregion
            //#region 练习2
            ////2.输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //Console.WriteLine("请输入班级人数");
            //int renshu = Convert.ToInt32(Console.ReadLine());
            ///*      string s = Console.ReadLine();
            //      if (!int.TryParse(s, out int renshu))
            //      {
            //          Console.WriteLine("对不起，你输入的班级人数格式不正确，程序即将退出");
            //      }
            //*/
            //Console.WriteLine("班级人数输入完毕");
            //int cishu = 0;
            //int 总成绩 = 0;
            //int chengji = 0;

            ////循环体：输入学生成绩的过程，循环次数等于用户输入的班级人数
            ////循环条件：次数=人数

            //while (cishu < renshu)//这是在循环输入成绩  
            //{
            //    Console.WriteLine("请输入你的成绩");
            //    {
            //        chengji = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("成绩输入完毕，你输入的成绩是{0}", chengji);
            //        总成绩 += chengji;
            //        cishu++;
            //        Console.WriteLine("全班平均成绩是{0}分.总成绩是{1}分。", 总成绩, 总成绩 / cishu);
            //    }

            //}

            //#endregion
            //#region 练习3
            ///*
            // * 3.老师问学生，这道题你会做了吗？如果学生回答“会了(y)”，则可以放学，
            // *如果学生不会做(n)，泽老师在讲一遍，再问学生是否会做了.....
            // *直到学生会为会为止，才可以放学。
            // *直到学生会或老师给他讲了10遍还不会，都要放学。
            // */
            //Console.WriteLine("首次询问\t你这道题会做了吗？,请输入yes或者no");
            //string answer = Console.ReadLine(); //假设排除其它字符串，只能输入yes或者no(*^_^*)其实你还没学会怎么处理这个
            //// bool yes = true;//这是回答yes时候返回的结果
            //// bool no = true;//这是回答no时候返回的结果
            //int 循环次数 = 0;//这是循环条件
            //switch (answer)//判断答案是否正确
            //{
            //    case "no"://
            //        while (循环次数 < 10)//这是循环体
            //        {
            //            Console.WriteLine("答：我还不会/(ㄒoㄒ)/~~");
            //            Console.WriteLine("小泽老师：那我再教你一次吧");
            //            Console.WriteLine("第你这道题会做了吗？,请输入yes或者no");
            //            answer = Console.ReadLine();
            //            if (answer == "no")//这里是检查用户输入的是否是no  如果不是no则进入下面的else。
            //            {
            //                循环次数++;//这里满足10次以后  循环次数本身就是10了 已经无法达到while循环体的要求了。
            //                if (循环次数 == 10)//因为循环达到10次就要回家了，所以无论什么情况都要退出程序。
            //                {
            //                    Console.WriteLine("教你10次都不会，你基本废了，回家吃饭吧，明天再学，呜呼哀哉！");
            //                    break;//这里的break是循环10次后还是不会，所以直接跳出while循环。
            //                }
            //            }
            //            else//用户输入yes 程序 进入else 程序执行输出，然后在执行break跳出当前循环。
            //            {
            //                Console.WriteLine("答：老师 我会了。");
            //                Console.WriteLine("小泽老师：好哒！那你放学回家吧");
            //                break;//这是跳出while循环
            //            }
            //        }
            //        break;//跳出第一个switch-case循环。

            //    case "yes"://如果是第一次直接输入yes直接运行这句话，
            //        Console.WriteLine("答：老师 我会了。");
            //        Console.WriteLine("小泽老师：好哒！真聪明。那你放学回家吧");
            //        break;
            //}
            //#endregion
            //#region 练习4
            ////  2006年培养学员80000人，每年增长25 %，请问按此正常速度，到哪一年培训学员人数
            ////  将达到200000人？
            //double number = 80000;//初始人数
            ////循环体：每年增长25%
            ////循环条件:大于等于200000万
            //double total_number = 200000;//这是总人数 
            //int year = 2006;//初始年份
            //while (number < total_number)
            //{
            //    number *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("在第{0}年的时候人数达到20万", year);
            //#endregion*/
            //#region 练习5
            ////提示用户输入yes或者y
            ////要求：只能输入yes或者y，只要不是这两个就一直要求用户输入
            //string s = Console.ReadLine();
            //while (s != "yes" && s != "y")
            //{
            //    Console.WriteLine("输入有误，请重新输入");
            //}
            //#endregion
            #region 练习6
            //提示输入用户名和密码，要求用户名等于admin密码等于888888
            //只要用户名错误或者密码错误就重新输入
            //但是最多只能输入3次
            int cishu1 = 0;
            string username = "";
            string passwd = "";
            while (username != "admin" && username != "888888" && cishu1 < 3)
            {
                Console.WriteLine("请输入用户名");
                username = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passwd = Console.ReadLine();
                cishu1++;
                if (cishu1 == 3)
                {
                    Console.WriteLine("广咁多做咩啊，输入3次都能输入错？这都不会？回家呛条焦啦");
                }
            }
            

            #endregion
        }
    }


}