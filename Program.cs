using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyInterpretator;

namespace OOP_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpretator interpretator = new Interpretator();
            Console.WriteLine(interpretator.GetCommands());
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out int input_num) && (input_num > -1 && input_num < 6))
                {
                    if (input_num == 0) break;
                    interpretator.SetCommand(input_num);
                }
                else Console.WriteLine("Неверные данные");
            };
        }
    }
}
