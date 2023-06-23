namespace LibSquare;

public class DictionaryFigureContext : IFigureContext
{
    private Dictionary<Type, IFigureProvider> providers = new();

    public void Set<TProvider, TFigure>() where TProvider : IFigureProvider<TFigure>
    {
        var provider = Activator.CreateInstance(typeof(TProvider));
        providers[typeof(TFigure)] = (provider as IFigureProvider<TFigure>)!;
    }

    public IFigureProvider? Get<TFigure>() => providers.TryGetValue(typeof(TFigure), out var provider) ? provider : null;

    public double? CalculateSquare<TFigure>(TFigure figure)
    {
        ArgumentNullException.ThrowIfNull(figure, nameof(figure));
        return Get<TFigure>()?.CalculateSquare(figure);
    }
}
