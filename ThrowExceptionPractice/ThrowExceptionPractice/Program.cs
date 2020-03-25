using System;
					
public class Program
{
	public static void Main()
	{
		// create a new instance of the Person class
		Person person = new Person();
		
		// the Age 'set' is called when assigning a property value
		person.Age = 13;
		
		// the Age 'get' is called when accessing a property value
		Console.WriteLine("This person's age is: {0}", person.Age);
	}
}

public class Person
{
    private int _age;

    // public property with a get and set accessors
    public  int Age
    {
        get
        {
            return _age; // return the value of the private variable _age 
        }
        set
        {
            if (value > 0)
            {
                _age = value; // set the value of the private variable _age
            }

            else
            {
                throw new Exception("Cannot assign age < 0 value");
            }
        }
    }
}