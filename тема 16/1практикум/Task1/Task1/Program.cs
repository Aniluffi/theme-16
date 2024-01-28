
DateTime one = DateTime.Now;
Console.WriteLine($"Текущая дата:\n" +
    $"{one.ToString("d")}\n" +
    $"{one.ToString("d MMM yyyy")}\n" +
    $"{one.ToString("D")}\n" +
    $"{one.DayOfWeek},{one.ToString("d MMM yyyy")}\n\n" +
    $"Текущее время:\n" +
    $"{one.ToString("T")}\n" +
    $"{one.ToString("t")}\n\n" +
    $"Текущая дата и время:\n" +
    $"{one}\n" +
    $"{one.ToString("f")}\n" +
    $"{one.ToString("F")}\n" +
    $"{one.ToString("R")}\n" +
    $"{one.ToString("s")}\n");
   