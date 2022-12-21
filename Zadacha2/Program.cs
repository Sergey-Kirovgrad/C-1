//программа, которая на вход принимает два числа и выдаёт, 
//какое число больше.
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"{a}");
}else
{
    Console.WriteLine($"{b}");
}