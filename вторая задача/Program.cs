using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using вторая_задача.AccessLevel;

namespace вторая_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            InitJournal(journal);
            journal.DisplayAdmins();
            journal.DisplayAdvancedUsers();
            journal.DisplayGuest();
            journal.DisplayUsers();

            var admins = journal.Admins;

            var f = admins.FirstOrDefault();
            f.AccessType.Action();
            Console.ReadLine();

        }

        private static void InitJournal(Journal journal)
        {
            User usr = new User();
            Admin admin = new Admin();
            Guest guest = new Guest();
            AdvancedUser advancedUser = new AdvancedUser();

            var pers = new Person<Admin>("ponchik", "KML4lfmm", admin);
            var pers1 = new Person<User>("poncwfvwbfhik", "KML4lfmm", usr);
            var pers2 = new Person<User>("pon33t3bdbchik", "KML4lfmm", usr);
            var pers3 = new Person<Admin>("ponchcdwvik", "KML4lfmm", admin);
            var pers4 = new Person<AdvancedUser>("ponwfvchik", "KML4lfmm", advancedUser);
            var pers5 = new Person<Admin>("ponvwervchik", "KML4lfmm", admin);
            var pers6 = new Person<Guest>("ponvwevvwechik", "KMLvwe4lfmm", guest);

            journal.Add(pers);
            journal.Add(pers2);
            journal.Add(pers3);
            journal.Add(pers4);
            journal.Add(pers5);
            journal.Add(pers6);
        }
    }
}