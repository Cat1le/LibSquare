using LibSquare.Figures;

namespace LibSquare.Providers;

public class TriangleProvider : IFigureProvider<Triangle>
{
    public bool IsStraight(Triangle triangle)
    {
        Span<double> sides = stackalloc double[] { triangle.A, triangle.B, triangle.C };
        sides.Sort();
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    public double CalculateSquare(Triangle figure)
    {
        var p = (figure.A + figure.B + figure.C) / 2;
        return Math.Sqrt(p * (p - figure.A) * (p - figure.B) * (p - figure.C));
    }

    public double CalculateSquare(object figure) => CalculateSquare((Triangle)figure);
}

public class CircleProvider : IFigureProvider<Circle>
{
    public double CalculateSquare(Circle figure) => Math.PI * Math.Pow(figure.Radius, 2);

    public double CalculateSquare(object figure) => CalculateSquare((Circle)figure);
}
