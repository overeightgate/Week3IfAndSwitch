
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Pühapäev");
}

else if (weekDay == 1)
{
    Console.WriteLine("Esmaspäev");
}

   
