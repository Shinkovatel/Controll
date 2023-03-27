Console.Write("Введите слова или числa через запятую ',' : ");
String valueStr = Console.ReadLine(); // числа текстом
string[] values = valueStr.Split(","); // числа по отдельности

Console.WriteLine($"[{String.Join(";", values)}]");
string[] result = new string[values.Length];
for (int i = 0; i < values.Length; i++)
{
    if (values[i].Length < 4)
    {
       result[i] = values[i];
    }
   
}
result = result.Where(x => x != null).ToArray();


Console.WriteLine($"[{String.Join(";", result)}]");