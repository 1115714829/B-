using System;

namespace 第三课_switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名，然后显示出这个人上辈子是什么职业。
            //（老杨，老苏，老邹，老马，老虎，老牛，老蒋，小杨，衣衣）
            //可以随意邪恶任何人，此时不邪恶更待何时？
            Console.WriteLine("请输入一个姓名,我们将显示出来，这个人上辈子是什么职业");
            string name = Console.ReadLine();
            //老杨，老苏
            switch (name)
            {
                case "老杨":Console.WriteLine("上辈子是抽大烟的");
                    break;
                case "老苏":Console.WriteLine("上辈子是卖水的");
                    break;
                case "老马":Console.WriteLine("上辈子是站街的");
                    break;
                case "衣衣":Console.WriteLine("上辈子是拉皮条的");
                    break;
                default:Console.WriteLine("没有这个人，或许上辈子是吃翔的吧");
                    break;
            }
            //if-else if和switch的比较
            /*
             * 1.相同点：都可以实现多分支结构  简单理解就是都可以做多条件的判断
             * 2.不同点：
             *   ·if-else if ：可以处理范围
             *   ·switch：一般 只能用于等值比较
             * 3.三者的区别：
             * 
           
            */
            //练习：对学员的结业考试成绩测评 
            /*    成绩>=90  :A
             * 90>成绩>=80  :B
             * 80>成绩>=70  :C
             * 70>成绩>=60  :D
             * 60>成绩>=50  :E
             */
            Console.WriteLine("请输入你的成绩");
           int score = Convert.ToInt32(Console.ReadLine());//有0到100这101种可能
           switch (score/10)//最终要把范围变成一个定值  
           {
                case 10://10和9的后面代码是一样的，所以可以省略
                    break;
                case 9:Console.WriteLine("A");
                    break;
                case 8:Console.WriteLine("B");
                    break;
                case 7:Console.WriteLine("C");
                    break;
                case 6:Console.WriteLine("D");
                    break;
                default:Console.WriteLine("E");
                    break;
           }
           //case 后面的代码完全一抹一眼的话  就可以删除掉后面的内容


        }
    }
}
