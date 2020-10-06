﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Shapes;

namespace Lab2ITH2020.Program
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Shape3D volumeShape3D = null;
            float circumference = 0;
            double area = 0;
            float volume = 0;
            var triangle = new Triangle(new Vector2(3.0f, 4.0f), new Vector2(5.0f, 6.0f), new Vector2(8.0f, 3.0f));
            IEnumerable triangle1 = triangle;
            

            var shapeList = new List<Shape>(20);
            for (var i = 0; i < 20; i++) shapeList.Add(Shape.GenerateShape());

            foreach (var shape in shapeList) Console.WriteLine(shape);

            foreach (var shape in shapeList)
                if (shape is Triangle t)
                    circumference += t.Circumference;

            foreach (var t in shapeList)
                area += Convert.ToInt64(t.Area);
            
            foreach (var shape in shapeList)
            {
                if (shape is Shape3D s && volume < s.Volume)
                    volume = s.Volume;

                volumeShape3D = shape as Shape3D;
            }


            Console.WriteLine($"The average Area of all shapes in the list is {area / shapeList.Count:0.00}");
            Console.WriteLine($"The total of all circumference of all triangles in the list is {circumference:0.00}");
            if (volumeShape3D != null)
                Console.WriteLine(
                    $"The shape with the largest volume in the list is a {volumeShape3D.Name} with the volume {volume:0.00} and these parameters: \"{volumeShape3D}\"");
            else
                Console.WriteLine(
                    "We usually write out the volume of the biggest shape here but there were no 3D shapes created");
            Console.WriteLine("The points of the triangle are at these coordinates: ");
            foreach (var point in triangle1) Console.Write($" {point} ");
            
        }
    }
}