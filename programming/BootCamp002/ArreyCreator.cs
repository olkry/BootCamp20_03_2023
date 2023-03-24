/// <summary>
/// Это класс, отвечающий за создание массива
/// </summary>
public static class ArreyCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>новый массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Лепит массив в строку
    /// </summary>
    /// <param name="arrey">Массив</param>
    /// <returns>Строку с представлением массива</returns>
    public static string ConvertToStringAndPrintTerminal(this int[] arrey)
    {
        string str = $"[{String.Join(',', arrey)}]";
        Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Заполняет массив
    /// </summary>
    /// <param name="arrey">Массив</param>
    /// <param name="min">Нижняя граница диапозона генератора случайных чисел</param>
    /// <param name="max">Верхняя граница диапозона генератора случайных чисел</param>
    public static int[] Fill(this int[] arrey, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return arrey = arrey.Select(item => random.Next(min, max)).ToArray();
    }

}
