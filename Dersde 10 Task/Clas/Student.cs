using System;

namespace Clas
{
    public class Student
    {
        public Student()
        {
            _count++;
            _no = _count;
        }
        static private int _count;
        private int _no=0;
        public int No { get { return _no; } }
        public string Name;
        private string _groupNo;
        public string GroupNo { set { if (CheakGroupNo(value)) { _groupNo = value; } } get { return _groupNo;} }
        public static bool CheakGroupNo(string input) 
        {
            if (string.IsNullOrWhiteSpace(input) )
            {
                return false;
            }
            else if (input.Length != 4)
            {
                return false;
            }
            else if (char.IsUpper(input[0])&& char.IsDigit(input[1])&& char.IsDigit(input[2]) && char.IsDigit(input[3]))
            {
                return true;
            }
            return false;
        }


    }
}
