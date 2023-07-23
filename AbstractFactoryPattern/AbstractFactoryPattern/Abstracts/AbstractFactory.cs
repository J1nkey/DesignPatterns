namespace AbstractFactoryPattern.Abstracts
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
    }
}
