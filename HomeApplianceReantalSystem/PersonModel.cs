using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceReantalSystem
{
    class PersonModel
    {
        private string _ID, _Name, _Email, _Password, _Gender,_Photo;
        string ErrorMessage;
        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string Eamil
        {
            set { _Email = value; }
            get { return _Email; }
        }
        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }
        public string Gender
        {
            set { _Gender = value; }
            get { return _Gender; }
        }

        public string Photo
        {
            set { _Photo = value; }
            get { return _Photo; }
        }

        public string PasswordValidationCheck(string pwd)   // password validation check
        {
            string password = pwd;
            if (password.Length < 8 || password.Length > 16)
            {
                ErrorMessage= "Password Length must between 8 to 16!";
                return ErrorMessage;
            }
            else if (!password.Any(char.IsUpper))
            {
                ErrorMessage = "Password should contain Upper case!";
                return ErrorMessage;
            }else if (!password.Any(char.IsLower))
            {
                ErrorMessage = "Password should contain Lower case!";
                return ErrorMessage;
            }else if (!password.Any(char.IsDigit))
            {
                ErrorMessage = "Password should contain Digit!";
                return ErrorMessage;
            }
            else
            {
                return password;
            }
        }
    }
}
