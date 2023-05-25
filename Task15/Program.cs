// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите номер дня недели (от 1 до 7)");
int number = int.Parse(Console.ReadLine());
while(number > 7 || number<1 ) // && - это и || - это или
{
    Console.WriteLine("В неделе всего 7 дней");
    Console.WriteLine("Введите число от 1 до 7");
    number = int.Parse(Console.ReadLine());

} 
string [] Week = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};  
if (number==6||number==7)
     Console.WriteLine($"{number} день недели ({Week[number-1]}) это выходной");
else
    Console.WriteLine($"{number} день недели ({Week[number-1]}) не является выходным");
