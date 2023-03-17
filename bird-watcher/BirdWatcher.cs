using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return this.birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return this.birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return this.birdsPerDay.Count(p => p >= 5);
    }
}
