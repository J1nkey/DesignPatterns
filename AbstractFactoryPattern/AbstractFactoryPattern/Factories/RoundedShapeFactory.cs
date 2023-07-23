using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType.ToLower().Equals("rectangle"))
            {
                return new RoundedRectangle();
            }

            // return null or throw an exeption
            return null;
        }
    }
}
