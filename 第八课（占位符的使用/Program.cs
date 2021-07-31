using System;

namespace 第八课_占位符的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            /*占位符
                使用方法:先挖个坑，再填个坑。
            */
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine("第一个数字是{1}，第二个数字是{0}，第三个数字是{2}",n1,n2,n3);
            Console.ReadKey();


            /*使用占位符需要注意的地方
             
             1.你挖了几个坑，需要填几个坑，如果多填了，无效果 。
                                           如果少填了，程序抛异常。
             2.输出顺序
                占位符按照挖坑的顺序输出，
            */
            Console.WriteLine("第一个数字是：" + n1 + "，第二个数字是：" + n2 + "，第三个数字是："+ n3 + "。");
            Console.WriteLine($"第一个数字是：{n1}，第二个数字是：{n2}第三个数字是：{n3}。");
            Console.WriteLine("第一个数字是：{0}，第二个数字是：{1}第三个数字是：{2}。",n1,n2,n3);
            Console.ReadKey();


            /*异常是指:语法上没有任何错误，只不过是在程序运行的期间，由于某些原因出现了问题，使程序不能运行。*/



            //课堂练习


            string name = "温振华";
            string Gender = "男";
            string TelephoNenumber = "0313-6700221";
            int age = 27;

            Console.WriteLine("我叫{0},我今年{1},我是{2}生,我的电话号码是{3}" ,name,age,Gender,TelephoNenumber);




            string name1 ="温振华来来来";
            string address = "北京市朝阳区";
            Console.WriteLine("我叫{0}; 我家住在{1}",name1,address);



            string company = "北京君之聪明有限公司";
            string position = "研发中心";
            Console.WriteLine("我最新的工作的公司是{0}，我所在的部门是{1}.", company, position);


        }
    }
}
