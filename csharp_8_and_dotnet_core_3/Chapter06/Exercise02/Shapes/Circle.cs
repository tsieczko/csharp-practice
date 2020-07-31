using System;

namespace Shapes
{
	public class Circle : Shape
	{
        public double Radius { get; set; }

		public Circle(double radius)
		{
            this.Radius = radius;
            this.Height = radius * 2;
            this.Width = radius * 2;
		}

        public override double Area
        {
            get => Math.PI * Math.Pow(Radius, 2.0);
        }
	}
}
