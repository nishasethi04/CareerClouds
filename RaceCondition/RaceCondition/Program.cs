using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            someclass some = new someclass();

            //some.someint++;
            //Console.WriteLine(some.someint);

                List<Task> list = new List<Task>();
                list.Add(Task.Run(() =>
                {

                    for (int i = 0; i < 3; i++)
                    {
                        //int y = some.someint;
                        lock(some)
                        {
                            //y++;
                            some.someint++;
                        }
                    // Thread.Sleep(10);
                        
                        Console.WriteLine("In 1");
                      //  some.someint = y;

                    }
                })) ;
                list.Add(Task.Run(() =>
                {
                    for (int i = 0; i < 3; i++)
                    {
                       // int y = some.someint;
                        lock (some)
                        {
                            //   y++;
                            some.someint++;
                        }
                       //Thread.Sleep(10);
                        Console.WriteLine("In 2: ");
                        //some.someint = y;
                    }



                }));
                Task.WaitAll(list.ToArray());
                Console.WriteLine($"This is someint:{some.someint}");
            }
        
    }

        public class someclass
        {
            public int someint;

        }
    
}
