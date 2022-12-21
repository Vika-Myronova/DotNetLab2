
public static class StringExtension
{
    public static string StringInvesion(this string str)
    {
        string res = null;
        foreach (char symbol in str)
        {
            res = symbol + res;
        }
        if (res!=null)
            return res;
        return "There is nothing to invert!";
    }
    public static int WordCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }


}

