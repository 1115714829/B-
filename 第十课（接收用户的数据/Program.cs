using System;

namespace 第十课_接收用户的数据
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            Console.WriteLine("请输入你的姓名");
            //我们还想要接受你输入的姓名
            //Console.ReadLine();           接受用户在控制台的输入

            string name = Console.ReadLine();   //等于用户输出的内容

            Console.WriteLine("你的姓名是{0}", name);
*/


            //1.练习：问用户喜欢吃什么水果（fruits），假如用户输入“苹果”，则显示：哈哈，这么巧，我也喜欢吃“苹果”
            Console.WriteLine("你喜欢吃什么水果？");
         //   Console.ReadLine();
            string fruits = Console.ReadLine();
            Console.WriteLine("哈哈，这么巧，我也喜欢吃{0}", fruits);



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
