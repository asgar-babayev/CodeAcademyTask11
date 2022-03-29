using CastingOperatorOverloadTask.CustomExceptions;
using CastingOperatorOverloadTask.Models;
using System;

namespace CastingOperatorOverloadTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person[] teachers = new Teacher[0];
            Person[] students = new Student[0];
            GroupMate groupMate = new GroupMate();
            int choise;
            int index = 0;
            do
            {
                Console.WriteLine(@"0 - Sonlandır
1 - Tələbə yarat
2 - Müəllim yarat
3 - Tələbə məlumatları
4 - Müəllim məlumatları
5 - Bal sıralaması
6 - Maaş müqayisəsi");

                SetChoiseInput(out choise);
                switch (choise)
                {
                    case 1:
                        SetNameInput(out string studentName);
                        SetSurnameInput(out string studentSurname);
                        SetStudentAgeInput(out int studentAge);
                        SetPointInput(out double point);
                        Person student = new Student(studentName, studentSurname, studentAge, point);
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = student;
                        groupMate[index] = (Student)students[index];
                        index++;
                        break;
                    case 2:
                        SetNameInput(out string teacherName);
                        SetSurnameInput(out string teacherSurname);
                        SetTeacherAgeInput(out int teacherAge);
                        SetSalaryInput(out double salary);
                        Person teacher = new Teacher(teacherName, teacherSurname, teacherAge, salary);
                        Array.Resize(ref teachers, teachers.Length + 1);
                        teachers[teachers.Length - 1] = teacher;
                        break;
                    case 3:
                        foreach (var items in groupMate.GetStudents())
                            if (items != null)
                                Console.WriteLine(items);
                        break;
                    case 4:
                        foreach (var items in teachers)
                            if (items != null)
                                Console.WriteLine(items);
                        break;
                    case 5:
                        CheckSorting(groupMate);
                        break;
                    case 6:
                        if (teachers.Length > 2)
                            Console.WriteLine((Teacher)teachers[0] > (Teacher)teachers[1]);
                        else throw new Exception("Minimum iki müəllim olmalıdır");
                        break;
                    default:
                        break;
                }

            } while (choise != 0);
        }


        static void SetChoiseInput(out int choise)
        {
        Start:
            try
            {
                Console.Write("Seçim edin: ");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetNameInput(out string name)
        {
        Start:
            try
            {
                Console.Write("Ad:");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                    throw new NotAvailableException("Ad daxil etmək məcburidir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetSurnameInput(out string surname)
        {
        Start:
            try
            {
                Console.Write("Soyad:");
                surname = Console.ReadLine();
                if (String.IsNullOrEmpty(surname) || String.IsNullOrWhiteSpace(surname))
                    throw new NotAvailableException("Soyad daxil etmək məcburidir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetStudentAgeInput(out int age)
        {
        Start:
            try
            {
                Console.Write("Yaş:");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 6 || age > 20)
                    throw new NotAvailableException("Uyğun yaş deyil.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetTeacherAgeInput(out int age)
        {
        Start:
            try
            {
                Console.Write("Yaş:");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                    throw new NotAvailableException("Uyğun yaş deyil.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetPointInput(out double point)
        {
        Start:
            try
            {
                Console.Write("Bal:");
                point = Convert.ToInt32(Console.ReadLine());
                if (point < 0 || point > 100)
                    throw new NotAvailableException("Bal 0-100 arası yazılmalıdır.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void SetSalaryInput(out double salary)
        {
        Start:
            try
            {
                Console.Write("Maaş:");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary < 0)
                    throw new NotAvailableException("Maaş 0-dan böyük olmalıdır.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckSorting(GroupMate groupMate)
        {
            try
            {
                groupMate.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
