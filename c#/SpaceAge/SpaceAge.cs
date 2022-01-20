using System;

public class SpaceAge
{
    private const double EARTH_YEAR_IN_SECONDS = 31557600;
    private readonly int seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return seconds / EARTH_YEAR_IN_SECONDS;
    }

    public double OnMercury()
    {
        return OnEarth() / Years.Mercury;
    }

    public double OnVenus()
    {
        return OnEarth() / Years.Venus;
    }

    public double OnMars()
    {
        return OnEarth() / Years.Mars;
    }

    public double OnJupiter()
    {
        return OnEarth() / Years.Jupiter;
    }

    public double OnSaturn()
    {
        return OnEarth() / Years.Saturn;
    }

    public double OnUranus()
    {
        return OnEarth() / Years.Uranus;
    }

    public double OnNeptune()
    {
        return OnEarth() / Years.Neptune;
    }
}

static class Years {
    public static double Mercury = 0.2408467;
    public static double Venus = 0.61519726;
    public static double Mars = 1.8808158;
    public static double Jupiter = 11.862615;
    public static double Saturn = 29.447498;
    public static double Uranus = 84.016846;
    public static double Neptune = 164.79132;
}