﻿namespace StringExtensions
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}