using System;

namespace tugas_class_dan_object
{
    public class taxi1
    {
        public string drivername;
        public bool onduty;
        public int numpassenger;

        public void taxiinfo()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("| driver name  :{0}|", drivername);
            Console.WriteLine("|on duty       : {0} |", onduty);
            Console.WriteLine("|number of passenger : {0} |", numpassenger);

        }

        public void pickuppassenger()
        {
            Console.WriteLine(" ");
            Console.WriteLine("{0}sedang menjemput penumpang", drivername);
        }
        public void dropoffpassenger()
        {
            Console.WriteLine("{0}selesai mengantar penumpang", drivername);
        }



    }
}
