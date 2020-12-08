namespace Shape
{
  public class Triangle
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      return (side1 <= (side2 + side3)) && (side2 <= (side1 + side3)) && (side3 <= (side1 + side2)); 
    }
    public bool IsEquilateral(int side1, int side2, int side3)
    {
      return side1 == side2 && side1 == side3;
    }
    public bool IsIsosceles(int side1, int side2, int side3)
    {
      return side1 == side2 || side2 == side3 || side1 == side3;
    }
    public bool IsScalene(int side1, int side2, int side3)
    {
      return side1 != side2 && side1 != side3 && side2 != side3;
    }
  }
}