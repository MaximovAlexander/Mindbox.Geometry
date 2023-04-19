namespace Mindbox.Geometry;

public class Triangle
{
    public static bool IsRightTriangle(double a, double b, double c)
    {
        if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            return true;
        }

        if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
        {
            return true;
        }

        return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
    }
}