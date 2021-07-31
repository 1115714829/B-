using System;

namespace 第七课_练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //有个叫温振华的人在旅店登记的时候前台让他去填一张表
            //这张表里的内容要存到电脑上
            //有姓名，年龄，邮箱，家庭住址，工资
            //之后把他这些信息显示出来
            
            //第一题
            int age = 27;
            string name ="温振华";
            string address = "河北省张家口市涿鹿县大河南";
            string email = "1115714829@qq.com";
            decimal wages = 7000m;

            Console.WriteLine("我叫"+name +"，我住在"+ address +"村。"+"我今年"+ age +"岁了，"+"我的邮箱是"+email+"，我的工资是" + wages+"元");


            Console.ReadKey();
           //
            //第二题
            int age2 = 18;//(Age2是因为两道题，在一个项目里无法有两个相同的变量名，所以加了一个2)
            age2 = 81;
            Console.WriteLine(age2);


            
            
        }
    }
}
