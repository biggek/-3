Console.Write("Введите сумму вклада: ");
decimal Sum = decimal.Parse(Console.ReadLine());
Console.Write("Введите количество лет: ");
int year = int.Parse(Console.ReadLine());
 
int x = 1;
 
while (x <= year)
{
  if (Sum < 100)
  {
    Sum = Sum + (Sum * (decimal)0.05);
  }
  if ((Sum > 100) && (Sum < 200))
 {
    Sum = Sum + (Sum * (decimal)0.07);
  }
  if (Sum > 200)
  {
        Sum = Sum + (Sum * (decimal)0.1);
  }
 
  x++;
}
 
Console.WriteLine($"Cумму вклада с начисленными процентами за {year} лет составит: {Sum}");
Console.ReadKey();