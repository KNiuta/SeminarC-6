/* Задача 42 : Напишите программу, которая будет преобразовывать десятичное число в двоичное.
                      45 -> 101101
                      3 -> 11
                      2 -> 10 */
double[] BinaryNumberSystem   (double number)
{
      double c = Math.Log(number,2);
      int size = Convert.ToInt32(Math.Truncate(c)+1);
      double[] outputArray =new double[size];
      for (int i = 0; i < size; i++)
      {
           outputArray[size-1-i]=number%2;
           number=Math.Truncate(number/2);   
      }
      return outputArray;
}                
 Console.Write(" Введи число для преобразования: ");
 double  numberDecimal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" {numberDecimal} -> {String.Join("",  BinaryNumberSystem(numberDecimal) )} ");
 