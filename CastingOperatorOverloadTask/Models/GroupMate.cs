using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperatorOverloadTask.Models
{
    class GroupMate
    {
        private Student[] _students = new Student[0];

        public Student this[int index]
        {
            get { return _students[index]; }
            set
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[index] = value;
            }
        }

        public Student[] GetStudents()
        {
            return _students;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public void Sort()
        {
            if (_students.Length > 1)
            {
                for (int i = 0; i < _students.Length; i++)
                {
                    int minIndex = i;
                    for (int j = i; j < _students.Length; j++)
                    {
                        if (_students[j] > _students[i])
                        {
                            minIndex = j;
                            Student temp = _students[minIndex];
                            _students[minIndex] = _students[i];
                            _students[i] = temp;
                        }
                    }
                }
                GetSortedPoint();
            }
            else throw new Exception("Massivi sıralamaq üçün minimum 2 elementi olmalıdır.");
        }
        public void GetSortedPoint()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
