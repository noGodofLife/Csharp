//файл class\array.cs

class array
{
    public static int[] selectA( int[] baseArray, int N )
    {
        //функция возвращает массив типа int
        //N количество элементов выборки

        int i; int[] selectArray = new int[N + 1]; int Ls = N + 1;
        for (i = 0; i < Ls; i++) selectArray[i] = 0;//обнуление
        int L = baseArray.Length;
        for (i = 0; i < L; i++) ++selectArray[baseArray[i]];//расчет частот
        return selectArray;
    }

    public static void sort( int[] bArray, char Mark)
    {
        //сортировка массива
        int L = bArray.Length, i, j, m;
        for (i = 0; i < L - 1; i++)
        {
            m = 0;
            for (j=i+1;j< L; j++)
            {
                if (Mark == 'd')
                { if (bArray[j] > bArray[i])
                    {
                        math.swap(ref bArray[j], ref bArray[i]);m++;//down
                    }
                }
                else
                {
                    if (bArray[j] < bArray[i])
                    {
                        math.swap(ref bArray[j], ref bArray[i]);m++;//up
                    }
                }
            }
            if (m == 0) break;
        }
        
    }
}