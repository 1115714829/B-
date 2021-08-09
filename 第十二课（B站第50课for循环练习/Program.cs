using System;

namespace 第十二课_B站第50课for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.for循环的正序输出和倒序输出

            //请打印1到10的数字
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //打印10到1的数字
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }



            /*问题1：求1-100间的虽有的偶数的和？
             *问题2：找出100-999间的水仙花数？
             *问题3：输出九九乘法表（循环的嵌套）
            */

            //问题1：求1 - 100间的虽有的偶数的和？
            Console.WriteLine("问题1：求1 - 100间的虽有的偶数的和？");
            int sum = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("所有偶数的和是{0}", sum);


            //问题2：找出100-999间的水仙花数？
            //水仙花数指的就是这个百位数字的百位的立方+十位的立方+个位的立方==当前这个百位数字
            //153   1的立方1   5的立方125    3的立方37       平方乘以2次  立方乘以3次
            //1+125+37=153
            Console.WriteLine("问题2：找出100-999间的水仙花数？");
            int sum1 = 0;
            int hun = 0;//百位数
            int ten = 0;//十位数
            int ind = 0;//个位数
            for (int i = 100; i <= 999; i++)
            {
                hun = i / 100; 
                ten = i % 100 / 10;
                ind = i % 10;
                if (hun * hun * hun + ten * ten * ten + ind * ind * ind == i) 
                {
                    Console.WriteLine("水仙花数有{0}",i);
                    sum1+=i;
                }
            }
            Console.WriteLine("水仙花数总和是{0}",sum1);
            //问题3：输出九九乘法表（循环的嵌套）


        }
    }
}
