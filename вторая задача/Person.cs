using System;
using System.Collections.Generic;
using System.Linq;
using вторая_задача.AccessLevel;
using вторая_задача.Tools;

namespace вторая_задача
{
    internal class Person<T>
    {
        private string _login;
        private string _password;
        private Guid _id;
        private T _accessType;

        public T AccessType
        {
            get { return _accessType; }
            private set
            {
                if (value is Guest || value is AdvancedUser || value is User || value is Admin)
                {
                    _accessType = value;
                }
                else
                {
                    throw new InvalidCastException("Такого типа данных нет.");
                }
            }
        }

        private string Password
        {
            set
            {
                if (value.Count() > 7 && CheckPass.CheckSpace(value) && CheckPass.CheckNumbers(value) && CheckPass.CheckRegistr(value))
                {
                    _password = value;
                }
                else if (_accessType is Guest)
                {
                    _password = "";
                }
                else
                {
                    throw new ArgumentException("Такой пароль не подходит.");
                }
            }
        }

        public string Login
        {
            get => _login;
            private set
            {
                if (_accessType is Guest)
                {
                    _login = "Гость";
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Пустой логин");
                }
                else
                {
                    _login = value;
                }
            }
        }

        public Guid Id
        {
            get => _id;
            private set
            {
                _id = Guid.NewGuid();
            }
        }

        internal Person(string login, string password, T accessType)
        {
            AccessType = accessType;
            Login = login;
            Password = password;
            Id = _id;
        }
    }
}



