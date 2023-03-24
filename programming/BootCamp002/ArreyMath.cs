public static class ArreyMath
{
    public static int BadGetSum(this int[] arrey, int m = 3)
    {
        int max = 0;

        int size = arrey.Length;

        for (int i = 0; i <= size - m; i++)
        {
            int t = 0;
            for (int j = i; j < i + m; j++)
            {
                t += arrey[j];
            }
            if (t > max) max = t;
        }
        return max;
    }

    public static int GoodGetSum(this int[] arrey, int m = 3)
    {
        int max = 0;
        int size = arrey.Length;

        for (int i = 0; i < m; i++) max += arrey[i];
        int t = max;
        //Console.WriteLine($"i: {0} t: {t}");

        for (int i = 1; i <= size - m; i++)
        {
            t = t - arrey[i - 1] + arrey[i + m - 1];
            //Console.WriteLine($"i: {i} t: {t}");
            if (t > max) max = t;
        }
        return max;
    }
}