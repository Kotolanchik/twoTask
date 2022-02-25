using System;
using System.Collections.Generic;
using System.Text;
using вторая_задача.AccessLevel;

namespace вторая_задача
{
    internal class Journal
    {
        private List<Person<Admin>> _admins;
        private List<Person<User>> _users;
        private List<Person<AdvancedUser>> _advUsers;
        private List<Person<Guest>> _guest;

        public List<Person<Admin>> Admins
        {
            get => _admins;
        }
        public List<Person<User>> Users
        {
            get => _users;
        }

        public List<Person<AdvancedUser>> AdvUsers
        {
            get => _advUsers;
        }

        public List<Person<Guest>> Guests
        {
            get => _guest;
        }

        internal Journal()
        {
            _admins = new List<Person<Admin>>();
            _users = new List<Person<User>>();
            _advUsers = new List<Person<AdvancedUser>>();
            _guest = new List<Person<Guest>>();
        }

        public bool Add(Person<Guest> person)
        {
            _guest.Add(person);
            return true;
        }

        public bool Add(Person<Admin> person)
        {
            _admins.Add(person);
            return true;
        }

        public bool Add(Person<User> person)
        {
            _users.Add(person);
            return true;
        }

        public bool Add(Person<AdvancedUser> person)
        {
            _advUsers.Add(person);
            return true;
        }

        public void DisplayAdmins()
        {
            Console.WriteLine("ADMINS:");
            foreach (var item in _admins)
            {
                Console.WriteLine(item.Login + $" {item.Id}");
            }
        }

        public void DisplayAdvancedUsers()
        {
            Console.WriteLine("ADVANCEDUSERS:");
            foreach (var item in _advUsers)
            {
                Console.WriteLine(item.Login + $" {item.Id}");
            }
        }

        public void DisplayGuest()
        {
            Console.WriteLine("GUEST:");
            foreach (var item in _guest)
            {
                Console.WriteLine(item.Login + $" {item.Id}");
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine("USERS:");
            foreach (var item in _users)
            {
                Console.WriteLine(item.Login + $" {item.Id}");
            }
        }
    }
}
