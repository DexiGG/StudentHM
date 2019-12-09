using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Student>();


            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                "1) Добавить студента\n" +
                "2) Список студентов\n" +
                "3) Отобразить лучшего студента\n" +
                "4) Отобразить худшего студента\n" +
                "5) Отобразить среднюю оценку\n" +
                "6) Выход из приложения");

                int choice = 0;
                bool success = int.TryParse(Console.ReadLine(), out choice);

                Console.Clear();



                if (success && (choice > 0 && choice <= 6))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите полное имя студента:");
                                string fullName = Console.ReadLine();

                                float gpa;
                                do
                                {
                                    Console.Clear();
                                    Console.Write("Введите среднюю оценку студента: ");
                                } while (!float.TryParse(Console.ReadLine(), out gpa));

                                list.Add(new Student { FullName = fullName, GPA = gpa });
                            }
                            break;
                        case 2:
                            {
                                if (list.Count > 0)
                                {
                                    list.Sort(new Student());

                                    foreach (Student student in list)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                            }
                            break;
                        case 3:
                            {
                                float rank = list.Max(student => student.GPA);

                                List<Student> students = list.FindAll(s => s.GPA == rank);

                                if (students != null)
                                {
                                    ShowListOfStudents(students);
                                }
                            }
                            break;
                        case 4:
                            {
                                float rank = list.Min(student => student.GPA);

                                List<Student> students = list.FindAll(s => s.GPA == rank);

                                if (students != null)
                                {
                                    ShowListOfStudents(students);
                                }
                            }
                            break;
                        case 5:
                            {
                                float avgRank = list.Average(student => student.GPA);

                                ShowListOfStudents(list);
                                Console.WriteLine("\nСредняя оценка студентов: {0}", avgRank);
                            }
                            break;
                        case 6: Environment.Exit(0); break;
                        default:
                            break;
                    }
                    Console.WriteLine("Чтобы продолжить нажмите Enter...");
                    Console.ReadLine();
                }
            }
        }
        static void ShowListOfStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);

            }
        }
    }
}
