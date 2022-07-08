// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
/* Console.WriteLine("Enter number");
//int number = Convert.ToInt32(Console.ReadLine());
string str = Console.ReadLine();
 */
string str = string.Empty;
int number = 0;
while(!int.TryParse(str, out number))
{
    Console.WriteLine("Enter number");
    str = Console.ReadLine();
}
int sum = 0;
while (number != 0)
{
    sum += number % 10;
    number /= 10; 
}
Console.WriteLine(sum);