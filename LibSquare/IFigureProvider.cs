namespace LibSquare;

public interface IFigureProvider
{
    public double CalculateSquare(object figure);
}

public interface IFigureProvider<TFigure> : IFigureProvider
{
    /// <summary>
    /// Считает площадь для <see cref="TFigure"/>
    /// </summary>
    /// <param name="figure">Объект фигуры</param>
    /// <returns>Посчитанную площадь</returns>
    public double CalculateSquare(TFigure figure);
}
