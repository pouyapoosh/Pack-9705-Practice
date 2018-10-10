using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Average { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Student OtherStudent = obj as Student;
            if (OtherStudent != null)
            {
                return this.Average.CompareTo( OtherStudent.Average );
            }
            else
                throw new ArgumentException("Object doesnt have average");

        }

        public override string ToString()
        {
            return $"{Name} {Family} [{Average}]";
        }
    }
}
