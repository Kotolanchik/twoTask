using System;

namespace вторая_задача.Tools
{
    internal static class CheckPass
    {
        internal static bool CheckNumbers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool CheckRegistr(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool CheckSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
