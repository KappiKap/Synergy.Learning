Console.WriteLine("How many numbers do you want to see in array?");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
decimal GoodNumbers = 0;
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-50,50);
    if (array[i] > -15 & array[i] < 15)
    {
        GoodNumbers++;
    }
}
Console.WriteLine(GoodNumbers);

Console.WriteLine(GoodNumbers / Convert.ToDecimal(x) * 100);
