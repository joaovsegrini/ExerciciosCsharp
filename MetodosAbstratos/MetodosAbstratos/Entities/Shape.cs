using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
