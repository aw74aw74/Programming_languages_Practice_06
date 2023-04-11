//---------------------ЗАДАЧА---------------------
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//---------------------РЕШЕНИЕ---------------------
int[] ConvertArray(string[] str)
{
  int[] res = new int[str.Length];
  for (int i = 0; i < str.Length; i++)
  {
    res[i] = int.Parse(str[i]);
  }
  return res;
}

int PosNumb(int[] col)
{
  int res = 0;
  for (int i = 0; i < col.Length; i++)
  {
    if (col[i] > 0) res++;
  }
  return res;
}

Console.WriteLine("Введите через пробел числа: ");
string[] st = Console.ReadLine()!.Split(' ');
Console.WriteLine($"Количество чисел больше 0 равно {PosNumb(ConvertArray(st))}");