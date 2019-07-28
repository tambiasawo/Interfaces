namespace PROGWITHMOSH_INTERMEDIATE
{
    class WashingMac : ILaundryDevice
    {
        public int time { get; set; }
        
        public void Off()
        {
           
            System.Console.WriteLine("Washing Machine is off");

        }

        public void On()
        {
            System.Console.WriteLine("Washing Machine is on");
        }

        public void Start()
        {
            System.Console.WriteLine("Washing Machine has started");
        }

        public void Stop()
        {
            System.Console.WriteLine("Washing Machine has stopped");
        }

        public void Timer()
        {
            time++;
            System.Console.WriteLine("Timer started at: {0}", time);
        }
    }
}
