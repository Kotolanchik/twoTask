using System;

namespace вторая_задача.AccessLevel
{
    internal class Guest : IAction
    {
        public void Action()
        {
            Console.WriteLine("Я могу только смотреть на сайт.");
        }
        public override string ToString()
        {
            return "Гость";
        }
    }
}
