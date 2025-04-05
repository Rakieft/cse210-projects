using System;

public class BreathingActivity : Activity
{
    protected override void PerformActivity()
    {
        int duration = GetDuration();
        int interval = 6; // 3 seconds in + 3 seconds out

        while (duration >= interval)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
            duration -= interval;
        }
    }
}