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
    public class User
    {    
        private DateTime _dateOfRegistration;
        private DateTime? _dateOfBirth = null;
        private string _name;
        private string _surname;
        private string _mail = null;
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
        }
        public User()
        {
        }

        public DateTime? DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                {
                    if (value is null)
                    {
                        _dateOfBirth = null;
                    }
                    else
                    {
                        if ((value > DateTime.Now))
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        else
                        {
                            _dateOfBirth = value;
                        }
                    }
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
                    throw new ArgumentOutOfRangeException();                  
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
                    throw new PatternException("Name", _namePattern);
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
                    throw new PatternException("Surname", _surnamePattern);
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
                if (value is null)
                {
                    _mail = null;
                }
                else
                {
                    if (CheckIfRegExp(_mailPattern, mailSize, value))
                    {
                        _mail = value;
                    }
                    else
                    {
                        throw new PatternException("Mail", _mailPattern);
                    }
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
                    throw new PatternException("Login", _loginPattern);
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

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Login);
            sb.Append(",");
            sb.Append(Name);
            sb.Append(",");
            sb.Append(Surname);
            sb.Append(",");
            sb.Append(Mail);
            sb.Append(",");
            sb.Append(DateOfBirth?.ToString("dd-MM-yyyy"));
            return sb.ToString();
        }
        public void FillFromString(string str)
        {
            char[] separators = new char[] { ',' };
            string[] splited = str.Split(separators);
            if (splited.Length != 5)
            {
                throw new ArgumentOutOfRangeException();
            }
            Login = splited[0].Trim();
            Name = splited[1].Trim();
            Surname = splited[2].Trim();
            if (splited[3] == "")
            {
                Mail = null;
            }
            else
            {
                Mail = splited[3].Trim();
            } 
            
            if (splited[4] == "")
            {
                DateOfBirth = null;
            }
            else
            {
                    
                if (DateTime.TryParse(splited[4].Trim(), out DateTime date))
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
}