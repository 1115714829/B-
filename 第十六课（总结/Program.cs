using System;

namespace 第十六课_总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1： 编程实现计算几天（如46天）是几周零几天

            int days = 46;                                                      //共计天数
            int weeks = days / 7;                                                //一共几周因为是int所以取整数
            double day = days % 7;                                                //取余数
            Console.WriteLine("答：{0}天是{1}周零{2}天",days,weeks,day);
            Console.ReadKey();




            //练习2： 编程实现107653秒是几天几小时几分钟几秒？

            int Total_seconds = 107653;
            // 60秒*60分*24小时=86400秒   86400秒读作 1天0小时0分0秒
            int day1 = Total_seconds / 86400;      //这是天数
            int remainder = Total_seconds % 86400;  //这是天数之后的剩余的秒数
            // 60*60=3600秒     3600等于1小时读作1小时0分0秒
            int hour =remainder/3600;        //这是剩余的秒数之后算出来的小时数
            remainder = remainder % 3600;    //这是算出小时数之后的剩下的秒数 也就是余数  //remainder已成功重新赋值
            //  60秒是1分钟
            int minute = remainder / 60;       //这是算出来几分钟
            remainder = remainder % 60;    //这是分钟之后的剩余秒数
            int seconds = remainder;          //这是最后的剩余秒数

            Console.WriteLine("答：编程实现107653秒是{0}天{1}小时{2}分{3}秒.",day1,hour,minute,seconds);








            //练习3： 修改上面的题目，让用户输入.小时（Hour），分钟（Minute），秒（Seconds）


            



























            /*


            
             Console.WriteLine("请输入小时");
             string hour1 = Console.ReadLine();
            int hour11 = Convert.ToInt32(hour1)*24;




             Console.WriteLine("请输入分钟");
             string minute1 = Console.ReadLine();
             Console.WriteLine("请输入秒数");
             string seconds1 = Console.ReadLine();
             Console.WriteLine("请输入天数");
             string days1 = Console.ReadLine();
             Console.WriteLine("一共是{0}秒",);


             

            */



        }
    }
}
