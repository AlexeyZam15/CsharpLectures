using System.Globalization;
using System;
using System.Security.AccessControl;
using System.Linq;
// var a = 12;
// Console.WriteLine(a.GetType());

// var data = new int[] { 1, 2, 3, 4 }
//         .Where(e => e > 0)
//         .Select(e => new { q = e, w = e + 1 });
// Console.WriteLine(data.GetType());

// void Drawtext(string text, int left, int top)
// {
//     Console.SetCursorPosition(left, top);
//     Console.WriteLine(text);
// }

// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeight / 2;

// Drawtext(caption, screenWidthPosition, screenHeightPosition);

// Random r = new Random();

// ConsoleColor GetRandomConsoleColor()
// {
//     var consoleColors = Enum.GetValues(typeof(ConsoleColor));
//     return (ConsoleColor)consoleColors.GetValue(r.Next(consoleColors.Length));
// }

// Console.CursorVisible = false;
// while (true)
// {
//     Console.SetCursorPosition(r.Next(Console.WindowWidth),
//                              r.Next(Console.WindowHeight));
//     Console.Write(r.Next(10));
//     // Console.ForegroundColor = GetRandomConsoleColor();
// //     Thread.Sleep(1000);
// }

// string text = "(1,2) (2,3) (4,5) (6,7)"
//                 .Replace("(", "")
//                 .Replace(")", "")
//                 ;
// Console.WriteLine(text);

// var data = text.Split(" ")
//                 .Select(item => item.Split(','))
//                 .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
//                 .Where(e => e.x % 2 == 0)
//                 .Select(point => (point.x * 10, point.y))
//                 .ToArray();

// for (int i = 0; i < data.Length; i++)
// {
//     Console.WriteLine(data[i]);
// }

// Собрать строку с числами от a до b, a <= b
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// // string NumbersRec(int a, int b)
// // {
// //     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
// //     else return String.Empty;
// // }

// string NumbersRec(int a, int b)
// {
//     a++;
//     if (a <= b) return $"{a-1} " + NumbersRec(a, b);
//     else return $"{a-1} ";
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// Собрать строку с числами от a до b, a >= b
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a >= b) return $"{a} " + NumbersRec(a - 1, b);
//     else return String.Empty;

// }

// Console.WriteLine(NumbersFor(10, 1));
// Console.WriteLine(NumbersRec(10, 1));

// Сумма чисел от 1 до n
// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//         result += i;
//     return result;
// }
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n-1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Факториал числа
// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//         result *= i;
//     return result;
// }

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// Вычислить a в степени n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//         result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

//Перебор слов
// for
// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
//     for (int j = 0; j < count; j++)
//         for (int k = 0; k < count; k++)
//             for (int l = 0; l < count; l++)
//                 Console.Write(@$"
//                 {n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//Рекурсия
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}");
//         return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         Console.WriteLine($"{length} {word[length]} {i} {alphabet[i]}");
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[4]);