using System;

namespace Shapes
{
    public class Shape
    {
        public double Height
        { get; set; }
        public double Width
        { get; set; }
        public virtual double Area
        {
            get => throw new NotImplementedException();
        }

    }
}
