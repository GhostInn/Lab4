namespace Lab4;

public class Program
{
    public static void Main(string[] args)
    {
        List<Figure> figures = new List<Figure>();

        figures.Add(new Triangle() { A = 3, B = 4, C = 5 });

        figures.Add(new Rectangle() { A = 2, B = 5 });

        figures.Add(new Triangle() { A = 6, B = 8, C = 10 });

        figures.Add(new Rectangle() { A = 4, B = 6 });

        figures.Add(new Triangle() { A = 9, B = 12, C = 15 });

        var query = 
            from figure
                in figures
            group figure
                by figure.GetType();

        var result = query.ToList();

        Console.WriteLine("Суммарная площадь треугольников: " + result[0].Sum(x => x.CalculateArea()));

        Console.WriteLine("Суммарная площадь прямоугольников: " + result[1].Sum(x => x.CalculateArea()));
    }
}

