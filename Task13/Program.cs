// See https://aka.ms/new-console-template for more information
Console.Clear();
System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
int Div = Num, count = 1, index = 0;
int[] array = new int[10];
while (Div/10>0||Div/10<0)
{
    array[index] = Div%10;
    Div=Div/10;
    count = count + 1;
    index++;    
}
if (count<3)
System.Console.WriteLine($"В числе {Num} третьей цифры нет");
else
System.Console.WriteLine($"3 слева цифра в числе {Num} -> {array[index-2]}");
