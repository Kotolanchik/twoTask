using System;

namespace вторая_задача.AccessLevel
{
    internal class Admin : IAction
    {
        public void Action()
        {
            Console.WriteLine("Я управляю всей системой сайта.");
        }

        public override string ToString()
        {
            return "Админ";
        }
    }
}
