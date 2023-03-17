using System;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        return Regex.Replace(logLine, @"(\[[a-zA-Z]+\]:\s)", String.Empty).Trim();
    }

    public static string LogLevel(string logLine)
    {
        Match match = Regex.Match(logLine, @"\[(?<ErrorLevel>\w+)\]");
        if (match.Success)
            return match.Groups["ErrorLevel"].Value.ToLower();

        return "";
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
