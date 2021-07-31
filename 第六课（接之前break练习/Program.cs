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

            //1.打印100次，衣衣和我是一对，你群谁也别想抢走。
            //循环体：衣衣和我是一对，你群谁也别想抢走。
            //循环条件：打印10次<=10
            #region 练习1
            int 悦 = 0;
            while (悦 < 10)
            {
                悦++;
                Console.WriteLine("衣衣和我是一对，你群谁也别想抢走\t 第{0}次。", 悦);
            }
            #endregion
            #region 练习2
            //2.输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            Console.WriteLine("请输入班级人数");
            int renshu = Convert.ToInt32(Console.ReadLine());
            /*      string s = Console.ReadLine();
                  if (!int.TryParse(s, out int renshu))
                  {
                      Console.WriteLine("对不起，你输入的班级人数格式不正确，程序即将退出");
                  }
            */
            Console.WriteLine("班级人数输入完毕");
            int cishu = 0;
            int 总成绩 = 0;
            int chengji = 0;

            //循环体：输入学生成绩的过程，循环次数等于用户输入的班级人数
            //循环条件：次数=人数

            while (cishu < renshu)//这是在循环输入成绩  
            {
                Console.WriteLine("请输入你的成绩");
                {
                    chengji = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("成绩输入完毕，你输入的成绩是{0}", chengji);
                    总成绩 += chengji;
                    cishu++;
                    Console.WriteLine("全班平均成绩是{0}分.总成绩是{1}分。", 总成绩, 总成绩 / cishu);

                }

            }


            #endregion
            #region 练习3
            /*3.老师问学生，这道题你会做了吗？如果学生回答“会了(y)”，则可以放学，
             *如果学生不会做(n)，泽老师在讲一遍，再问学生是否会做了.....
             *直到学生会为会为止，才可以放学。
             *直到学生会或老师给他讲了10遍还不会，都要放学。
             */
            Console.WriteLine("你这道题会做了吗？,请输入yes或者no");
            string answer = Console.ReadLine();
            bool b = (answer == "yes" || answer == "no");
            int 循环次数 = 0;
            if (b) //判断是否输入的不是y
            {
                while (answer == y)
                {
                    Console.WriteLine("好吧，那我小泽老师再叫你一次。");
                    answer = Console.ReadLine();
                    Console.WriteLine("答：这道题我会了");
                    Console.WriteLine("好，那你放学回家吧.");
                }
            }
            else answer == y //如果输入的是n(因为最开始就考虑到输入除Y和N之外的字母了，所以这里没问题
            {
                Console.WriteLine("答：这道题我会了");
                Console.WriteLine("好，那你放学回家吧.");
            }    














                while (循环次数 == 10)//开始判断是否输入正确
                    {


                    



/*

                    if (answer == y)
                    {
                        Console.WriteLine("答：这道题我会了");
                        Console.WriteLine("好，那你放学回家吧.");
                    }
                    else
                    {
                        Console.WriteLine("好吧，那我小泽老师再叫你一次。");
                        //循环体：问学生是否会作10遍
                        //循环条件：no<10
                        // while (循环次数 < 10)
                        //{
                        Console.WriteLine("乌拉拉乌拉拉的小泽老师又讲了一遍，再次问你会了吗？");
                        answer = Console.ReadLine();
                        if (answer == y)
                        {
                            Console.WriteLine("答：这道题我会了");
                            Console.WriteLine("好，那你放学回家吧.");
                        }
                        else
                        {
                            while (循环次数 < 10)
                            {

                            }
                        }
                        #endregion

                    }
                }
            */
