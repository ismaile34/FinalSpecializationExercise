void Check3Symbols(string[] array)
{
    var NewArray = new string[array.Length];
    var i = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3 && value.Length != 0)
        {
            NewArray[i] = value;
            i++;
        }
    }
    Console.WriteLine("Отсортированный массив:");
    Console.WriteLine(string.Join(Environment.NewLine, NewArray, 0, i));
}

string[] array;
Console.WriteLine("Введите массив строк через пробел > ");
string line = Console.ReadLine();
array = line.Split(' ');
Check3Symbols(array);