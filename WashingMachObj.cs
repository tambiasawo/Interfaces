namespace PROGWITHMOSH_INTERMEDIATE
{
    class WashingMachObj
    {
        public static ILaundryDevice device()
        {
            return new WashingMac();
        }
    }
}
