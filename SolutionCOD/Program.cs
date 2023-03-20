string[] arrayOne = new string[4] {"git", "20", "programmer", "tester"};
string[] arrayTwo = new string[arrayOne.Length];
void VerificationMethod(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
VerificationMethod(arrayOne, arrayTwo);
PrintArray(arrayTwo);