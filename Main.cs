public class Main1
{
    public static void Main(string[]args)
    {
        // creating a Laundry device machine object and initializing it to a washer object
        ILaundryDevice device = WashingMachObj.device();

        // passing in the washer object to the PowerButton class
        PowerButtonL button = new PowerButtonL(device);
        // turning it on and off
        button.ExecuteOn();
        button.ExecuteOff();

        // creating a Laundry device machine object and initializing it to a dryer object
        ILaundryDevice deviceD = DryerObj.device();
        
        // passing in the DRYER object to the PowerButton class 
        PowerButtonL buttonD = new PowerButtonL(device);
        // turning it on and off
        buttonD.ExecuteOn();
        buttonD.ExecuteOff();
    }
}
