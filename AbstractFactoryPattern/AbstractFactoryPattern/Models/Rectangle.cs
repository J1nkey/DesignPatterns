using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is draw method in rectangle");
        }
    }
}
