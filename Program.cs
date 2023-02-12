string[] inputArray = {"hello", "2", "world", "1234", "-2", "ds"};
int lengthLimit = 3;
int i = 0, j = 0;
while (i < inputArray.Length)
{
    if (inputArray[i].Length <= lengthLimit) j++;
    i++;
}

string[] resultArray = new string[j];

i = 0;
j = 0;
while (i < inputArray.Length)
{
    if (inputArray[i].Length <= lengthLimit)
    {
        resultArray[j] = inputArray[i];
        j++;
    }
    i++;
}

if (resultArray.Length > 0)
{
    Console.WriteLine($"[\"{String.Join("\", \"", resultArray)}\"]");
} else {
    Console.WriteLine("[]");
}
