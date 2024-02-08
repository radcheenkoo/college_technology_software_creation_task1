using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Програма для розв'язання квадратного рівняння ax^2 + bx + c = 0");

        
        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення c: ");
        double c = Convert.ToDouble(Console.ReadLine());

       
        SolveQuadraticEquation(a, b, c);

      
        Console.ReadLine();
    }

    static void SolveQuadraticEquation(double a, double b, double c)
    {
   
        double discriminant = b * b - 4 * a * c;

        Console.WriteLine($"Квадратне рівняння: {a}x^2 + {b}x + {c} = 0");
        Console.WriteLine($"Значення дискримінанту D: {discriminant}");

     
        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Розв'язки рівняння: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Рівняння має один корінь: x = {x}");
        }
        else
        {
            Console.WriteLine("Рівняння не має реальних коренів");
        }
    }
}
