using System;

public class UnixEpochClock
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2021, 1, 1, 2, 7, 2, 285);
        ShowUnix(date);
    }

    private static void ShowUnix(DateTime date)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(date.ToString("r"));
        Console.WriteLine();
        Console.ResetColor();

        var epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
        var unixTicks = new TimeSpan(date.Ticks) - epochTicks;
        var unixTimestamp = (Int64)unixTicks.TotalSeconds;
        Console.WriteLine(unixTimestamp);
        Console.WriteLine("HEX: {0}", unixTimestamp.ToString("X"));
        Console.WriteLine("IN MILLISECONDS: {0}", (Int64)unixTicks.TotalMilliseconds);
        Console.WriteLine();
    }
}