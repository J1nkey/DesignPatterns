using FactoryPatternTraning.Abstracts;

namespace FactoryPatternTraning.Models
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
