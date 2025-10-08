// See https://aka.ms/new-console-template for more information

int[] numbers = new int[5];
numbers[0] = 63;
numbers[1] = 64;
numbers[2] = 65;            // mozes zapisat aj: int[] numbers = {63, 64, 65, 66, 67}; 
numbers[3] = 66;
numbers[4] = 67;
int index = 0;

while (index < 5)
{
    Console.WriteLine(numbers[index]);
    index++;
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int i in numbers)
{
    Console.WriteLine(numbers);
}

