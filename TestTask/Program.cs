/* Задание:
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
если вы выделяете ее в отдельный метод)
3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленую задачу 
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быь так,
что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры :
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] initialArray = new string[size]; //пользователь заполняет массив заданным кол-вом элементов  - переменная [size]  
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    string element = Convert.ToString(Console.ReadLine());
    initialArray[i] = element;
}

string[] resultingArray = new string[size]; //формируется итоговый массив перебором исходного массива
int lim = 3; //предельная длина элемента для формирования нового массива
int count = 0; //дополнительный счётчик
for (int j = 0; j < size; j++)
{
    if (initialArray[j].Length <= lim)
    {
        resultingArray[count] = initialArray[j];
        count++;
    }
}
Console.WriteLine($"\n Задан массив: ");
Console.Write("[ ");
PrintArray(initialArray);
Console.WriteLine("]");
Console.WriteLine($"\n Из заданного массива сформирован массив элементов с длиной равной 3 или менее символам: ");
Console.Write("[ ");
PrintArray(resultingArray);
Console.WriteLine("]");

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
