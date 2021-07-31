using System;

namespace 第五课_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 顺序结构：程序从main函数进入，从上到下一行一行的执行，不会落下任何一行。
             * 分支结构： （if）   （if-else）
             * 选择结构： （if if-else-if） （swicth-case）
             * 循环结构：  while do-whi  for fourach
             * if语句 
             * 语法：
             * if（判断语句）
             * {
             *        要执行的代码；
             *  }
             */



            /*
             *  if-else语句
             *  语法：
             *  if（判断语句）
             *    {
             *  
             *    }
             *  else
             *      {
             *  
             *       }
             */

            /*还有if-else-if
             * 作用：用来处理多条件的区间性的判断。
             * 语法：
             * if（判断条件）
             * {
             *   要执行的代码
             * }
             * else if（判断条件）
             * {
             *   要执行的代码
             * }
             * 执行过程：程序首先判断第一个if所带的小括号中的判断条件，如果条件成立，也就是返回一个true
             * 则执行该if所带的大括号中的代码，执行完成后，立即跳出if else-if结构
             * 如果第一个if所带的判断条件不成立，也就是返回一个fasle，则继续向下进行判断，依次的判断每一个if所带的判断条件
             * 如果成立，就执行该if所带的大括号中的代码，如故不成立，则继续向下判断，如果每个if所带的判断条件都不成立，就看当前
             * 这个if else-if结构中是否存在else
             * 如果有else，则执行else中所带的代码，如果没有else则整个if else-if什么都不做。
             */



            /*
             *判断条件：一般为关系表达式，或者bool类型的值，
             *执行过程：程序运行到if处，首先判断if所带的小括号中的判断条件，
             *如果条件成立，也就是返回ture，则执行if所带的大括号中的代码
             *如果判断条件不成立，也就是返回false，则跳过if节后，向下继续执行
             *if结构的特点：先判断，再执行，有可能一行代码都不执行
             *大括号不需要分号
             */


            //如果说你跪键盘的时间大于60分钟，那么媳妇奖励我不用做晚饭了
            Console.WriteLine("请输入你跪键盘的时间");
            int 跪下的时间 = Convert.ToInt32(Console.ReadLine());
            //如果跪键盘的时间大于60分钟则不做晚饭
            bool b = 跪下的时间 > 60;
            //如果你想表示的含义是当B的值为true的时候去执行if中的代码，那么语法上==true可以省略
            //但是当你想表示的含义是当B的值为false的时候去执行if中的代码，那么语法上必须要有==false
            if (b==true)//可以写成if (b)

            {
                Console.WriteLine("好老公不用跪键盘了,去恰饭吧");
            }

            else
            { 
                Console.WriteLine("傻逼玩意儿，继续跪着吧，吃鸡毛饭！你也配吃饭？");

            }



            //练习2
            /* 让用户输入年龄，如果输入的年龄大于23（含）岁，则给用户显示你到了结婚的年龄了。
             * 如果老苏的（chinese music）
             * ·语文成绩大于90分 并且音乐成绩大于80
             * ·语文成绩等于100并且音乐成绩大于70，则奖励100元。
             * ·让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登录成功。
             */

            Console.WriteLine("请输入你的年龄{0}",Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());
            bool yeas = age>23||age==23;

            if (yeas==true) 
            {
                Console.WriteLine("你到了该结婚的时候啦");
            }
            else
            {
                Console.WriteLine("你还不能结婚");
            }

            //语文成绩大于90分 并且音乐成绩大于80  或者 语文成绩等于100并且音乐成绩大于70，则奖励100元。
            Console.WriteLine("请输入你的语文成绩", Console.ReadLine());//输入用户成绩并且打印
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的音乐成绩", Console.ReadLine());//输入用户成绩并且打印
            int music = Convert.ToInt32(Console.ReadLine());//转换为int类型
            bool reward = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);
            if (reward == true) 
            {
                Console.WriteLine("恭喜你获得了100元");
            }
            else
            {
                Console.WriteLine("不好意思，你毛都没有，喝西北风去吧");
            }


            //让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登录成功。
            Console.WriteLine("请输入用户名", Console.ReadLine());//输入用户名并且打印
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码", Console.ReadLine());//输入密码并打印
            string passwd = Console.ReadLine();

            bool passport = username == "admin" && passwd == "mypass";
            if (passport == true) 
            {
                Console.WriteLine("恭喜你登录成功");
            }
            else
            {
                Console.WriteLine("对不起，你输入的账号或密码有误，登陆失败");
            }


            //练习三：对学员的结业考试成绩测评 
            /*    成绩>=90  :A
             * 90>成绩>=80  :B
             * 80>成绩>=70  :C
             * 70>成绩>=60  :D
             * 60>成绩>=50  :E
             */
            Console.WriteLine(("请输入你的成绩"),Console.ReadLine());
            int 成绩 = Convert.ToInt32(Console.ReadLine());
            bool 评级A = 成绩 > 90 && 成绩 == 90;
            bool 评级B = 成绩 > 80 && 成绩 == 80;
            bool 评级C = 成绩 > 70 && 成绩 == 70;
            bool 评级D = 成绩 > 60 && 成绩 == 60;
            bool 评级E = 成绩 > 50 && 成绩 == 50;
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
            
            





        }
    }
}
