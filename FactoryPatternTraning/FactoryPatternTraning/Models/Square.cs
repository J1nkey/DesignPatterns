using FactoryPatternTraning.Abstracts;

namespace FactoryPatternTraning.Models
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
