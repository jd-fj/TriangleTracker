using System;

namespace Shape
{
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