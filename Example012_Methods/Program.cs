// Виды методов: 


// Вид 1 - Аргументов не принимает, ничего не возвращает (void метод)
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();


// Вид 2 - Принимает аргументы, ничего не возвращает (void метод)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");  // не указывая в какой аргумент передаются данные
// Method2(msg: "Текст сообщения"); // указываем наименование аргумента в который передаем данные

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);  // не указывая в какие аргументы передаются данные
// Method21(msg: "Текст", count: 4);  // указываем наименования аргументов в которые передаем данные
// Method21(count: 4, msg: "Новый текст");  // при указании именованных аргументов порядок не важен


// Вид 3 - Аргументы не принимает, что-то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);


// Вид 4 - Принимает аргументы - что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // инициализируем переменную result как пустую строку

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

// Вариант метода с циклом for 

string Method41(int count, string text)
{

    string result = String.Empty;  // инициализируем переменную result как пустую строку

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method41(10, "qwerty");
// Console.WriteLine(res);


// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// //=====Работа с текстом
// // Дан текст. В тексте нужно все пробелы заменить чёрточками,
// // маленькие буквы "к" заменить большими "К",
// // а большие "С" маленькими "с".
// // Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string = s = "qwerty"
// //               012345
// // s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'е', 'Е');
// Console.WriteLine(newText);
// Console.WriteLine();


// Работа с массивом
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSortUpscale(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


void SelectionSortDownscale(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortUpscale(arr);
PrintArray(arr);
SelectionSortDownscale(arr);
PrintArray(arr);