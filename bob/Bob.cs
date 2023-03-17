using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().Length == 0)
        {
            return "Fine. Be that way!";
        }
        
        if (statement.TrimEnd().EndsWith("?") && IsText(statement) && IsUpperCase(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        
        if (statement.TrimEnd().EndsWith("?"))
        {
            return "Sure.";
        }

        if (IsText(statement) && IsUpperCase(statement))
        {
            return "Whoa, chill out!";
        }
        
        return "Whatever.";
        
    }

    private static bool IsUpperCase(string text) => text == text.ToUpper();

    private static bool IsText(string text)
    {
        var pattern = @"[a-zA-Z]+";
        return Regex.IsMatch(text, pattern);
    }
}