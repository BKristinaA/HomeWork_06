// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateFillArray()
{
    Console.Write("Введите четное число: ");
    int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void CountPositiveNumber(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество чисел больше 0 s" + count);
}
int[] arr = CreateFillArray();
CountPositiveNumber(arr);