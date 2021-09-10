using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFileManager;

namespace MyInterpretator
{
    class Interpretator
    {
        const string pathToFile = @"C:\OOP_doc\test1.txt";

        FileManager fileManager = new FileManager(pathToFile);
        public string GetCommands()
        {
            string command = "Меню терминала\n" +
                "Введите 0 для выхода из программы\n"+
                "Для создания файла введите 1\n" +
                "Для добавления текста введите 2\n" +
                "Чтобы показать текст из файла введите 3\n" +
                "Для поиска слова в файле введите 4\n" +
                "Для очистки терминала введите 5\n";

            return command;
        }

        public void SetCommand(int key)
        {
            switch (key)
            {
                case 1:
                    fileManager.Create();
                    break;
                case 2:
                    Console.WriteLine("Введите текст:");
                    string text = Console.ReadLine();
                    fileManager.Input(text);
                    break;
                case 3:
                    fileManager.Output();
                    break;
                case 4:
                    Console.WriteLine("Введите слово для поиска: ");
                    fileManager.Find(Console.ReadLine());
                    break;
                case 5:
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }
    }
}