using System;
using System.Collections.Generic;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    { //Verifying that the methods works

      Console.WriteLine(RectangleArea(4,5));
      Console.WriteLine(CircleArea(4));
      Console.WriteLine(TriangleArea(10,9));

      //Find the area of the floor plan. We’ll use an adapted version of the ancient city in Mexico: Teotihuacan
      double globalArea = RectangleArea(2500,1500) + 0.5 * CircleArea(375) + TriangleArea(750, 500);

      double totalCost = globalArea * 180; // Mexican pesos

      Console.WriteLine($"The construction of the Teotihuacan should cost aproximately {Math.Round(totalCost, 2)} Mexican pesos.");

      //Make the entire program a method so that you can execute it in your Main() method with one line:
      List<List<double>> measureRectangle = new List<List<double>>();
      measureRectangle.Add(new List<double> {90.5-48, 90.5-48});
      measureRectangle.Add(new List<double> {90.5-48, 24});
      measureRectangle.Add(new List<double> {90.5-48, 24});
      measureRectangle.Add(new List<double> {90.5-48, 24});
      measureRectangle.Add(new List<double> {90.5-48, 24});

      List<List<double>> measureTriangle = new List<List<double>>() ;
      measureTriangle.Add(new List<double> {24, 24});
      measureTriangle.Add(new List<double> {24, 24});
      measureTriangle.Add(new List<double> {24, 24});
      measureTriangle.Add(new List<double> {24, 24});

      Console.WriteLine(AreaCost(
        "Taj Mahal",
        numberRectangle: 5,
        numberTriangle: 4,
        rectangleMeasure: measureRectangle,
        triangleMeasure: measureTriangle
      ));
    }

    static double RectangleArea(double length, double width){
      return length*width;
    }

    static double CircleArea(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }
    
    static double TriangleArea(double bottom, double height){
      return 0.5 * bottom * height;
    }

    static string AreaCost(
      string name,
      int numberRectangle = 0,
      int numberCircle = 0,
      int numberTriangle = 0,
      List<List<double>>? rectangleMeasure = null,
      List<double>? circleMeasure = null,
      List<List<double>>? triangleMeasure = null
    ){
      double area = 0;

      //add all rectangles area
      for (int i=0; i<numberRectangle; i++){
        area = area + RectangleArea(rectangleMeasure[i][0],rectangleMeasure[i][1]);
      };

      //add all circles area
      for (int i=0; i<numberCircle; i++){
        area = area + CircleArea(circleMeasure[i]);
      };

      //add all triangles area
      for (int i=0; i<numberCircle; i++){
        area = area + TriangleArea(triangleMeasure[i][0],triangleMeasure[i][1]);
      };
      Console.WriteLine(area);
      double AreaCost = Math.Round(area * 180, 2);

      return $"The construction of the {name} should cost aproximately {AreaCost, 2} Mexican pesos.";

    }
  }
}