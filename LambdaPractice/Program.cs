using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // instantiate listeners
        Police police = new Police();
        Fire fire = new Fire();
        Ambulance ambulance = new Ambulance();

        // instantiate broadcaster
        Call911 c911 = new Call911();

        // attach broadcaster (call911) to listners (police, ambulance, fire)
        c911.CallForHelp += police.OnCallTo911;
        c911.CallForHelp += fire.OnCallTo911;
        c911.CallForHelp += ambulance.OnCallTo911;

        //call to 911
        c911.createNotification("250 Humber Blvd.  - John Hinz - HELP - Crazy Students!!!!! ");

        Console.ReadLine();

    }
}

public class Police
{
    // police listner - signature must match event and delegate
    public void OnCallTo911(object sender, EmergencyInfo e)
    {
        Console.WriteLine("There is a Police call from " + e.address);
    }

}
public class Fire
{
    // Fire listner - signature must match event and delegate
    public void OnCallTo911(object sender, EmergencyInfo e)
    {
        Console.WriteLine("There is a Fire call from " + e.address);
    }

}
public class Ambulance
{
    // Ambulance listner - signature must match event and delegate
    public void OnCallTo911(object sender, EmergencyInfo e)
    {
        Console.WriteLine("There is a Ambulance call from " + e.address);
    }

}

public class Call911
{
    // Call911's event
    public event EmergencyEvent CallForHelp;


    // a call to this method will notify listeners of the event
    public void createNotification(string msg)
    {
        // check to see if anyone is listening
        if (CallForHelp != null)
        {
            CallForHelp(this, new EmergencyInfo(msg));
        }
    }
}

// delegate for the event's signature
public delegate void EmergencyEvent(object sender, EmergencyInfo e);

// event information (holds address passed to listeners)
public class EmergencyInfo : EventArgs
{
    public string address { get; set; }
    public EmergencyInfo(string Address)
    {
        address = Address;
    }
}
