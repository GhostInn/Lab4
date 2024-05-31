namespace Lab4;

public class Rectangle : Figure
{
    public double A { get; set; }

    public double B { get; set; }

    public override double CalculateArea()
    {
        return A * B;
    }
}
