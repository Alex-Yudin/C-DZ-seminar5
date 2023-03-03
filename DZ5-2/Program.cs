// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GenerateArray(int length, int minValue, int maxValue)  // функция генерирует массив с заданными параметрами (длина, максимальное и 
// минимальное значение)
{
    int[] result = new int[length];   // создаем массива с длиной length
    Random rnd = new Random();   // Создание генератора случайных чисел
    for (int i = 0; i < result.Length; i++)   // цикл заполнения результирующего массива случайными числами из диапазона между minValue и maxValue
   // инициализируем i индекс для первого элемента массива. Пока этот индекс будет меньше длины массива, будем крутить цикл. В конце цикла увеличим i на один.
    {
        result[i] = rnd.Next(minValue, maxValue + 1); // присваиваем случайное число элементу массива
    }
    return result; // возвращаем массив из функции

}

void ShowArray(int[] array)  // вывод массива
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}

// int maxNumber = 0;
// while(number > 0)
// {
//     if(maxNumber < number % 10)
//     {
//         maxNumber = number % 10;
//     }
//     number /= 10;
// }

int ChetDigits(int[] array)
{
    int sum = 0;
   
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = 10;
int minValue = 1;
int maxValue = 5;
int [] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна (нечетный индекс массива) {ChetDigits(array)}");