using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFileManager
{
    class FileManager
    {
        string pathToFile;

        public FileManager(string pathToFile)
        {
            this.pathToFile = pathToFile;
        }

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
            foreach (string word in words)
            {
                if (word == text) cnt++;
            }
            if (cnt > 0) Console.WriteLine($"Слово найдено! Кол-во повторений - {cnt}");
        }

    }
}
