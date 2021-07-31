using System;

namespace 第五课_变量的命名规范
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*	1. 必须以“字母” _或@符号开头。    不要以数字开头  现阶段给变量起名字先用字母开头
	        2. 后面可以跟任意“字母” “数字” “下划线”
	           注意：1.你起的变量名不要与C#系统中的关键字重复
	                 2.在C#中，大小写是敏感的
            3.同一个变量名不允许重复定义（先这么想，不严谨）
            4.变量中除了艾特下划线不能有任何其他字符
            5.变量名字首先要保证有意义，方便别人看懂
        */
        int number_1 = 10;
        int number_2 = 100;
        /*给变量起名字的时候要满足两个命名规范：
         1.Camel 骆驼命名规范。要求变量首单词的首字母要小写，其余每个字母的首字母要大写
                highSchool   high  School
         Camel 多用于给变量命名
         2.Pascal 命名规范：要求每个单词的首字母都要大写，其余字母全部小写，多用于给类或者方法命名
                HighSchool   High  School
        */
    }
}
