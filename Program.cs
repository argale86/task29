// создать массив из 8 случайных чисел и вывести на экран
int numbermas = 8;
int[] mas = new int[numbermas];
Random rnd = new Random();
for (int count = 0; count < numbermas;count++)
{
    mas[count] = rnd.Next(0, 32654);
}
for (int count = 0; count < numbermas;count++)
{
    Console.WriteLine("Элемент массива = " + mas[count]);
}


