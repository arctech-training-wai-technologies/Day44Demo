using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day44Demo
{
    public class ExceptionHandlingSample
    {
        /// <summary>
        /// simple code to demostrate exception - inde out of range
        /// </summary>
        public void Sample1()
        {
            Console.WriteLine("Start of code");

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(arr[7]);

            Console.WriteLine("End of code");
        }

        /// <summary>
        /// Exception handling with try and catch
        /// </summary>
        public void Sample2()
        {
            Console.WriteLine("Start of code");

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine(arr[7]);

                Console.WriteLine("Some code after exception");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An exception has occured {0}", ex.Message);
            }

            Console.WriteLine("End of code");
        }

        /// <summary>
        /// try with multiple catch
        /// </summary>
        public void Sample3()
        {
            Console.WriteLine("Start of code");
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            try
            {
                Console.WriteLine(arr[7]);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / i);
                }
                
            }            
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index exception - {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero  - {0}  ", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Base exception raised {0}", ex.Message);
            }

            Console.WriteLine("End of code");
        }

        /// <summary>
        /// demo - throw exception manually
        /// </summary>
        public void Sample4()
        {
            try
            {
                ValidateAge(12);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Exception caught in consumer - {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally called");
            }
        }
        public static void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age must be more than 18");

            Console.WriteLine("This line never gets executed if age less than 18");
        }

        /// <summary>
        /// Finally example
        /// </summary>
        public void Sample5()
        {
            //fun1();
            try
            {
                fun2();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception caught in Sample5");
            }
        }

        public static void fun1()
        {
            try
            {
                Console.WriteLine("inside fun1 first line");
                return;
            }
            finally
            {
                Console.WriteLine("inside fun1 last line");
            }
        }

        public static void fun2()
        {
            try
            {
                Console.WriteLine("inside fun2 first line");
                throw new Exception("Throwing exception");
            }
            finally
            {
                Console.WriteLine("inside finally of fun2");
            }
        }
    }

    /// <summary>
    /// user defined exception
    /// </summary>
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message) { }
    }
}
