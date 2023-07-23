using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class ShapeFactory : AbstractFactory
    {

        public override IShape GetShape(string shapeType)
        {
            if (shapeType.ToLower().Equals("rectangle"))
            {
                return new Rectangle();
            }

            if (shapeType.ToLower().Equals("square"))
            {
                return new Square();
            }

            if (shapeType.ToLower().Equals("circle"))
            {
                return new Circle();
            }

            // return null or throw an exception
            return null;
        }
    }
}
