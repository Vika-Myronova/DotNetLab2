using ClassLibrary1;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

ExtendedDictionary<int, string, string> dict = new ExtendedDictionary<int, string, string>();

dict.Add(1, "Anastasia", "Korolkova");
dict.Add(2, "Maria", "Kobylezka");
dict.Add(3, "Lykyanchuck", "Vitaliy");
dict.Add(4, "Tetiana", "Petrova");
dict.Add(5, "Oleksiy", "Tykmakov");

dict.Print();
Console.WriteLine("\nВидалення 5-го елемента списку");
dict.Remove(5);
dict.Print();
Console.WriteLine("\nперевірка існування ключа 4");
dict.isExistKey(4);

Console.WriteLine($"\nКількість елеметів списку = {dict.Count()}");
Console.WriteLine("Пошук ключа зі значеннями ('Maria', 'Kobylezka')");
dict.ExistValues("Maria", "Kobylezka");
dict.ExistValues("sffs", "sfffgg");
Console.WriteLine("\nЗначення по індексу:");
Console.WriteLine($"dict[3] = {dict[3].value1} , {dict[3].value2}");
Console.WriteLine("Виведдення через foreach:");
foreach (var i in dict)
    Console.WriteLine($"{i.key} , {i.value1} => {i.value2}");














