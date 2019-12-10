using System;

class Clock
{
    static void Main()
    {
        Console.WriteLine("Please enter the hour: ");
        int hour = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the minute: ");
        int minute = int.Parse(Console.ReadLine());
        angle(hour,minute);
    }

    static void angle(int hour, int minutes)
    {
        double angle = Math.Abs(0.5*(60*hour-11*minutes));
        if (angle>180)
        {
            double answer = 360-angle;
            Console.WriteLine("The shortest angle is: "+answer.ToString());
        }
        else
        {
            Console.WriteLine("The shortest angle is: " + angle.ToString());
        }
    }
}