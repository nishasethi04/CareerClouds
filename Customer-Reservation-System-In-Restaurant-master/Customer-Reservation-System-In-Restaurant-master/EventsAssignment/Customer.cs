using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAssignment
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public Meals currentMeal;
        public Meals Meal
        {
            get;set;
        }
        public void HandleTableState(object sender, EventArgs e)
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} got a table");
        }
        public delegate void MealSwitchedEventHandler(object source, MealEventArgs args);

        public event MealSwitchedEventHandler MealSwitchedEvent;
         
      public  void OnMealChanged()
        {
            if (MealSwitchedEvent != null)
            {
                MealSwitchedEvent(this, new MealEventArgs(this.FirstName, this.LastName, this.Meal));
            }
        }
    }
    public class MealEventArgs : EventArgs
    {
        public string firstName;
        public string lastName;
        public Meals meal;
        public MealEventArgs(string firstName, string lastName, Meals meal)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.meal = meal;
        }
    }
}
