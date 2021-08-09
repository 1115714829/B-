using System;

namespace 第十四课__B站第56课_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用convert进行类型转换，可以转换的就直接转换了，不能转换的直接报异常
            int n = Convert.ToInt32("123abc");  //这句必报异常。
            //int.Parse;//和convert转换 实际效果一样，convert实际上是在内部调用的int.Parse
            int b = int.Parse("123abc");


            //   int.TryPrase  
            int number = 100;
            //参数 返回值   //老赵饿了 派个学生去帮他买份煎饼 方法就是学员 参数是买煎饼 是否买回来是返回值 
            bool b1 = int.TryParse("123", out number);
            Console.WriteLine(b1);
            Console.WriteLine(number);
            //方法 或者 函数 
        }
    }
}
