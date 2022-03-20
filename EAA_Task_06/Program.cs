using System;
using System.Collections.Generic;

namespace EAA_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullNames = new List<Dossier>();
            var posts = new List<string>();

            string action = "0";

            while(action != "5")
            {
                ShowMenu();
                action = Console.ReadLine();
                Console.WriteLine("\n--<===>--\n");

                switch(action)
                {
                    case "1":
                        AddDosier(fullNames, posts);
                        break;

                    case "2":
                        ShowDosiers(fullNames, posts);
                        break;

                    case "3":
                        RemoveDosiers(fullNames, posts);
                        break;

                    case "4":
                        SearchDosiers(fullNames, posts);
                        break;

                    case "5":
                        Console.WriteLine("Окончание работы программы, благодарим вас за использование!");
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Отдель кадров:");
            Console.WriteLine("1 - добвить досье");
            Console.WriteLine("2 - вывести все досье");
            Console.WriteLine("3 - удалить досье");
            Console.WriteLine("4 - посик по фамилии");
            Console.WriteLine("5 - выход из программы");

            Console.Write("\nВыберите пунтк меню: ");
        }

        static void AddDosier(List<Dossier> fullNames, List<string> posts)
        {
            Console.WriteLine("Добавление досье\n");

            Console.Write("Введите фамилию: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите имя: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();

            Console.Write("Введите должность: ");
            string post = Console.ReadLine();

            var newDossier = new Dossier(firstName, lastName, patronymic);
            fullNames.Add(newDossier);
            posts.Add(post);

            Console.Write("\n<< Данные успешно занесены >>\n");
            Console.ReadLine();
        }

        static void ShowDosiers(List<Dossier> fullNames, List<string> posts)
        {
            Console.WriteLine("Список всез досье\n");

            if (fullNames.Count > 0)
            {
                for (int i = 0; i < fullNames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.     {fullNames[i].ShowData()} - {posts[i]}");
                }
            }
            else
            {
                Console.WriteLine("Отсутствуют какие-либо досье");
            }

            Console.ReadLine();
        }

        static void RemoveDosiers(List<Dossier> fullNames, List<string> posts)
        {
            Console.WriteLine("Добавление досье\n");

            if (fullNames.Count > 0)
            {

                Console.Write("Ведите номрер досье для удаления: ");
                string dossierNum = Console.ReadLine();

                if (int.TryParse(dossierNum, out int i))
                {
                    if ((i < fullNames.Count + 1) && (i > 0))
                    {
                        fullNames.RemoveAt(i - 1);
                        posts.RemoveAt(i - 1);

                        Console.Write("\n<< Данные успешно занесены >>\n");
                    }
                    else
                    {
                        Console.WriteLine("!!! Досье с таким номером не существует !!!");
                    }
                }
                else
                {
                    Console.WriteLine("!!! Вы ввели неправильное значение !!!");
                }
            }
            else
            {
                Console.WriteLine("Отсутствуют какие-либо досье");
            }

            Console.ReadLine();
        }

        static void SearchDosiers(List<Dossier> fullNames, List<string> posts)
        {
            Console.WriteLine("Добавление досье\n");

            if (fullNames.Count > 0)
            {

                Console.Write("Ведите фамилию для поиска: ");
                string nameToSearch = Console.ReadLine();

                int quant = 0;
                for (int i = 0; i < fullNames.Count; i++)
                {
                    if (fullNames[i].TakeLName() == nameToSearch)
                    {
                        quant++;
                        Console.WriteLine($"{quant}.     {fullNames[i].ShowData()} - {posts[i]}");
                    }
                }

                if (quant == 0)
                {
                    Console.WriteLine("Сотрудника с фамилией " + nameToSearch + " нет");
                }
                else
                {
                    Console.WriteLine("Количество сотрудников с фамилией - " + quant);
                }
            }
            else
            {
                Console.WriteLine("Отсутствуют какие-либо досье");
            }

            Console.ReadLine();
        }
    }
}
