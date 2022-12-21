Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("1.1.Введіть рядок:");
string s = Console.ReadLine();
string res = s.StringInvesion();
Console.WriteLine($"String Invesion: {res}");

string s1 = "Hello, world!";
char c = 'l';
int count = s1.WordCount(c);
Console.WriteLine($"1.2.Кількість входжень {c} в рядку {s1} = {count}");


int[] arr = new int[] {1, 2, 3, 4, 5, 2, 4, 5, 2, 6};
int count2 = arr.CountElements<int>(2);
Console.WriteLine($"Count of '2' elements in arr<int> = {count2}");

string[] arr2 = new string[] { "hello", "world", "word", "li", "word" };
int count3 = arr2.CountElements<string>("word");
Console.WriteLine($"Count of 'word' elements in arr2<string> = {count3}");

char[] arr3 = new char[] {'a', 'a', 'b', 'c', 'd', 'e', 'b', 'b', 'e', 'b'};
int count4 = arr3.CountElements<char>('b');
Console.WriteLine($"Count of 'b' elements in arr3<char> = {count4}");


Console.WriteLine($"\nArray: ");
foreach (string el in arr2)
    Console.WriteLine(el);

Console.WriteLine("\nUnique Array:");
string[] arrayUnique = arr2.ArrayUnique<string>();
foreach (string el in arrayUnique)
    Console.WriteLine(el);

