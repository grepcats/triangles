namespace Triangles.Models
{
  public class TriangleType
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public string Type()
    {
      if (Side1 + Side2 < Side3 || Side1 + Side3 < Side2 || Side2 + Side3 < Side1)
      {
        return "not a triangle";
      }
      else if (Side1 == Side2 && Side1 == Side3)
      {
        return "equilateral";
      }
      else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
      {
        return "isosceles";
      }
      else
      {
        return "scalene";
      }
    }
  }
}
