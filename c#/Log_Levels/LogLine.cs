using System;
static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
    }
    public static string LogLevel(string logLine)
    {
        var level = logLine.Split(':')[0];
        return level.Substring(1, level.Length-2).ToLower();
    }
    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}