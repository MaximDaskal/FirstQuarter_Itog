// Рекурсивная функция
void funrec(int k, int n, ref string [] arrOrig, ref string [] arrFin)
{
    if(k<arrOrig.Length)
    {
        if(arrOrig[k].Length <= 3 )
        {
            funrec(k+1, n+1, ref arrOrig, ref arrFin);
            arrFin[n]=arrOrig[k];
        }
        else 
        funrec(k+1, n, ref arrOrig, ref arrFin);
    
    }
    else if(n>0)
    {
        Array.Resize(ref arrFin, n);     
    }
    else 
    Console.WriteLine("В исходном массиве отсутсвует строка с количеством символов менее или равно трём");
}


//Функция вывода элементов масива на экран
void ShowArray(ref string [] array,  string str)
{
    Console.Write(str);
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine("\b\b ");
}


//Текст программы
// Создаём первоначальный массив
string [] origArray;
origArray = new string [] {"hello", "2", "world", ":-)", "popiroska", "3d"}; // Этот первоначальный массив в котором есть эленты с тремя или менее  символами.
//origArray = new string [] {"Russia", "Denmark", "Kazan"}; // Этот первоначальный массив в котором нет элентов с тремя или менее  символами. Оставлю тут для удобства тестирования

//Выводим первоначальный массив на экран
ShowArray(ref origArray, "Ваш первоначальный массив:\n");

string [] newArray = new string [0];// Новый массив для строк длинной 3 символа и менее
funrec(0, 0, ref origArray, ref newArray);

//Выводим новый массив на экран если есть хотябы один элемент с количеством символов равным 3 и менее
if(newArray.Length>0)
{
    ShowArray(ref newArray, "Ваш новый массив:\n");
}
else 
Console.WriteLine("Новый масив не создан.");



