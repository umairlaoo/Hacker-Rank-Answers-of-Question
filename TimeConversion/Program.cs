using System;

class Program
{
    static void Main()
    {
        string inputTime = "07:05:45PM";
        string outputTime = ConvertTo24HourFormat(inputTime);
        Console.WriteLine(outputTime);
    }

    static string ConvertTo24HourFormat(string inputTime)
    {
        string timeSuffix = inputTime.Substring(inputTime.Length - 2);
        string timeWithoutSuffix = inputTime.Substring(0, inputTime.Length - 2);

        int hour = int.Parse(timeWithoutSuffix.Split(':')[0]);
        int minute = int.Parse(timeWithoutSuffix.Split(':')[1]);
        int second = int.Parse(timeWithoutSuffix.Split(':')[2]);

        if (timeSuffix.Equals("PM", StringComparison.OrdinalIgnoreCase) && hour != 12)
        {
            hour += 12;
        }
        else if (timeSuffix.Equals("AM", StringComparison.OrdinalIgnoreCase) && hour == 12)
        {
            hour = 0;
        }

        return $"{hour:D2}:{minute:D2}:{second:D2}";
    }
}
