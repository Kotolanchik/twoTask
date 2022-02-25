using System;

namespace вторая_задача.AccessLevel
{
    internal class AdvancedUser : IAction
    {
        public void Action()
        {
            Console.WriteLine("Я могу добавить страничку на сайт.");
        }

        public override string ToString()
        {
            return "Продвинутый пользователь";
        }
    }
}
