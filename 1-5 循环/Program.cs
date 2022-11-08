using System;

namespace _1_5_循环
{
    // 回车键返回抽卡,end退出抽卡
    class Program
    {
        static void Main(string[] args)
        {
            // 1打印到10
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}

            // 随机数发生器（工具不能放在循环里面，要不然每次创建一个随机数就要重新创建一个工具，最后的数据就不随机，违背了随机数发生器创建的初衷）
            Random random = new Random();
            //bool flag = true;

            // 循环抽卡
            //while (true)
            //{
            //    int r = random.Next(0, 100);        // r的范围是0-99的闭区间

            //    string name = " ";

            //    if (r < 10)
            //    { name = "关羽"; }

            //    else if (r < 30)
            //    { name = "赵云"; }

            //    else if (r < 60)
            //    { name = "张飞"; }

            //    else
            //    { name = "黄忠"; }

            //    Console.WriteLine($"r={r}");
            //    Console.WriteLine($"抽到卡：{name}");

            //    string input = Console.ReadLine();  // 读取输入一行字符串，以换行键结束
            //    input = input.Trim(); // 移除所有前后空白字符
            //    if (input == "end")
            //    {
            //        // 结束
            //        //flag = false;
            //        break;
            //    }
            //}


            /* 练习题1
             * 计算1+2+3+4+.....+1000的和
            */
            //int numTotal = 0;
            //int i = 1;
            //while(i <= 100)
            //{
            //    numTotal += i;
            //    i++;
            //}
            //Console.WriteLine(numTotal);

            /* 练习题2-1
             * 输入数字，打印该数字的2倍，不断重复
             * 练习题2-2
             * 加入结束功能，如果输入"end"则程序结束
             * 练习题2-3
             * 在上一题的基础上，如果输入的不是数字，那么提示重新输入
             */

            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "end")
            //    { break; }

            //    int num;
            //    bool success = int.TryParse(input,out num); // out输出参数

            //    if (success)
            //    { Console.WriteLine("2*n = " + 2 * num); }

            //    else
            //    { Console.WriteLine("请重新输入"); }

            //    //int n = int.Parse(input);
            //    //Console.WriteLine("2*n = " + 2 * n);

            //}

            //Console.WriteLine("输入结束");


            /* 练习题3
           * 猜数字游戏，电脑先随机一个1~100的数字，玩家来猜。
           * 如果猜的数字偏大，偏小，电脑给出提示
           * 如果猜的数字正确，则提示“您猜对了，一共猜了？次”
           */
            Console.WriteLine("请输入数字：");
            bool equal = false;
            int time = 0;

            while (!equal)
            {
               
                int r = random.Next(1, 101);
                string input = Console.ReadLine();
             
                if (input == "end")
                { break; }

                int num;
                bool success = int.TryParse(input, out num); // out输出参数
     
                Console.WriteLine($"你输入的数字是{num}");
                if (r == num)
                {
                    equal = true;
                    Console.WriteLine("您猜对了。");
                    Console.WriteLine($"您一共猜了{time}次。");
                    break;
                }
                else if (r > num)
                {
                    Console.WriteLine("您猜的数字偏小,请继续输入。");
                    time++;
                    Console.WriteLine($"您当前一共猜了{time}次");
                    equal = false;
                }
                
                else 
                {
                    Console.WriteLine("您猜的数字偏大,请继续输入。");
                    time++;
                    Console.WriteLine($"您当前一共猜了{time}次");
                    equal = false;
                }
                

            }
          
            Console.WriteLine("输入结束。");
           

         
            Console.ReadKey(); 
        }
    }
}
