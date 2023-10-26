using System;

/* BreathingActivity class */
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _nameActivity = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 10;
    }
    
    public string BreatheIn()
    {
        return "Breathe in..." + PauseCountdown();
    }

    
}