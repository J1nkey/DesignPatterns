using AbstractFactoryPattern.Abstracts;
namespace AbstractFactoryPattern.Models
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is draw method in circle");
        }
    }
}
