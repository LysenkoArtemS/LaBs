using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    internal class User
    {    
        private DateTime _dateOfRegistration;
        private DateTime _dateOfBirth;
        private string _name;
        private string _surname;
        private string _mail;
        private string _login;

        private const int nameSize = 50;
        private const int surnameSize = 200;
        private const int mailSize = 100;
        private const int loginSize = 20;
        private const string _namePattern = (@"^[A-Z][a-z]*$|^[А-ЯЁ][а-яё]*$");
        private const string _surnamePattern = @"^[A-Z][a-z]*(?:-[A-Z][a-z]*)?$|^[А-ЯЁ][а-яё]*(?:-[А-ЯЁ][а-яё]*)?$";
        private const string _mailPattern = @"^[^\W_](?:[\w\-\.]*[^\W_])?@(?:[^\W_](?:[\w\-]*[^\W_])?\.){1,}[a-zA-Z]{2,6}$";
        private const string _loginPattern = @"^[a-zA-Z]*$";
        public User (string name, string surname, string login, DateTime date)
        {
            Name = name;
            Surname = surname;
            Login = login;
            DateOfRegistration = date;
        }   //
       
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if(value <= DateTime.Today)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new PatternException("DateOfBirth", DateOfBirth);
                }
            }
        }
        public DateTime DateOfRegistration
        {
            get
            {
                return _dateOfRegistration;
            }
            set
            {
                
                if (value <= _dateOfBirth && _dateOfBirth != null)
                {
                    throw new PatternException("DateOfRegistration",value );                  
                }
                else
                {
                    _dateOfRegistration = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                if (CheckIfRegExp(_namePattern, nameSize, value))
                {

                    _name = value;
                }
                else
                {
                    throw new PatternException("Name", Name);
                }

            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {

                if (CheckIfRegExp(_surnamePattern, surnameSize, value))
                {
                    _surname = value;
                }
                else
                {
                    throw new PatternException("Surname", Surname);
                }

            }
        }
        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {

                if (CheckIfRegExp(_mailPattern, mailSize, value))
                {
                    _mail = value;
                }
                else
                {
                    throw new PatternException("Mail", Mail);
                }
            }
        }
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {

                if (CheckIfRegExp(_loginPattern, loginSize, value))
                {
                    _login = value;
                }
                else
                {
                    throw new PatternException("Login",Login);
                }
            }
        }

        public bool CheckIfRegExp(string pattern, int size,string str)
        {       
            if (str.Length <= size)
            {
                if (Regex.IsMatch(str, pattern))
                {
                    return true;
                }
            }              
            return false;
        }

        public override string ToString()//sb
        {
            return Login + "," + Name + "," + Surname + "," + Mail + "," + DateOfBirth.ToString("dd-MM-yyyy");
        }
        public void FillFromString(string str)
        {
            char[] separators = new char[] { ',' };
            string[] splited = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Login = splited[0].Trim();
            Name = splited[1].Trim();
            Surname = splited[2].Trim();
            Mail = splited[3].Trim();
            if (DateTime.TryParse(splited[4].Trim(), out DateTime date))//d
            {
                DateOfBirth = date;
            }
            else
            {
                throw new Exception("DateOfBirth");
            }
            
        }
    }
}