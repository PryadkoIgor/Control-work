
string? yesNo = "";
while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
  Console.Write("Введите строки массива (yes/no): ");
  yesNo = Console.ReadLine();
}
string[] arrayOnStrings = new string[] {};

if (yesNo.ToLower() == "yes") {
  int n = InputNumbers("Введите количество элементов массива: ");
  arrayOnStrings = new string[n];
  for (int i = 0; i < arrayOnStrings.Length; i++)
  {
    Console.Write($" Введите {i+1} строку: ");
    arrayOnStrings[i] = Console.ReadLine();
  }
}
else
{
    arrayOnStrings = new string[] {"hello", "2", "world", ":)"};
}
int lengthLimit = 3;

int numbersItems = CheckArray(arrayOnStrings, lengthLimit);
string[] newArrayOfStrings = new string[numbersItems];
FillNewArray(arrayOnStrings, newArrayOfStrings, lengthLimit);
Console.WriteLine($"{PrintArray(newArrayOfStrings)}");

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int temp = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
}
int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
