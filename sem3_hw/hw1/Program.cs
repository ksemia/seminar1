// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// варинт 1, выдает ошибку, где-то должен быть ToString?

// Console.WriteLine("Введите пятизначное число: ");
// string s = Console.ReadLine();
// int len = number.Length;
// int n = Convert.ToInt32(s);

// if (len == 5){
//     if (number [0] == number [4] && number[1] == number[3]){
//         Console.WriteLine($"{number} - Палиндром");
//    }
//    else
// {
//    Console.WriteLine($"{number} - НЕ палиндром");
// }
// }
// else{
//    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }
// Console.WriteLine(number.ToString());

// вариант 2

// Console.WriteLine("Введите пятизначное число: ");
// int n = Int.Parse(ReadLine());
// int len = number.Length;

// if(len == 5)
// {
//     if(int n [0] == int n [4] && int n[1] == int n[3])
//     {
//        Console.WriteLine("Да,Палиндром");
//     }
//}
//    else
//     {
//        Console.WriteLine("Нет, не Палиндром");
//     }


// вариант 3
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5){
    if (number [0] == number [4] && number[1] == number[3])
{
    Console.WriteLine($"{number} - Палиндром");
}
else{
    Console.WriteLine($"{number} - НЕ палиндром");
}
}