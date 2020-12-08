using System;

namespace Shape
{
  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

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
  class Program 
  {
    static void Main()
    {
      Console.WriteLine("Enter side 1: ");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 2: ");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 3: ");
      int side3 = int.Parse(Console.ReadLine());

      Triangle triangle1 = new Triangle(side1, side2, side3);
      
      if (triangle1.IsTriangle(triangle1.Side1, triangle1.Side2, triangle1.Side3) == true)
      {
        Console.WriteLine("Yes, your values have created a triangle.");
        if (triangle1.IsEquilateral(triangle1.Side1, triangle1.Side2, triangle1.Side3) == true)
        {
          Console.WriteLine("Your Triangle is a special case, it is an Equilateral Triangle.");
        }
        else if (triangle1.IsIsosceles(triangle1.Side1, triangle1.Side2, triangle1.Side3) == true)
        {
          Console.WriteLine("Your Triangle is a special case, it is an Isosceles Triangle.");
        }
        else if (triangle1.IsScalene(triangle1.Side1, triangle1.Side2, triangle1.Side3) == true)
        {
          Console.WriteLine("Your Triangle is a special case, it is an Scalene Triangle.");
        }
      } 
      else
      {
          Console.WriteLine("Unfortunately, your values did not create a triangle.");
      }
    }
  }
}