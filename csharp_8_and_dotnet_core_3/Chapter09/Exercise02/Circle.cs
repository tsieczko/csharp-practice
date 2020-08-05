using System;

namespace Exercise02
{
	public class Circle : Shape
	{
        public double Radius { get; set; }

        public Circle() {}

		public Circle(double Radius)
		{
            this.Radius = Radius;
            this.Height = Radius * 2;
            this.Width = Radius * 2;
		}

        public override double Area
        {
            get => Math.PI * Math.Pow(Radius, 2.0);
        }
	}
}
