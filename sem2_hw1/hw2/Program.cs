// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// вариант 1

// Console.WriteLine("введите число: ");
// num = Convert.ToInt32(Console.ReadLine());
//num1 = num1(num);
// if (num1 > 3){
//    num = num/Convert.ToInt32(Math.Pow(10, num1 - 3));
// }
// num = num%10;
// Console.WriteLine($"третья цифра числа {num}");

//вариант 2 (показали вначале урока, не работает)

// Console.WriteLine("введите число: ");
// string s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(s[s.Length - 3].ToString());

// вариант 3, сначала алгоритм сделать, потом перевести в С#, все равно не работает

// int ReadInt(string найти третью цифру){

// int number = WriteLine("Введите число: ");
// return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b);
// {
//    int result = 0;
//    if(b<3)
//    {
//        Console.Write("Третьей цифры нет: ");
//    }
//    else
//    {
//        int c = 1;
//        for (int i = b; i > 3; i++){
//            c = c * 10;
//        }
//        result = (a / c) % 10;
//    }
//    return result;
//}

using static System.Console;

//Console.WriteLine("введите число: ");
//string s = Console.ReadLine();
//Console.WriteLine(s[2].ToString());

int ReadInt(string message)
{
    WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int CheckThirdNumber(int n)
{
    if (n < 100)
    {
        return -1;
    }
    for (int i = 10; n > 999;)
    {
        n /= i;
    }
    return n;
}
int n = ReadInt("Введите число");
int answer = CheckThirdNumber(n);
WriteLine(answer % 10);