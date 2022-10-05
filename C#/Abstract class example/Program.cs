using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_console
{
    class Program
    {
        static void Main(string[] args)
        {
            car Car = new customer();
            Car.ownername = "Ravi";
            Car.currentowner(Car.ownername);
            Car.price();
            Console.ReadKey();
        }
    }

    abstract class car
    {
        public abstract string ownername { get; set; }
        public void number()
        {
            Console.Write("hello customer {0} happy to welcome our valuble customer.\n\n",ownername);
        }
        public abstract void currentowner(string ownerName);
        public abstract void price();
   
    }
    class customer : car
    {
        public override string ownername { get; set ; }
        public override void currentowner(string ownerName)
        {
            ownername=ownerName;
            base.number();
            Console.WriteLine("Current owner name: {0}",ownername);
            
        }
        public override void price()
        {
            Console.WriteLine("Price: 6.74 lakhs");
        }
    }
}
