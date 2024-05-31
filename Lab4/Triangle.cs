namespace Lab4;

public class Triangle : Figure
{
    public double A { get; set; }

    public double B { get; set; }
    
    public double C { get; set; }

    public override double CalculateArea()
    {
        double p = (A + B + C) / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
