using System;

public class UnixEpochClock
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2021, 1, 1, 2, 7, 2, 285);
        Console.WriteLine(date.ToString("r"));

        var epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
        var unixTicks = new TimeSpan(date.Ticks) - epochTicks;
        var unixTimestamp = (Int64)unixTicks.TotalSeconds;
        Console.WriteLine(unixTimestamp);
        Console.WriteLine("HEX: {0}", unixTimestamp.ToString("X"));
        Console.WriteLine("IN MILLISECONDS: {0}", (Int64)unixTicks.TotalMilliseconds);
    }
}