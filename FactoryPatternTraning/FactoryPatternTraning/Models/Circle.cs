using FactoryPatternTraning.Abstracts;

namespace FactoryPatternTraning.Models
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
