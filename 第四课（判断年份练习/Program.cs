using System;

namespace 第四课_判断年份练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //请输入年份，在输入月份，输出该月的天数。（结合之如何判断闰年来做）
            Console.WriteLine("请输入年份");
            #region   这是我自己的做法
            try//判断年份是不是有异常字符
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                int month = 0;
                try//判断月份是不是有异常字符
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    bool b = (month >= 1) && (month <= 12);
                    if (b)//判断月份是不是1-12内
                    {
                        bool leap_year = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);//闰年

                        switch (month)
                        {
                            case 1:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 3:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 4:
                                Console.WriteLine("这个月有30天");
                                break;
                            case 5:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 6:
                                Console.WriteLine("这个月有30天");
                                break;
                            case 7:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 8:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 9:
                                Console.WriteLine("这个月有30天");
                                break;
                            case 10:
                                Console.WriteLine("这个月有31天");
                                break;
                            case 11:
                                Console.WriteLine("这个月有30天");
                                break;
                            case 12:
                                Console.WriteLine("这个月有31天");
                                break;
                            default:
                                if (leap_year)
                                {
                                    Console.WriteLine("这个月有29天");
                                }
                                else
                                {
                                    Console.WriteLine("这个月有28天");
                                }

                                break;
                        }
                    }
                    else//如果不是1-12月内则输出下面的内容
                    {
                        Console.WriteLine("对不起，你输入的月份有误，因为月份不能大于12月，程序即将退出");
                    }
                }
                catch//月份有异常字符 则输出下面的内容
                {

                    Console.WriteLine("对不起你输入的月份有误，因为月份不能有异常字符，程序退出");
                }
            }
            catch//如果年份有异常字符，则提示下列内容
            {
                Console.WriteLine("对不起，您输入的年份有误，程序退出");
            }
            Console.ReadKey();
            #endregion
            #region   这是老师的做法
            //请输入年份，在输入月份，输出该月的天数。（结合之如何判断闰年来做）
            Console.WriteLine("请输入年份");
            try
            {
                int year1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try//检查月份输入是否正确，是否有异常字符
                {
                    int month1 = Convert.ToInt32(Console.ReadLine());
                    int day = 0;//声明一个变量用来储存天数
                    bool b = (month1 >= 1) && (month1 <= 12);
                    if (b)//判断是否输入1-12之内的月份
                    {
                        switch (month1)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                //由于2月 平年闰年不同，所以首先要判断一下是不是闰年
                                if (year1 % 4 == 0 && year1 % 100 != 0 || year1 % 400 == 0)
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("这个月有{0}天", day);
                    }
                    else//判断1-12之外的月份，如果是，则输出以下内容
                    {
                        Console.WriteLine("你输入的月份是1-12之外的月份");
                    }
                }
                catch//跟月份的try有关，如果有异常字符  则输出以下内容
                {
                    Console.WriteLine("对不起，您输入的月份有异常字符，程序即将退出");
                }
            }
            catch//跟年份的try有关
            {
                Console.WriteLine("对不起，您输入的年份不正确，程序即将退出");
            }
            #endregion

        }
    }
}
