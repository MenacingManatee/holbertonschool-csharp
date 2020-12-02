using System;

class Character
{
    public static bool IsLower(char c)
    {
        return ((int)c <= (int)'z' && (int)c >= (int)'a');
    }
}
