using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Queue<customer> cus = new Queue<customer>();
		customer c1 = new customer();
		c1.FirstName = "John ";
		c1.LastName = "Smith";
		cus.Enqueue(c1);
		customer c2 = new customer();
		c2.FirstName = "Sally";
		c2.LastName = "Jones";
		cus.Enqueue(c2);
		customer c3 = new customer();
		c3.FirstName = "Ricky";
		c3.LastName = "Jones";
		cus.Enqueue(c3);
		customer c4 = new customer();
		c4.FirstName = "Mithila";
		c4.LastName = "Jones";
		cus.Enqueue(c4);
		customer c5 = new customer();
		c5.FirstName = "Polito";
		c5.LastName = "Jones";
		cus.Enqueue(c5);

		table t = new table();

	}
}


// Step 3 - Declaring the code for the event
public class table
{
	public event tableOpenEventHandeler tb;
	public void open()
	{
		if(tb!= null)
		{
			tb(this, new tableopen());
		}
	}
}

// Step 2 - Setting up the delegate for the event
public delegate void tableOpenEventHandeler(object source, tableopen e);
public delegate void nextmealEventHandler(object source, customer c);


// Step 1 - Creating a class to pass arguments for the event handlers 


public class tableopen : EventArgs
{
	public tableopen()
		{
	Console.WriteLine(" Table is open");
		}
}
public enum meals
{
	none,
	appetizer,
	main, desert,
	done

}
public class customer
{
	
	public String FirstName
	{ get; set; }
	public String LastName
	{get;set;}
	
	public meals meal
	{
		get;set;
	}


	public void handleEventtableopen(String FName,String LName)
	{
		this.FirstName=FName;
		this.LastName = LName;
		Console.WriteLine("{0} {1} got a table.", this.FirstName, this.LastName);
	}


}