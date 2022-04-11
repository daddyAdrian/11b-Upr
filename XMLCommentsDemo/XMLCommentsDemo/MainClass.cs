using System;

namespace XMLCommentsDemo
{
        ///<summary>
        ///  MainClass is a sample illustrating how to use XML documentation in C#.
        ///</summary>
    class MainClass
    {
        ///<summary>Calculates the square of a number</summary>
        ///<param name = "num" > The number to calculate</param>
        ///<returns>The calculated square</returns>
        ///<exception cref = "T:System.OverflowException" > Thrown when the result is too big to be stored in an int</exception>
        ///<seealso cref = "T:System.Int32" />
        public static int Square(int num)
        {
            checked
            {
                return num * num;  
            }
        }
        ///<summary>
        ///  The main entry point for the application
        ///</summary>
        ///<param name = "args" > The command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("3*3 = " + Square(3));
        }
    }
}
