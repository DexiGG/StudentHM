using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_HM
{
    public class Student : IComparer<Student>
    {
        public string FullName { get; set; }
        public float GPA { get; set; }

        public int Compare(Student first, Student second)
        {
            return string.Compare(first.FullName, second.FullName);
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}, Оценка: {1}", FullName, GPA);
        }
    }
}
