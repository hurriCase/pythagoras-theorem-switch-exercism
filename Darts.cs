using System;

public static class Darts
{
    public static int Score(double x, double y) =>
    Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) switch
        {
            > 10 => 0,
            (<= 10 and > 5) => 1,
            (<= 5 and > 1) => 5,
            <= 1 => 10,
            _ => throw new ArgumentException()
        };
    
}
