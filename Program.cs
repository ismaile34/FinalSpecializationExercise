string[] array;
Console.WriteLine("Введите массив строк через пробел > ");
string line = Console.ReadLine();
array = line.Split(' ');
Check3Symbols(array);