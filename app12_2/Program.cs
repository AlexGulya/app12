DayTime now = DayTime.Evening;

PrintMessage(now);
PrintMessage(DayTime.Afternoon);
PrintMessage(DayTime.Morning);
PrintMessage(DayTime.Evening);

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Good morning");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Good afternoon");
            break;
        case DayTime.Evening:
            Console.WriteLine("Good evening");
            break;
        case DayTime.Night:
            Console.WriteLine("Good night");
            break;
        
            
    }
}




enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}