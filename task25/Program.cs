// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Enter first number");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int B = Convert.ToInt32(Console.ReadLine());
int product = 1;
for (int i = 0; i < B; i++)
{
    product *= A;
}
Console.WriteLine(product);