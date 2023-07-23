using AbstractFactoryPattern.Abstracts;
using System;

namespace AbstractFactoryPattern.Models
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is draw method in rounded rectangle");
        }
    }
}
