//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Write("Введите 3 числа:");
Console.Write("a:");
int num_a = int.Parse(Console.ReadLine());
Console.Write("b:");
int num_b = int.Parse(Console.ReadLine());
Console.Write("c:");
int num_c = int.Parse(Console.ReadLine());
int max = num_a;
if(num_b>max){
    max = num_b;
}
if(num_c>max){
    max = num_c;
}
    Console.WriteLine($"Наибольшее число {max}");