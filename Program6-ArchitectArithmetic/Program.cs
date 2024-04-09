using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {       
      CalculateTotalCost();
    }

    static void CalculateTotalCost(){
        double totalArea = 0.5*circle(375) + triangles(750,500)+ rectangle(2500,1500);
        double totalCost = Math.Round(totalArea) * 180;
        
        Console.WriteLine("What monument would you like to work with? Teotihuacan");
        Console.WriteLine($"The plan for that monument costs {totalCost} pesos!");

    }
     static double circle(double radius){ 
    double pi = Math.PI; 
    double area = pi * radius*radius;
    return area;   
    }

    static double triangles(double bottom, double height){
        
        double area = 0.5 * bottom * height;
        return area;         
        
    }

    static double rectangle(double length,double width){    
        double area = length * width;
        return area;
        
    }

  }

 
}


