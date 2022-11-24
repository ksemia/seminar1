// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//variant 1

//int [] array = new int[5];
//Console.Write("[");

//for (int i = 0; i < array.Length; i++){
//    array [i] = [1, 2, 5, 7, 19];
//    Console.Write(" " + Method (i) + " ");
//}
//Console.Write("]");

//int Method (int a){
//    return array[a];
//}

//variant 2

//void Main(string[] args){
//    int i;
//    int[] a = new int[10];
//    Console.WriteLine("Введите числа: ");

//    for (i = 0; i < 10; i++){
//        a[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    for (i = 0; i < 10; i++){
//        Console.WriteLine($"a[i]");
//    }
//}

//variant 3 - РАБОТАЕТ
//понимаю как сделать для конкретного (как в лекции), как универсальный код - не поняла
//int[] array = {1, 2, 5, 7, 19};
//void PrintArray(int[]array)
//{
//    int count = array.Length;
    
//    for(int i = 0; i < count; i++)
//    {
//    Console.WriteLine($"{array[i]} ");
//    }
//    Console.WriteLine();
//}
//PrintArray(array);

//variant 4 - universal
int[] array = {n};
void PrintArray(int[]array)
{
    int n = array.Length;
    
    for(int i = 0; i < n; i++)
    {
    Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array(n);