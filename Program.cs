//int num1 = 8;
//int num2 = 16;
//if (num1 > num2)
//{
// Console.WriteLine($"The number {num1} is greater then {num2}");
//}
//else
//{
// Console.WriteLine($"The number {num2} is greater then {num1}");
//}

//using System.ComponentModel.Design;

//Console.Write("Enter the number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 0)
//{
   // Console.WriteLine($"Positive number {number}");
//}
//else if (number < 0)
//{
    //Console.WriteLine($"Negative number {number}");
//}
//else
//{
    //Console.WriteLine($"Zero {number}");
//}

//Console.Write("Enter your age:");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age < 13)
//{
    //Console.WriteLine("Child");
//}
//else if (age == 13 & age < 19)
//{
    //Console.WriteLine("Teenager");
//}
//else if (age == 20 &  age < 59)
//{
    //Console.WriteLine("Adult");
//}
//else
//{
    //Console.WriteLine("Above");
//}

//EXERCISE NUMBER 1
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine("The second number is bigger then first number");
}
else if (num1 > num2)
{
    Console.WriteLine("The first number is bigger then second number ");
}
else
{
    Console.WriteLine("They equally");
}

//EXERCISE NUMBER 2
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5 & num < 10)
{
    Console.WriteLine("The number is greater than 5 and less than 10");
}
else
{
    Console.WriteLine("Unknown number");
}


//EXERCISE NUMBER 3
Console.Write("Enter number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 == 5 | num3 == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else
{
    Console.WriteLine("Unknown number");
}

//EXERCISE NUMBER 4 AND 5
Console.Write("Enter the deposit amount: ");
double D = Convert.ToDouble(Console.ReadLine());
double result;
if (D < 100) 
{
    result = (D + (D * 5 / 100)) + 15;
    Console.WriteLine($"The deposit amount 5% .The summa with deposit {result}");
}
else if (D >= 100 & D <= 200)
{
    result = (D + (D * 7 / 100)) + 15;
    Console.WriteLine($"The deposit amount 7% .The summa with deposit {result}");
}
else if (D > 200)
{
    result = (D + (D * 10 / 100)) + 15;
    Console.WriteLine($"The deposit amount 10% .The summa with deposit {result}");
}

//EXERCISE NUMBER 6 AND 7
Console.Write("Enter operation number: ");
int opetation = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num6 = Convert.ToInt32(Console.ReadLine());
int Summa;
switch (opetation)
{
    case 1:
        Summa = num5 + num6;
        Console.WriteLine($"1.Addition.The addition is {Summa}");
        break;
    case 2:
        Summa = num5 - num6;
        Console.WriteLine($"2.Subtraction.The subtraction is {Summa}");
        break;
    case 3:
        Summa = num5 * num6;
        Console.WriteLine($"3.Multiplication.The multiplication is {Summa}");
        break;
    default:
        Console.WriteLine("the operation is undefined");
        break;
}


