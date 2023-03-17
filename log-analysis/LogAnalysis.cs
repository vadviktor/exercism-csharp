using System;
using System.Text.RegularExpressions;
public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string logLine, string separator)
    {
        return logLine.Split(separator)[1];
    }

    public static string SubstringBetween(this string logLine, string start, string end)
    {
        var pattern = $@"{Regex.Escape(start)}\s*(?<Substr>\w+)\s*{Regex.Escape(end)}";
        Match match = Regex.Match(logLine, pattern);
        return match.Success ? match.Groups["Substr"].Value : "";
    }

    public static string Message(this string logLine)
    {
        return Regex.Replace(logLine, @"(\[[a-zA-Z]+\]:\s)", String.Empty).Trim();
    }

    public static string LogLevel(this string logLine)
    {
        Match match = Regex.Match(logLine, @"\[(?<ErrorLevel>\w+)\]");
        if (match.Success)
            return match.Groups["ErrorLevel"].Value;

        return "";
    }
}
