using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_10_Task
{
    internal class Student
    {
        public Student()
        {
            Count++;
            No = Count;
        }
        static int Count;
        public int No = Count;
        public string Name;
        public byte Point;
    }
}
