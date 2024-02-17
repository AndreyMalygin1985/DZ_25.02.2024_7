// Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне.
// Если границы диапазона указаны неправильно требуется произвести нормализацию границ.
// Например, пользователь ввел 20 и 11, требуется нормализация,
// после которой начало диапазона станет равно 11, а конец 20.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два числа для определения диапазона:");

        Console.Write("Первое число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        int number2 = int.Parse(Console.ReadLine());

        // Проверка и нормализация границ диапазона
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        Console.WriteLine($"Нормализованный диапазон: [{start}, {end}]");

        Console.WriteLine("Четные числа в указанном диапазоне:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}