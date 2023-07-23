using FactoryPatternTraning.Abstracts;
using FactoryPatternTraning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTraning.Factories
{
    /// <summary>
    /// A Factory for generating object of concrete class based on given information
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

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

            throw new InvalidDataException("Your type is invalid");
        }
    }
}
