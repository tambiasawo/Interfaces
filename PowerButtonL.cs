namespace PROGWITHMOSH_INTERMEDIATE
{
    class PowerButtonL : IPowButton
    {
        ILaundryDevice mach;
        public PowerButtonL(ILaundryDevice mach)
        {
            this.mach = mach;
        }

        public void ExecuteOff()
        {
            mach.Off();
        }

        public void ExecuteOn()
        {
            mach.On();
        }
    }
}
