using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day44Demo
{
    public class Point : IDisposable
    {
        int x;
        int y;
        public Point()
        {
            x = 0;  
            y = 0;
            Console.WriteLine("Constructor called");
        }
        ~Point() //Destructor
        {

        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called");
        }
    }
    public class DisposeSample
    {
        public void Demo()
        {
            using Point point = new Point();
        }
    }
}
