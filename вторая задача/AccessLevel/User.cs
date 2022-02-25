using System;

namespace вторая_задача.AccessLevel
{
    internal class User: IAction
    {
        public void Action()
        {
            Console.WriteLine("Я могу комментировать записи и лайкать их.");
        }

        public override string ToString()
        {
            return "Пользователь";
        }
    }
}
