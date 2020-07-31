namespace Shapes
{
    public class Square : Shape
    {
        public Square(double dimension)
        {
            this.Height = dimension;
            this.Width = dimension;
        }

        public override double Area
        {
            get => Height * Width;
        }
    }
}
