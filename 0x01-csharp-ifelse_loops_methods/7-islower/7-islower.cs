using System;

class Character
{
    /// Checks if a letter is lowercase
    public static bool IsLower(char c)
    {
        return ((int)c <= (int)'z' && (int)c >= (int)'a');
    }
}
