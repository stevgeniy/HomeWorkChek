string[] arrayA =  {"techno", "by", "programma", "123hello", "Yes"};
int countA = CountStringLessThreeChar(arrayA);
string[] resultA =  GetResultArray(arrayA,countA);


string[] arrayB = {"23", "Hi", "-4", "sun", "tom"};
int countB  = CountStringLessThreeChar(arrayB);
string[] resultB = GetResultArray(arrayB,countB);


string[] arrayC = {"number", "lux", "chek", "Ru"};
int countC = CountStringLessThreeChar(arrayC);
string[] resultC = GetResultArray(arrayC, countC);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int CountStringLessThreeChar(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] GetResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArray(resultA);
PrintArray(resultB);
PrintArray(resultC);