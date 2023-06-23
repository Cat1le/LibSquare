using LibSquare.Figures;
using LibSquare.Providers;

namespace LibSquare.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IFigureContext ctx = new DictionaryFigureContext();
            ctx.Set<CircleProvider, Circle>();
            var result = ctx.CalculateSquare(new Circle { Radius = 10 });
            Assert.Equal(Math.PI * Math.Pow(10, 2), result);
        }
    }
}