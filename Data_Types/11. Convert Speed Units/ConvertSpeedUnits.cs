using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSec = seconds + mins * 60f + hours * 3600f;
            float metersPerSec = distanceInMeters / timeInSec;
            float timeInHours = hours + mins / 60f + seconds / 3600f;
            float distanceInMiles = distanceInMeters / 1609f;
            int distanceInKm = distanceInMeters / 1000;
            float kmPerHour = distanceInKm / timeInHours;

            float milesPerHour = distanceInMiles / timeInHours;

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);



        }
    }
}