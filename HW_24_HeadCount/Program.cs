using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_HeadCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            string[] name = new string[0];
            string[] profesion = new string[0];

            Console.WriteLine("" +
                    "1 - Добавить досье\n" +
                    "2 - Вывести все досье\n" +
                    "3 - Удалить досье\n" +
                    "4 - Поиск по фамилии\n" +
                    "5 - Выход");
            while (isRunning)
            {
                Console.Write("Выберите пункт меню: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AddFiles(ref name, ref profesion);
                        break;
                    case 2:
                        ShowAllFiles(ref name, ref profesion);
                        break;
                    case 3:
                        name = DeleteFiles(name);
                        break;
                    case 4:
                        FindFiles(ref name, ref profesion);
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная комманда !");
                        break;
                }
            }
        }

        static void AddFiles(ref string []name, ref string[] profesion)
        {
            Console.Write("Введите ФИО: ");
            string userInput = Console.ReadLine();

            name = name.Append(userInput).ToArray();

            Console.Write("Введите должность: ");
            userInput = Console.ReadLine();
            profesion = profesion.Append(userInput).ToArray();
        }

        static string[] DeleteFiles(string[] name)
        {
            Console.Write("Введите ФИО для удаления: ");
            string userInput = Console.ReadLine();

            string[] tempArray = new string[name.Length - 1];
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == userInput)
                {
                    continue;
                }
                else if (name[i] != userInput)
                {
                    tempArray[i - 1] = name[i];
                }
            }
            name = tempArray;
            return name;
        }

        static void FindFiles(ref string[] name, ref string[] profesion)
        {
            Console.Write("Введите фамилию: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {              
                if (name[i] == userInput)
                {
                    Console.WriteLine($"{i + 1} - {name[i]} - {profesion[i]}");
                }
            }
            Console.WriteLine("Не найдено !");
        }

        static void ShowAllFiles(ref string []name, ref string[] profesion)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i+1} - {name[i]} - {profesion[i]}");
            }
        }
    }
}
