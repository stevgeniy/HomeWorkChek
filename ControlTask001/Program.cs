string[] arrayA = GetArrayMain("Введите длину первого массива: ");
//string[] arrayA =  {"techno", "by", "programma", "123hello", "Yes"};
int countA = CountString(arrayA);
string[] resultA =  GetResultArray(arrayA,countA);

string[] arrayB = GetArrayMain("Введите длину второго массива: ");
//string[] arrayB = {"23", "Hi", "-4", "sun", "tom"};
int countB  = CountString(arrayB);
string[] resultB = GetResultArray(arrayB,countB);

string[] arrayC = GetArrayMain("Введите длину  третьего массива: ");
//string[] arrayC = {"number", "lux", "chek", "Ru"};
int countC = CountString(arrayC);
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

int CountString(string[] array)
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

string[] GetArrayMain(string message)
        {
            Console.Write(message);
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strs[i]);
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();
            return strs;
        }

PrintArray(resultA);
PrintArray(resultB);
PrintArray(resultC);