using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Models
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is draw method in Square");
        }
    }
}
