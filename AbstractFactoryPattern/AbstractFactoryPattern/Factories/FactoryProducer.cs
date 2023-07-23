using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Factories
{
    /// <summary>
    /// Producer factory that produces/generates factories by passing an information such as Shape
    /// </summary>
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded)
        {
            if (rounded == true)
            {
                return new RoundedShapeFactory();
            }

            return new ShapeFactory();
        }
    }
}
