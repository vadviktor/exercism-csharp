using System;

class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int actual_minutes)
    {
        return ExpectedMinutesInOven() - actual_minutes;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int minutes_in_oven)
    {
        return PreparationTimeInMinutes(layers) + minutes_in_oven;
    }
}
