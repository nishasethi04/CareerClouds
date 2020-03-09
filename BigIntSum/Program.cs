using System;

namespace BigIntSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Big b = new Big();
            long s = b.sum();
            Console.WriteLine("Sum={0}",s);

        }

    }
    class Big
    {
       public  long [] ar = new long[5];
                public  long sum()
        {
             long s = 0;
            ar[0] = 1000000001;
            ar[1] = 1000000002;
            ar[2] = 1000000003;
            ar[3] = 1000000004;
            ar[4] = 1000000005;
            
            for(int i=0;i<5;i++)
            {
                s = (long)s + (long)ar[i];
                
            }
            return s;
        }
    }
}
