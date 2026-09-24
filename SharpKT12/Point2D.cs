using SharpKT12;

namespace StructsAndEnums_Point2D
{
    public struct Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Quadrant GetQuadrant()
        {
            if (X > 0 && Y > 0)
            {
                return Quadrant.First;
            }
            if (X < 0 && Y > 0)
            {
                return Quadrant.Second;
            }
            if (X < 0 && Y < 0)
            {
                return Quadrant.Third;
            }

            return Quadrant.Fourth;
        }

        public override string ToString()
        {
            return $"Point2D {{ X = {X}, Y = {Y} }} -> Четверть: {GetQuadrant()}";
        }
    }
}