using System;

namespace 第二课_Switch_case课程
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定，如果设定为A级，则工资涨500元，如果定位B级，
            //则工资涨200元。如果定位C级，工资不变，如果定位D级，工资降200，如果定位E级
            //工资降500
            //设李四的原工资为5000，请输入李四的评级，然后显示李四来年的工资。


            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四的年终评定");//用户有5中情况  A  B  C  D  E  外加一种输入错误6种
            string level = Console.ReadLine();
            #region 用if的方法
            if (level == "A")
            {
                salary += 500;//salar=salar+500
            }
            else if (level == "B")
            {
                salary += 200;
            }
            else if (level == "C")
            {
                salary += 0;
            }
            else if (level == "D")
            {
                salary -= 0;//可以什么都不写
            }
            else if (level =="E")
            {
                salary -= 500;
            }
            else
            {
                Console.WriteLine("输入有误，程序退出");
                b = false;
            }
            if (b)
            {
                Console.WriteLine("李四来年的工资是{0}", salary);
            }
            Console.ReadKey();
            #endregion
            switch (level)
            {
                case "A":salary += 500;//值类型要和switch类型一样
                    break;
                case "B":salary += 200;
                    break;
                case "C":salary += 0;
                    break;
                case "D":salary -= 200;
                    break;
                case "E":salary -= 500;
                    break;
                default:Console.WriteLine("输入有误，程序退出");
                    b = false;
                    break;
            }
            if(b)
            {
                Console.WriteLine("李四明年的工资是{0}", salary);
            }
            Console.ReadKey();


            //if else if 用来处理多条件的  区间  的判断。
            //switch -case 用来处理多条件  定值  的判断。
            /*
            语法：
            switch (变量或者要表达的值)
            {
                    case 值1：要执行的代码;
                    break;
                    case 值2：要执行的代码;
                    break;
                    case 值3：要执行的代码;
                    break;
                    ...
            defaule: 要执行的代码;
                    break;
            }
            执行过程：程序执行到switch处，首先将括号中变量或者表达式的值算出来，然后拿着这个值依次
            跟每个case后面所带的值进行匹配，一旦匹配成功，则执行该case所带的代码，执行完成后，遇到break
            ，跳出switch-case结构
            如果跟每个case 所带的值都不匹配，就看当前这个switch-case结构中是否存在defaule，如果有default中的语句，如果没有
            default，则该switch-case结构什么都不做
            */

        }
    }
}
