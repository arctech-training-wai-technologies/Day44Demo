using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day44Demo
{
    public class ContainsSample
    {
        public void Demo()
        {
            house h = new house();
            //h.fanHouse.
        }
    }

    public class Fan
    {
        public string model;
    }

    public class Ceiling 
    {
       
    }

    public class house
    {
        private Fan fan;
        private Ceiling ceiling;

        public house()
        {
            fan = new Fan();
            ceiling = new Ceiling();
        }

        public void ShowFanModel()
        {
            Console.WriteLine(fan.model);
        }

        public Fan fanHouse
        {
            get
            {
                return fan;
            }
        }

    }
}
