//файл class\math.cs
//функции 
//modf - расщепление числа не целую и дробную части
//swap - обмен значениями между аргументами

class math
{
    //number - исходная переменная
    //integer - целая часть
    //fraction - дробная часть
    public static double modf ( double number , out int integer )
    {
        integer = (int)number;
        return (number - (double)integer);
    }

    public static void swap ( ref int x , ref int y)
    {
        int t = x; x = y; y = t;
    }

    public static void swap(ref double x, ref double y)
    {
        double t = x; x = y; y = t;
    }

    public static void swap(ref char x, ref char y)
    {
        char t = x; x = y; y = t;
    }
}//конец math