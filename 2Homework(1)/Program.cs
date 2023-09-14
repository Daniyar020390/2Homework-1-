// See https://aka.ms/new-console-template for more information
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
void DeleteSecondDigit (int num)
            {
               int firstDigit = num/100;
                int thirdDigit = num%10;
                int number1 = firstDigit * 10 + thirdDigit;
                System.Console.WriteLine(number1);
            }
            DeleteSecondDigit (number);
