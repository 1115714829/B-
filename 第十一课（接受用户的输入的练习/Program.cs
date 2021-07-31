using System;

namespace 第十一课_接受用户的输入的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.练习：请用户输入姓名性别年龄，当用户按下某个键子后在屏幕上显示：你好：XX您的年龄是XX是个X生
            Console.WriteLine("请输入你的姓名，");


            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的性别");
            string gender = Console.ReadLine();
            Console.WriteLine("{0}你好，你的年龄是{1}，是个{2}生。", name, age, gender);

        }
    }
}
