//файл class\tarabar.cs
//Кодирующая функция
class code
{
    public static string tarabar (string text)
    {
        //alphabet - ключевая строка
        //всего символов - 126
        //латиница - 0 - 51
        //знаки - 52 - 62
        //кириллица - 63 - 126
        string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz?!.,*/+-:\nАаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщъЫыьЭэЮюЯя";
        int L = text.Length;
        int La = alphabet.Length;
        char[] support = new char[L];
        for (int i=0;i<L;++i)
        {
            for (int j = 0; j <= La-1; j++)
            {
                if (text[i] == alphabet[j]) { support[i] = alphabet[La - 1 - j]; break; }
                else if (j == 126) support[i]=text[i];
            }
        }
        string s = new string(support);
        return s;

    }
}