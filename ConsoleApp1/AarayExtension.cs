public static class ArrayExtension
{
    public class RequireClass<T> where T : class { }
    public static int CountElements<T>(this T[] arr, T elem) where T : struct
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (object.Equals(arr[i], elem))
            {
                count++;
            }
        }
        return count;
    }
    public static int CountElements<T>(this T[] arr, T elem, RequireClass<T> ignore = null) where T : class
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (object.Equals(arr[i], elem))
            {
                count++;
            }
        }
        return count;
    }

    public static T[] ArrayUnique<T>(this T[] arr) where T : struct
    {

        List<T> list = new List<T>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (list.IndexOf(arr[i]) == -1)
            {
                list.Add(arr[i]);
            }
        }
        T[] ArrUnique = new T[list.Count];
        for (int i = 0; i < ArrUnique.Length; i++)
        {
            ArrUnique[i] = list[i];
        }
        return ArrUnique;
    }
    public static T[] ArrayUnique<T>(this T[] arr, RequireClass<T> ignore = null) where T : class
    {

        List<T> list = new List<T>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (list.IndexOf(arr[i]) == -1)
            {
                list.Add(arr[i]);
            }
        }
        T[] ArrUnique = new T[list.Count];
        for (int i = 0; i < ArrUnique.Length; i++)
        {
            ArrUnique[i] = list[i];
        }
        return ArrUnique;
    }
}
 
