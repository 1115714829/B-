using System;

namespace 第二课_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //提示用户输入一个数字，并且接受向控制台打印用户输入的这个数字的二倍
            Console.WriteLine("请输入一个数字");
                                            //        string strnumber = Console.ReadLine();  这个注释的原因是这几句话是可以简写的
            //将用户输入的字符串转换成int或者double的类型
            //因为字符串和int和double是不兼容的类型所以需要用到convert类型转换
            double number = Convert.ToDouble(Console.ReadLine());   // 这里的Console.ReadLine();  如果是不简写  就要单独定义一个string类型的输入
            Console.WriteLine(number*2);
            Console.ReadKey();


            Console.WriteLine("这是一个分割线————————————————————————————————");
            Console.ReadKey();

            /*算术运算符和复杂运算符
             * 加加减减
             * ++分为前++  和  后++  不管是前++还是后++ 最终的结果都是给这个变量+1
             * --  减减同上
             * 在表达式当中 
                       例如：int result = 10 + number++；  是后++；  则先拿原值参与运算，运算完成之后再给这个变量自身+1  
                             int result = 10 + ++number；  是前++；  那么运算的时候加的是先给这个变量自身+1，然后带着这个加一后的值再参与运算运算。  
            
             * --  减减同上
             * 
            */

            int num = 10;
            //num++;
            ++num;   //不管在前还是在后++  都可以，另外这个就相当于  number = number+1；
            Console.WriteLine(num);
            Console.ReadKey();

            --num;   //和上面++同理 这是减去1的意思
            Console.WriteLine(num);
            Console.ReadKey();

            Console.WriteLine("这是一个分割线————————————————————————————————");
            Console.ReadKey();


            /*
            int number1 = 50;
            int result = 10 + number1++;
            Console.WriteLine(number1);
            Console.WriteLine(result);
            Console.ReadKey();
            
            */
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();



            //对于 只需要++或者--的这样只需要一个操作数就能完成的运算，我们称之为一元运算符
            /*   
             *   + - * / %  对于这些需要两个或者两个以上才能完成的运算的操作符，我们称之为二元运算符
             *   一元运算符的优先级药高于二元运算符  
             *   如果在一个表达式中 既有一元运算符 也有 二元运算符的 我们首先计算一元运算符
             *   例如
             *
                    int number = 10;
                    int result = 10 + ++number;

             *   这样的表达式  中 我们需要先算一元运算符 ++number；
             */   





        }
    }
}
