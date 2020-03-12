using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random i = new Random();
            int hp = i.Next(0, 100);
            Console.WriteLine("嗨");
            while (true)
            {
                //判斷死亡
                if (hp <= 0)
                {
                    Console.WriteLine("你已經死了...");
                    Console.WriteLine("      ╱╲");
                    Console.WriteLine("    ╱    ╲");
                    Console.WriteLine("  ╱  <●>  ╲");
                    Console.WriteLine("╱＿＿＿＿＿＿╲");
                    break;
                }
                Console.WriteLine("請輸入數字:");
                //檢查是否有人攻擊
                string attackString = Console.ReadLine();
                int attack = int.Parse(attackString);
                //Console.WriteLine(attack);

                //扣血
                hp = hp - attack;
            }
            Console.ReadLine();
        }
    }
}
