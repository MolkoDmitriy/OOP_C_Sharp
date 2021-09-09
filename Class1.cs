using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyClass
{
    class Terminal
    {
        void Begin()
        {
            Console.WriteLine("Меню терминала");
            Console.WriteLine("Для создания файла введите 1");
            Console.WriteLine("Для добавления текста введите 2");
            Console.WriteLine("Чтобы показать текст из файла введите 3");
            Console.WriteLine("Для поиска слова в файле введите 4");
            Console.WriteLine("Для очистки терминала введите 5");
            Console.WriteLine("Чтобы еще раз посмотреть меню введите 6");
            Console.ReadKey();
            Console.Clear();
        }
        public void Start()
        {
            Menu menu = new Menu();
            Begin();
            while (true)
            {
                bool r = int.TryParse(Console.ReadLine(),out int a);
                if (r)
                {
                    switch (a)
                    {
                        case 1:
                            menu.Create();
                            break;
                        case 2:
                            Console.WriteLine("Введите текст:");
                            string text = Console.ReadLine();
                            menu.Input(text);
                            break;
                        case 3:
                            menu.Output();
                            break;
                        case 4:
                            Console.WriteLine("Введите слово для поиска: ");
                            menu.Find(Console.ReadLine());
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            Begin();
                            break;
                        default:
                            Console.WriteLine("Введены некорректные данные! Повторите!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные! Повторите!");
                }

            }
            Console.ReadKey();
        }
    }
    class Menu
    {
        public string pathToFile = @"C:\OOP_doc\test1.txt";

        public void Create()
        {
            if (!File.Exists(pathToFile))
            {
                File.Create(pathToFile);
            }
            Console.WriteLine("Файл создан!");
        }
        public void Input(string text)
        {
            File.AppendAllText(pathToFile, " " + text);
        }
         public void Output()
        {
            Console.WriteLine("Текст из файла:");
            Console.WriteLine(File.ReadAllText(pathToFile));
        }
        public void Find(string text)
        {
            string textFromFile = File.ReadAllText(pathToFile);

            string[] words = textFromFile.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int cnt = 0;
            foreach(string word in words)
            {
                if (word == text) cnt++;
            }
            if (cnt > 0) Console.WriteLine($"Слово найдено! Кол-во повторений - {cnt}");
        }
    }
}
