using System.Linq;

double[] array = new double[] {13.25, 15, 30, 1.5};
double totalPayment;
string begin = "";
string end = "";

if(array[0].ToString().Contains('.'))
{
    begin = array[0].ToString();

}
else
{
    begin = array[0].ToString();
    begin += ".00";

}

if(array[1].ToString().Contains('.'))
{
    end = array[1].ToString();

}
else
{
    end = array[1].ToString();
    end += ".00";
}

string[] beginArray = begin.Split(".");
string[] endArray = end.Split(".");

TimeSpan beginTime = new TimeSpan(int.Parse(beginArray[0]), int.Parse(beginArray[1]), 0);
TimeSpan endTime = new TimeSpan(int.Parse(endArray[0]), int.Parse(endArray[1]), 0);

if(endTime.Hours < 17)
{
    TimeSpan totalWorkingHour = endTime - beginTime;
    totalPayment = (totalWorkingHour.Hours * array[2]) + (totalWorkingHour.Minutes * array[2] / 60);

} else
{
    TimeSpan overTime = new TimeSpan(17, 0, 0);
    TimeSpan totalWorkingHour = overTime - beginTime;
    TimeSpan totalExtraWorkingHour = endTime - overTime;
    totalPayment = (totalWorkingHour.Hours * array[2]) + ((totalWorkingHour.Minutes * array[2]) / 60) + (totalExtraWorkingHour.Hours * array[2] * array[3]) + ((totalExtraWorkingHour.Minutes * array[2] * array[3]) / 60);


}
    
Console.WriteLine($"Begin time is {begin}, end time is {end}, total payment is {totalPayment}");


