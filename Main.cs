public class Main1
{
    public static void Main(string[]args)
    {
        ILaundryDevice device = WashingMachObj.device();

        PowerButtonL button = new PowerButtonL(device);
        button.ExecuteOn();
        button.ExecuteOff();

        ILaundryDevice deviceD = DryerObj.device();

        PowerButtonL buttonD = new PowerButtonL(device);
        buttonD.ExecuteOn();
        buttonD.ExecuteOff();
    }
}