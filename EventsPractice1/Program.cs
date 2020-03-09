using System;

namespace EventsPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 5 - Associate the event with the handler
            var person = new Person();
            person.name = "Joe Smith";

            var alarm = new AlarmClock();
            alarm.AlarmClockEvent += person.HandleAlarm;
        }
      

        public class ALarmclock
        {
            public event AlarmclockEventhandler alarmclockevent;
            public void Alarm()
            {
                Console.WriteLine("Alarm went off!");
                AlarmclockEventhandler alarm = alarmclockevent;
                if (alarm != null)
                {
                    alarm(this, new AlarmclockEvent(DateTime.Now));
                }

            }
            public delegate void AlarmclockEventhandler(object sender, AlarmclockEvent e);
            public class AlarmclockEvent : EventArgs
            {
                public DateTime time { get; set; }
                public AlarmclockEvent(DateTime d)
                {
                    this.time = d;
                }
           
           }
            // Step 4 - Creating code that should occur when the event happens
            public class Person
            {
                public string name { get; set; }

                public void HandleAlarm(object sender, AlarmclockEvent e)
                {
                    Console.WriteLine("Get out of bed it's {0}", e.time);
                }

            }

        }
    }
}
