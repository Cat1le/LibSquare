namespace LibSquare;

public interface IFigureContext
{
    /// <summary>
    /// Добавляет класс провайдера в контейнер зависимостей
    /// </summary>
    /// <typeparam name="TProvider">Провайдер вычисления площади для фигуры</typeparam>
    void Set<TProvider, TFigure>() where TProvider : IFigureProvider<TFigure>;

    IFigureProvider? Get<TFigure>();

    /// <summary>
    /// Считает
    /// </summary>
    /// <param name="figure">Объект фигуры. Тип будет выяснен в рантайме</param>
    /// <returns>Если провайдер есть в контейнере, то он вернет посчитанную площадь. Иначе null</returns>
    double? CalculateSquare<TFigure>(TFigure figure);
}
