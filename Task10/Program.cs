// See https://aka.ms/new-console-template for more information
Console.Clear();
System.Console.WriteLine("Введите трехзначное число");
int Number = int.Parse(Console.ReadLine());
int Num1 = Number/100, Num3= Number%10, 
Num2 = (Number-100*Num1-Num3)/10; 
Console.WriteLine(Num2);
