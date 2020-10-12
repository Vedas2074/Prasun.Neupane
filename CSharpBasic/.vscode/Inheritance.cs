using System;
public abstract class Shape
{
    public abstract double GetArea();
    
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Printing detalis for shape..");
    }
}
public class Rectangle : Shape
{
    public Rectangle(double l, double b)
    {
        this.length = l;
        this.breadth = b;
    }
    public double length {get; set;}
    public double breadth {get; set;}
    public override double GetArea() => length * breadth;
    public override double GetPerimeter() => 2 * (length + breadth);
   
   public override void PrintDetails()
    {
        Console.WriteLine("Printing detalis for shape..");
        Console.WriteLine($"Length:{length}, Breadth:{breadth}");
        Console.WriteLine($"Area:{this.GetArea()}, Perimeter:{this.GetPerimeter()}");
    }
        
}
 
public class Sqaure : Rectangle
{
    public Square(double s) : base(s,s)
    {

    }
    // public double side {get; set;}
    // public override double GetArea() => side * side;
    // public override double GetPerimeter() => 4 * side;
   
        
}




public class Circle : Shape
{
    public Circle( double r)
    {
        Radius = r;
    }
    public double Radius {get; set;}
    public override double GetArea() => Math.PI *Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI* Radius;
   
        
}
//single inheritance
class A
{

}
class B:A
{

}
 
class C:B
{

}



