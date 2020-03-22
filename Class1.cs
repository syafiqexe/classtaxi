using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_class_dan_object
{
    public class Class1
    {
        static void Main(string[] args)
        {
            taxi1 taxi = new taxi1();

            taxi.drivername = "joko";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.taxiinfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();

            Console.ReadKey();
        }
    }
}
