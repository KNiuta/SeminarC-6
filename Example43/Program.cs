/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
              заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
              b1, k1, b2 и k2 задаются пользователем.

                b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void IntersectionPoint (double k1, double k2, double b1, double b2)
 {
     double x = Math.Round((b1-b2)/(k2-k1),2);
     double y = Math.Round(k2*x+b2,2);
      if (k1!=k2)  Console.WriteLine($" Точка пересечения прямых y = {k1} * x + {b1}  y = {k2} * x + {b2} равна {(x,y)} ");
      else  Console. WriteLine("прямые паралельные");           
 }
 Console.Write(" k1 = ");
 double k1 = Convert.ToDouble(Console.ReadLine());

 Console.Write(" k2 = ");
 double k2 = Convert.ToDouble(Console.ReadLine());

 Console.Write(" b1 = :");
 double b1 = Convert.ToDouble(Console.ReadLine());

 Console.Write(" b2: = ");
 double b2 = Convert.ToDouble(Console.ReadLine());

 IntersectionPoint(k1,k2,b1,b2);