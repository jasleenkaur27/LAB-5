using System;

class Circle
{
    private double radius;

    public void SetRadius(double r)
    {
        if (r > 0)
        {
            radius = r;
        }
        else
        {
            throw new InvalidRadiusException(r);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius: {radius}";
    }
}

class InvalidRadiusException : Exception
{
    public InvalidRadiusException()
        : base("Invalid radius. Radius must be greater than zero.")
    {
    }

    public InvalidRadiusException(double invalidRadius)
        : base($"Invalid radius: {invalidRadius}. Radius must be greater than zero.")
    {
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            // Test with positive radius
            Circle circle1 = new Circle();
            circle1.SetRadius(5.0);
            Console.WriteLine(circle1);

            // Test with negative radius
            Circle circle2 = new Circle();
            circle2.SetRadius(-2.0);

            // Test with radius of zero
            Circle circle3 = new Circle();
            circle3.SetRadius(0.0);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}

