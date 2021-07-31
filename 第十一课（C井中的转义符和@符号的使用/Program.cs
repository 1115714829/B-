using System;

namespace 第十一课_C井中的转义符和_符号的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //转义符指的是‘\’+  一个特殊的字符，组成了一个具有特殊意义的字符
            Console.WriteLine("今天天气好晴\n朗处处好风光");//       \n表示换行

            Console.WriteLine("我想在这句话中输出一个\"半角英文\"的双引号"); //     \" 表示一个英文半角的双引号


            string name1="关谷神奇";
            string name2="张伟";
            string name3="胡一菲";
            string name4="曾小贤";
            Console.WriteLine("{0}\t{1}",name1,name2);
            Console.WriteLine("{0}\t\t{1}", name3, name4);  //     \t表示一个tab键的空格
            Console.WriteLine("1+\b1\b+1等于2");   //    \b 表示删除键baskspace   \b 在字符串的两端 无效果


            /*
                  \r\n  Windows10之前的操作系统不识别\n 只能是\r\n才能换行
                  \\  表示一个\
            */
            /*
                @符号的作用
                  1.第一个作用， 取消\在字符串中转义的作用，（比如路径
                  2.第二个作用， 将字符串按照原本的格式输出
            */





            /* 转义符指的是‘\’+  一个特殊的字符，组成了一个具有特殊意义的字符
                     \n表示换行
                     \" 表示一个英文半角的双引号
                     \t表示一个tab键的空格
                     \b 表示删除键baskspace   \b 在字符串的两端 无效果
                     \r\n  Windows10之前的操作系统不识别\n 只能是\r\n才能换行
                     \\  表示一个\
            */



            string path = @"E:\OneDrive\图片\斗图";   //     取消\在字符串中转义的作用，（比如路径） 使其单纯的称为“右斜杠\”
            Console.WriteLine(path);
            Console.ReadKey();
            /*
                     @符号的作用
                       1.第一个作用， 取消\在字符串中转义的作用，（比如路径） 使其单纯的称为“右斜杠\”
                       2.第二个作用， 将字符串按照原本的格式输出
            */




            


        }
    }
}
