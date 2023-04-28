using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_16
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int i = Convert.ToInt32(Console.ReadLine());
            var t1 = PrintAsync($"Привет!", "t1");
            var t2 = PrintAsync("Hello!", "t2");
            var t3 = PrintAsync("Hi!", "t3");
            var t4 = PrintCount(i);
            await t1;
            await t2;
            await t3;
            await t4;

            async Task PrintAsync(string msg, string task)
            {
                await Task.Delay(100);
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(50);
                    Console.WriteLine($"{msg} Меня вывел поток {task}");
                }
            }
            async Task PrintCount(int i) 
            {
                while (i>0)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"{i} - 1 = {i - 1}");
                    i = i - 1;
                }
            }
        }
    }
}