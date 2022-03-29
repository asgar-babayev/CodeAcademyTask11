using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperatorOverloadTask.Models
{
    class Student : Person
    {
        private static int _id;
        private int _age;
        private double _point;
        public override int Id { get; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value > 6 || value <= 20)
                    _age = value;
            }
        }
        public double Point
        {
            get { return _point; }
            set
            {
                if (value >= 0 || value <= 100)
                    _point = value;
            }
        }

        static Student()
        {
            _id = 0;
        }

        private Student()
        {
            _id++;
            Id = _id;
        }

        public Student(string name, string surname, double point) : this()
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public Student(string name, string surname, int age, double point) : this(name, surname, point)
        {
            Age = age;
        }

        public override string ShowInfo()
        {
            return$@"Id - {Id}
Name - {Name}
Surname - {Surname}
Age - {Age}
Point - {Point}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

        public static bool operator >(Student st1, Student st2)
        {
            return st1.Point > st2.Point;
        }

        public static bool operator <(Student st1, Student st2)
        {
            return st1.Point < st2.Point;
        }
    }
}
