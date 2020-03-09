using System;

namespace INClassAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum meals
    {
        none,
        appetizer,
        main,
        desert, done


    }
    class customer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public meals meal { get; set; }
        
            
              
    }
    
    public class tableeventargs:EventArgs
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public tableeventargs(string fname,string lname)
        {
            this.firstname = fname;
            this.lastname = lastname;
          
        }
    }
    public class table 
    {
        
        public event EventHandler<tableeventargs> tableopen;
        public void tableavailable(string fname,string lname )

        {
            if(tableopen!=null)
            {
                tableopen(this, new tableeventargs(fname, lname));
            }

        }

        }
}
