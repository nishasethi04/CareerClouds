using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (DbModelContainer db = new DbModelContainer())
            {

                Console.WriteLine(" ENter First name");
                Member m = new Member();

                    m.FName=Console.ReadLine();
                Console.WriteLine(" ENter Last name");
                m.LName = Console.ReadLine();
                db.Members.Add(m);
                db.SaveChanges();
                Console.WriteLine("Enter Game Title");
                Game gm = new Game();
                gm.GameTitle = Console.ReadLine();
                Console.WriteLine("Enter Game Price");
                gm.Price = Console.ReadLine();
                db.Games.Add(gm);
                db.SaveChanges();

                
            }
            using(DbModelContainer db=new DbModelContainer())
            {

                foreach(Member m in db.Members)
                {
                    Console.WriteLine($"{m.Id}-{m.FName}-{m.LName}");
                }
                foreach (Game m in db.Games)
                {
                    Console.WriteLine($"{m.Id}-{m.GameTitle}-{m.Price}");
                }
            }
            Console.ReadKey();
            
        }
    }
}
