using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Student
    {
        public string Fullname { get; set; }

        private int _no;
        public int No { get=> _no; }
        public Student()
        {
            _no++;
        }

    }
}
