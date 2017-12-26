using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryLogic;
using CSUtils;
using System.IO;

namespace Task10_Example_Cli
{
    class Program
    {
        static List<Student> ReadStudentsList()
        {
            List<Student> students;

            if (ConsoleUtils.Confirm("Ввести данные из файла?"))
            {
                while (true)
                {
                    try
                    {
                        string inputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу",
                            (path) => (File.Exists(path)));

                        students = StudentsFileUtils.ReadStudentsListFromFile(inputFilePath);
                        break;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            else
            {
                int studentsCount = ConsoleUtils.ReadValue<int>("количество студентов", (count) => (count > 0));

                students = new List<Student>(studentsCount);

                for (int i = 0; i < studentsCount; i++)
                {
                    string name = ConsoleUtils.ReadValue<string>("ФИО студента",
                        (string fullName) => fullName != "");

                    string sexValue = ConsoleUtils.ReadValue<string>("пол", (string s) => s == "м" || s == "ж");

                    int course = ConsoleUtils.ReadValue<int>("курс", (int c) => c > 0);
                    int points = ConsoleUtils.ReadValue<int>("количество баллов", (int p) => p > 0);

                    students.Add(new Student(name, sexValue, course, points));
                }
            }

            Console.WriteLine();
            return students;
        }

        static void SaveResultToFile(string result)
        {
            while (true)
            {
                try
                {
                    string outputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу");

                    FileUtils.WriteStringToFile(outputFilePath, result);
                    break;
                }
                catch (Exception e)
                {

                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в программу \"Отбор студентов\"");
                Console.WriteLine();

                // Читаем список студентов
                List<Student> students = ReadStudentsList();

                // Сортируем список студентов
                try
                {
                    StudentsSorter sorter = new StudentsSorter(students);

                    string result = "";

                    foreach (Pair pair in sorter.GetStudentsForParty())
                    {
                        result += pair.Course + " курс: ";
                        if (pair.Boy == null || pair.Girl == null)
                        {
                            result += "пары нет" + Environment.NewLine;
                        }
                        else
                        {
                            result += pair.Boy.FullName + " и " + pair.Girl.FullName + Environment.NewLine;
                        }
                    }

                    Console.WriteLine(result);

                    if (ConsoleUtils.Confirm("Сохранить результат в файл?"))
                    {
                        SaveResultToFile(result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка!");
                }

                if (ConsoleUtils.Confirm("Продолжить работу с программой?"))
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }
    }
}
