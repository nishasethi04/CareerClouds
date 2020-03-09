using System;
namespace AlarmclockEvent
{
	public class Program
	{
		public static void Main()
		{
			//Step 5 - Associate the event with the handler
			var person = new Person();
			person.name = "Joe Smith";

			var alarm = new AlarmClock();
			alarm.AlarmClockEvent += person.HandleAlarm;

			//Step 6 - Causing the event to occur
			alarm.Alarm();
		}
	}

	// Step 4 - Creating code that should occur when the event happens
	public class Person
	{
		public string name { get; set; }

		public void HandleAlarm(object sender, AlarmClockEventArgs e)
		{
			Console.WriteLine("Get out of bed it's {0}", e.time);
		}

	}

	// Step 3 - Declaring the code for the event
	public class AlarmClock
	{
		public event AlarmClockEventHandeler AlarmClockEvent;

		public void Alarm()
		{
			Console.WriteLine("Alarm went off!");
			AlarmClockEventHandeler alarm = AlarmClockEvent;
			if (AlarmClockEvent != null)
			{
				alarm(this, new AlarmClockEventArgs(DateTime.Now));
			}

		}
	}

	// Step 2 - Setting up the delegate for the event
	public delegate void AlarmClockEventHandeler(object source, AlarmClockEventArgs e);


	// Step 1 - Creating a class to pass arguments for the event handlers 	
	public class AlarmClockEventArgs : EventArgs
	{
		public DateTime time { get; set; }
		public AlarmClockEventArgs(DateTime time)
		{
			this.time = time;

		}
	}
}