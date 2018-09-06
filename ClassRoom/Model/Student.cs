using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom.Model
{
    class Student
    {
        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            Birthmonth = birthmonth;
            Birthday = birthday;
        }

        public string Name { get; }
        public int Birthmonth { get; }
        public int Birthday { get; }
    }
}
