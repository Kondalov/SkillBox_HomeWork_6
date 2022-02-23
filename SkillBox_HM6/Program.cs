using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace SkillBox_HM6
{
    class Program
    {
        private static string path = Path.Combine(Environment.CurrentDirectory, "test.txt");

        static void Main(string[] args)
        {
            #region Заметки
            #region Example 25.01.2022

            //worker worker = new worker()
            //{
            //    ID = 1,
            //    FirstName = "Роберт",
            //    LastName = "Иванов",
            //    Height = 182,
            //};

            //Console.WriteLine("ID: {0}\n FirstName: {1}\n LastName: {2}\n Height: {3}\n", worker.ID.ToString(), worker.FirstName, worker.LastName, worker.Height);

            //string path = @"E:\Temp\write.txt";

            //if (!File.Exists(path))
            //{
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("ID: {0} FirstName: {1} LastName: {2} Height: {3}", worker.ID.ToString(), worker.FirstName, worker.LastName, worker.Height);
            //    }
            //}

            //using (StreamReader read = new StreamReader(path))
            //{
            //    String line;
            //    int i = 0;

            //    while ((line = read.ReadLine()) != null)
            //    {
            //        i++;
            //        worker.ID++; // считывем кол-во строк, чтобы дозаписать новую строку с новым ID
            //        Console.WriteLine(line);


            //    }
            //    Console.WriteLine("Line counts = " + i.ToString());
            //}

            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine("ID: {0} FirstName: {1} LastName: {2} Height: {3}", worker.ID.ToString(), worker.FirstName, worker.LastName, worker.Height);
            //}



            //Console.ReadKey();

            #endregion

            #region Проверка ввода числа
            //int a;
            //Console.WriteLine("Введите целое число a");
            //while (!int.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.WriteLine("Ошибка ввода! Введите целое число a");
            //}
            //Console.WriteLine("число а = " + a);

            //Проверка возраста

            //byte youage;
            //Console.WriteLine("Enter your age...");
            //while (!byte.TryParse(Console.ReadLine(), out youage))
            //{
            //    Console.WriteLine("Error! Enter your age...");
            //}
            #endregion

            #region Проверка ввода дня рождения
            //DateTime dob; // date of birth
            //string input;

            //do
            //{
            //    Console.WriteLine("Введите дату рождения в формате дд.ММ.гггг (день.месяц.год):");
            //    input = Console.ReadLine();
            //}
            //while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out dob));
            //Console.WriteLine("Ты родился " + $"{dob.ToString("d")}");
            #endregion

            #region Print console
            //worker listworkers = new worker()
            //{
            //    ID = 1,
            //    AddTimeorDateNote = DateTime.Today,
            //    FirstName = "Kondalov",
            //    LastName = "Nikolay",
            //    MiddleName = "Nikolaevich",
            //    Age = 39,
            //    Height = 182,
            //    DateBirthDay = DateTime.Today,
            //    City = "Ekaterinburg"
            //};
            #endregion

            #region Пока не нажата клавиша ЦИКЛ будет выполниться
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Цикл будет выполняться пока не будет нажата кнопка Esc");
            //    } 
            //    while (!Console.KeyAvailable);
            //} 
            //while (Console.ReadKey().Key != ConsoleKey.Escape);
            #endregion
            #endregion

            Menu();
        }
        /// <summary>
        /// Меню пользователя
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("Пожалуйста, выберите операцию: \n1 — создать файл \n2 - добавить новую запись \n3 — вывести данные на экран\n4 - Удалить файл\n5 - Exit\n");

            byte menu;

            while (!byte.TryParse(Console.ReadLine(), out menu) || menu <= 0 || menu > 5)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число...");
                continue;

                #region ЗАМЕТКИ
                /*
                Что означает эта строка: while (!byte.TryParse(Console.ReadLine(), out menu) || menu <= 0 || menu > 4)

                Цикл while будет выполняться, пока не будет введено значение от 1 до 4. Если пользователь вводит
                буквы, символы или значения больше чем дано, то будет появляться ошибка.
                */
                #endregion
            }
            switch (menu)
                {
                    case 1:
                    CreateFail();
                    break;
                    case 2:
                    AddStreamWriter();
                    break;
                    case 3:
                    ReadFile();
                    break;
                    case 4:
                    DelateFile();
                    break;
                    case 5:
                    QuitProgramm();
                    break;
                }

        }

        /// <summary>
        /// Новая запись о сотруднике
        /// </summary>
        public static void CreateFail()
        {
            try
            {
                if (File.Exists("test.txt") == true)
                {
                    Console.WriteLine("File exists!");
                    Menu();
                }

                else
                {
                    string path = Path.Combine(Environment.CurrentDirectory, "test.txt");

                    using (FileStream file = File.Create(path))
                    file.Close();
                    Thread.Sleep(1000);
                    Console.WriteLine("File created! " + Environment.CurrentDirectory, path);
                    //Environment.CurrentDirectory, path - показывает полный путь к файлуу
                    Menu();
                }

            }
            catch (Exception errorpath)
            {
                Console.WriteLine("Процесс не может получить доступ к файлу 'test.txt', потому что он используется другим процессом" + errorpath.Message);
                return;
            }
        }

        /// <summary>
        /// Добавить новых сотрудников
        /// </summary>
        static public void AddStreamWriter()
        {
            try
            {
                string note = string.Empty;
                worker.ID = 1;

                using (StreamReader read = new StreamReader(path))
                {
                    String line;

                    while ((line = read.ReadLine()) != null)
                    {
                        note += $"{worker.ID += 1}"; // считывем кол-во строк, чтобы дозаписать новую строку с новым ID
                    }
                    read.Close();
                }

                using (StreamWriter addNote = File.AppendText(path))
                {
                    char key = 'y';

                    do
                    {
                        note += $"{worker.AddTimeorDateNote = DateTime.UtcNow}";

                        Console.WriteLine("Enter your first name: ");
                        worker.FirstName = Console.ReadLine();
                        note += $"{worker.FirstName}";

                        Console.WriteLine("Enter your last name: ");
                        worker.LastName = Console.ReadLine();
                        note += $"{worker.LastName}";

                        Console.WriteLine("Enter your middle name: ");
                        worker.MiddleName = Console.ReadLine();
                        note += $"{worker.MiddleName}";

                        Console.WriteLine("Enter your age: ");
                        while (!byte.TryParse(Console.ReadLine(), out worker.Age))
                        {
                            Console.WriteLine("Error! Enter your age...");
                        }
                        note += $"{worker.Age}";

                        Console.WriteLine("Enter your height: ");
                        //worker.Height = byte.Parse(Console.ReadLine());
                        while (!byte.TryParse(Console.ReadLine(), out worker.Height))
                        {
                            Console.WriteLine("Error! Enter your height...");
                        }
                        note += $"{worker.Height}";


                        Console.WriteLine("Введите свою дату рождения в формате дд.ММ.гггг (день.месяц.год):");

                        while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out worker.DateBirthDay))
                        {
                            Console.WriteLine("Error! Enter your birthday...");
                            note += $"{worker.DateBirthDay}";

                            #region ЗАМЕТКИ

                            // - worker.DateBirthDay:d   тоже самое что и    worker.DateBirthDay.ToString("d")
                            // - ToShortDateString() - выводит формат 20.07.2014

                            #endregion
                        }

                        Console.WriteLine("Enter your city: ");
                        worker.City = Console.ReadLine();
                        note += $"{worker.City}";

                        #region NOTE
                        //writeFile.WriteLine("ID: {0} TimeDate: {1} FirstName: {2} LastName: {3} MiddleName" +
                        //                    "{4} Age {5} Height: {6} BirthDay {7} City: {8}",
                        //                    worker.ID.ToString(),
                        //                    worker.AddTimeorDateNote,
                        //                    worker.FirstName,
                        //                    worker.LastName,
                        //                    worker.MiddleName,
                        //                    worker.Age,
                        //                    worker.Height,
                        //                    worker.DateBirthDay,
                        //                    worker.City);
                        #endregion

                        addNote.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                                                worker.ID.ToString() + "#",
                                                worker.AddTimeorDateNote + "#",
                                                worker.FirstName,
                                                worker.LastName,
                                                worker.MiddleName + "#",
                                                worker.Age + "#",
                                                worker.Height + "#",
                                                worker.DateBirthDay.ToShortDateString() + "#",
                                                "город " + worker.City, Encoding.UTF8);
                        
                        Console.Write("\nПродожить y/n\n"); key = Console.ReadKey(true).KeyChar;
                        if (key == 'y')
                        {
                            note += $"{worker.ID += 1}";
                            continue;
                        }
                        else if (key == 'n')
                        {
                            Console.WriteLine("\nSee you...");
                            Thread.Sleep(1000); // 1000 = 1 секунда. Делает задержку экрана
                            addNote.Close();
                            Menu();
                        }
                    } while (char.ToLower(key) == 'y');

                }
            }
            catch (FileNotFoundException noFile)
            {
                Console.WriteLine(noFile.Message + "Файл будет создан автоматически!");
                CreateFail();
            }
        }

        /// <summary>
        /// Чтение файла
        /// </summary>
        static public void ReadFile()
        {
            try
            {
                using (StreamReader readFile = new StreamReader("test.txt"))
                {
                    String line;
                    int i = 0;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        i++; // общее кол-во строк

                        worker.ID++; // считывем кол-во строк, чтобы дозаписать новую строку с новым ID

                        string[] data = line.Split('\t', '#');
                        for (int result = 0; result < data.Length; result++)
                        {
                            Console.Write(data[result]);
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine("Line counts = " + i.ToString());
                    readFile.Close();
                }
                Console.WriteLine("Please wait 5 seconds...");
                Thread.Sleep(5000);
                Menu();
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine("!!! File not found !!!" + error.Message);
                Thread.Sleep(3000);
                Menu();
            }
        }

        /// <summary>
        /// Удаление файла
        /// </summary>
        static public void DelateFile()
        {
            if (File.Exists("test.txt") == true)
            {
                File.Delete("test.txt");
                Console.WriteLine("Файл успешно удалён!");
                Thread.Sleep(2000);
                Menu();
            }
            else
            {
                Console.WriteLine("File not found...");
                Thread.Sleep(2000);
            }
            
        }

        /// <summary>
        /// Exit
        /// </summary>
        static public void QuitProgramm()
        {
            Environment.Exit(0);
        }
    }
}
