
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
              сколько чисел больше 0 ввёл пользователь.

              0, 7, 8, -2, -2 -> 2

              1, -7, 567, 89, 223-> 3 */
  

int ElementsPositive (int[] inputArray)
{
   int count = 0;
   for (int i = 0; i < inputArray.Length; i++)
   {
      if(inputArray[i]>0) count = count +1;
   }
   return count;
}

Console.WriteLine("Введи рандомные числа: ");
int[] numberArray  = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
Console.WriteLine($"Количество чисел больше нуля: {String.Join(" , ", ElementsPositive (numberArray))}");
