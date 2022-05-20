using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day44Demo
{
    //Extension methos must be under a static class
    //the first parameter is called - binding parameter
    //the binding parameter should be of the class type to which the method is bound
    //prefix binding parameter with this keyword
    public class ExtensionSample
    {
        public void Demo()
        {
            string str;
            Console.WriteLine("Enter a sentence");
            str = Console.ReadLine();

            //string lastword = Utility.LastWord(str);

            Console.WriteLine(str.LastWord());

            string para = "something new we learn";
            Console.WriteLine(para.LastWord());
        }

        
    }
    
    public static class Utility
    {
        public static string LastWord(this string str)
        {
            return str.Trim().Split(' ').LastOrDefault().Trim();
        }
    }

}
