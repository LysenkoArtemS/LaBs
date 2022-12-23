using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _1.Tests
{
    [TestClass()]
    public class UserTests
    {
        private User user;

        [TestInitialize]
        public void Initialize()
        {
            user = new User("Aaa", "Bbb", "arrrr", DateTime.Parse("2009.01.01"));
        }

        [DataTestMethod]
        [DataRow("Mr", "Bob", "login")]
        public void Constructor_SetValidValues_Tests(string firstName, string lastName,
            string login)
        {
            DateTime dateOfReg = DateTime.Parse("2009.11.10");
            User user = new User( firstName, lastName, login, dateOfReg);

            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(firstName, user.Name);
            Assert.AreEqual(lastName, user.Surname);
            Assert.AreEqual(dateOfReg, user.DateOfRegistration);
        }

       
        [DataTestMethod]
        [DataRow("Dmitry")]
        [DataRow("Дима")]
        public void Name_SetValidValues_Tests(string name)
        {
            user.Name = name;

            Assert.AreEqual(name, user.Name);
        }

        [DataTestMethod]
        [DataRow("Dл")]
        [DataRow("Дима3")]
        [DataRow("15")]
        [DataRow("дима")]
        [DataRow("дима дим")]
        [DataRow("Dddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbbbddd")] //50+ symbols
        public void Name_SetInvalidValues_ThrowsException_Tests(string name)
        {
            Assert.ThrowsException<PatternException>(() => user.Name = name);
        }

        [DataTestMethod]
        [DataRow("Maximoff")]
        [DataRow("Максимов")]
        [DataRow("Максимов-Макс")]
        [DataRow("V")]
        [DataRow("Dddddddddddddddddddddddddddddddddddddddddddddddddbdddddddddddddddddddddddddddddddddddddddddddddddddbdddddddddddddddddddddddddddddddddddddddddddddddddbdddddddddddddddddddddddddddddddddddddddddddddddddd")]
        public void Surname_SetValidValues_Tests(string surname)
        {
            user.Surname = surname;

            Assert.AreEqual(surname, user.Surname);
        }

        [DataTestMethod]
        [DataRow("Dл")]
        [DataRow("D-П")]
        [DataRow("Дима3")]
        [DataRow("15")]
        [DataRow("дима")]
        [DataRow("дима дим")]
        [DataRow(null)]
        [DataRow("Dddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbbbdddddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbbbdddddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbbbdddddddddddddddddddddddddddddddddddddddddddddddddbbbbbbbbbbddd")] //200+ symbols
        public void Surname_SetInvalidValues_ThrowsException_Tests(string surname)
        {
            Assert.ThrowsException<PatternException>(() => user.Surname = surname);
        }

        [DataTestMethod]
        [DataRow("a@mail.ru")]
        [DataRow("alex@a.ru")]
        [DataRow("alex@aa.ss.dd.ff.gg.hh.jj.kk.ru")]
        public void Mail_SetValidValues_Tests(string mail)
        {
            user.Mail = mail;

            Assert.AreEqual(mail, user.Mail);
        }

        [DataTestMethod]
        [DataRow("_aa@mail.ru")]
        [DataRow("aa_@mail.ru")]
        [DataRow("aa@.ru")]
        [DataRow("aa@w..ru.")]
        public void Mail_SetInvalidValues_ThrowsException_Tests(string mail)
        {
            Assert.ThrowsException<PatternException>(() => user.Mail = mail);
        }

        [DataTestMethod]
        [DataRow("log")]
        [DataRow("v")]
        [DataRow("dddDDDDdddddddddddDd")] 
        public void Login_SetValidValues_Tests(string login)
        {
            user.Login = login;

            Assert.AreEqual(login, user.Login);
        }

        [DataTestMethod]
        [DataRow("логин")]
        [DataRow("login123")]
        [DataRow("loginloginloginlogin1222")] //21 symbols
        public void Login_SetInvalidValues_ThrowsException_Tests(string login)
        {
            Assert.ThrowsException<PatternException>(() => user.Login = login);
        }

        [TestMethod]
        public void BirthDate_SetValidDate_Test()
        {
            DateTime date = DateTime.Parse("10-10-2010");

            user.DateOfBirth = date;

            Assert.AreEqual(date, user.DateOfBirth);
        }

        [TestMethod]
        public void BirthDate_SetInvalidDate_ThrowsException_Test()
        {
            user.DateOfRegistration = DateTime.Parse("10-10-2002");
            DateTime date = DateTime.MaxValue;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => user.DateOfBirth = date);
        }

        [DataTestMethod]//
        [DataRow("Aaa", "Bbb", "arrrr", "2009.01.01", "vvv@mail.ru",null)]
        [DataRow("Aaa", "Bbb", "arrrr", "2009.01.01",null, "10-10-2000")]
        [DataRow("Aaa", "Bbb", "arrrr", "2009.01.01", "vvv@mail.ru", "10-10-2000")] 
        public void Method_ToString_Tests(string name, string surname, string login, 
            string dateOfRegistration, string mail, string dateOfBirth)
        {
            DateTime registrationDateTime = DateTime.Parse(dateOfRegistration);
            DateTime? birthDateTime = null;
            if (dateOfBirth != null)
            {
                birthDateTime = DateTime.Parse(dateOfBirth);
            }

            User user = new User(name, surname, login, registrationDateTime);          
            user.DateOfBirth = birthDateTime;
            user.Mail = mail;

            string result = $"{login},{name},{surname},{mail},{dateOfBirth}";

            Assert.AreEqual(result, user.ToString());
        }

        [DataTestMethod]//
        [DataRow("arrrr,Bbb,Aaaa,vvv@mail.ru,", null)]
        [DataRow("arrrr,Bbb,Aaaa,,10.10.2000 0:00:00", "10-10-2000")]
        [DataRow("arrrr,Bbb,Aaaa,vvv@mail.ru,10.10.2000 0:00:00", "10-10-2000")]
        public void Method_FillFromString_Tests(string str, string date)
        {
            user.FillFromString(str);
            string result = $"{user.Login},{user.Name},{user.Surname},{user.Mail},{user.DateOfBirth}";
            Assert.AreEqual(str, result);//rf;le
        }
    }
}