Console.Write("Сколько тебе лет? - ");
int year = int.Parse(Console.ReadLine());

DateTime nowTime = DateTime.Now;

Console.WriteLine($"Вы роделись в {nowTime.AddYears(year - year - year).Year} году");