using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_10_Task
{
    public class User
    {
        public string Username;
        private string _password;
        public string Password {
            set { if (CheckPassword(value)) { _password = Password; } }
            get { return _password;} }
        public bool CheckPassword(string input)
        {
            if (string.IsNullOrWhiteSpace(input)|| input.Length<8 || input.Length>25)
            {
                return false;
            }
            else
            {
                foreach (var item in input)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }
    }
}
