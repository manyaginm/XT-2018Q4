using System;

namespace GraphicsEditor
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape[] arr = new Shape[0];
            int k;
            while (true) {
                Console.WriteLine("Insert shape nuber: " +
                    "\n 1 - Line" +"\n 2 - Round" + "\n 3 - Square" + "\n 4 - Circle" + "\n 5 - Ring");
                k = int.Parse(Console.ReadLine());
                Shape s = createShape(k);
                addFigure(ref arr, s);
                foreach (Shape t in arr)
                {   
                    t.printShape();
                }
                Console.WriteLine();
            }
        }

        public static void addFigure(ref Shape[] arr, Shape s)
        {
            Shape[] arr1 = new Shape[arr.Length + 1];
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr1[i] = arr[i];
                }
                arr1[arr.Length] = s;
            }
            else { arr1[0] = s; }
            arr = arr1;

        }

        static Shape createShape(int k) {
            int x;
            int y;
            switch (k)
            {
                case 1:
                    Console.WriteLine("Isert start point for line");
                     x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert end point for line");
                     y = int.Parse(Console.ReadLine());
                    return new Line(x, y);
                case 2:
                    Console.WriteLine("Isert coordinate x for round");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert coordinate y for round");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert radius for round");
                    int radius = int.Parse(Console.ReadLine());
                    return new Round(x, y, radius);
                case 3:
                    Console.WriteLine("Isert coordinate x for center of square");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert coordinate y for center of square");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert a side for square");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert b side for square");
                    int b = int.Parse(Console.ReadLine());
                    return new Square(a, b, x, y);
                case 4:
                    Console.WriteLine("Isert coordinate x for circle");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert coordinate y for circle");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Isert a side for square");
                    int circleRadius = int.Parse(Console.ReadLine());                  
                    return new Circle(x, y, circleRadius);
                case 5:
                    Console.WriteLine("Enter coordinates by x-line");
                     x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter coordinates by y-line ");
                     y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter radius for inner circle");
                    int innerRadius = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter radius for outer circle");
                    int outerRadius = int.Parse(Console.ReadLine());
                    return new Ring(new Round(x, y, outerRadius), new Round(x, y, innerRadius));

            }
            return null;
            
        }


        }
      
    }


    
