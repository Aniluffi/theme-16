class Programm
{ 
    public static 
        void Main(string[] args)
    {
        //1
        DateTime time = new DateTime(2006,8,8);
        DateTime time2 = DateTime.Now;

        int difDay = 0;
        int i = time.Year;
        do
        {
            if (DateTime.IsLeapYear(i) == true & i != time2.Year) difDay += 366;
            else if (DateTime.IsLeapYear(i) == false & i != time2.Year) difDay += 365;
            if (i == time2.Year - 1 & i != time2.Year) difDay = difDay - time.DayOfYear + time2.DayOfYear;
            if (i == time2.Year) difDay += time2.DayOfYear - time.DayOfYear;
            i++;
        } while (i < time2.Year);
        Console.WriteLine($"Разница между дыумя датами - {difDay}");
        //2
        Console.WriteLine(DateTime.DaysInMonth(time.Year,time.Month) - time.Month + " осталось до конца месяца");

        //a). день недели, в котором вы родились;
        Console.WriteLine($"день недели - {time.DayOfWeek}");
        //b). порядковый номер дня рождения в году;
        Console.WriteLine($"порядковый номер дня рождения в году - {time.DayOfYear}");
        //c). является ли ваш год рождения високосным;
        Console.WriteLine($" является ли ваш год рождения високосным - {DateTime.IsLeapYear(time.Year)}");
        //d). дату ближайшего дня рождения(формат вывода: среда, 11 января 2023);
      
        //e). количество полных лет;
        int year = difDay / 365;
        int week = (difDay - year * 365) / 7;

        Console.WriteLine($"количество полных лет - {year} лет {week} недель");
        //f)сколько дней осталось от сегодняшней даты до вашего ближайшего
        //дня рождения (если день рождения сегодня, то вывести 0)
        DateTime now = DateTime.Now;
        DateTime bDay = new DateTime(now.Year, 8, 8);

        Console.WriteLine($"сколько дней осталось от сегодняшней даты до вашего ближайшего " +
            $"дня рождения - {bDay.DayOfYear - now.DayOfYear} ");
    }
}

