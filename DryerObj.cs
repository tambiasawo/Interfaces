namespace PROGWITHMOSH_INTERMEDIATE
{
    class DryerObj
    {
        public static ILaundryDevice device()
        {
            return new Dryer();
        }
    }
}
