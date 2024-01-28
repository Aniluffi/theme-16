Console.Write("Введите дату рождения:\n");

Console.Write("Введите год:");
int year = int.Parse(Console.ReadLine());

Console.Write("Введите месяц:");
int month = int.Parse(Console.ReadLine());

Console.Write("Введите день:");
int day = int.Parse(Console.ReadLine());

DateTime birthDay = new DateTime(year,month,day);
DateTime now = DateTime.Now;

int nowYears = now.Year;

if (now.Month - month < 0) 
{
  nowYears--;
    Console.WriteLine($"Тебе {nowYears - year} лет");
}else if(now.Month - month > 0)
{
    Console.WriteLine($"Тебе {nowYears - year} лет");
}

