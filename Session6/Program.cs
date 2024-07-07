

using System.Reflection;

namespace Session6

{     public enum Grades
    {
        A, B, C, D, E, F
     }
    enum Roles
    {
        Admin = 10,
        Editor = 20,
        Viewer = 30
    }

    class Employee
    {
        string Name; // Varchar
        int Age; // int
        double Salary; // double
        //Gender Gender; // int 0-1
        Roles Role; // Admin – Editor – Viewer
    }

    enum branches :byte // 8bites => 0:255
    {
        Dokki , NaseCity , Maddi , ALex , SmartVillage , cairo 
    }



    internal class Program
    {

        //static void DoSomeProtectiveCode()
        //{
        //    int X, Y, Z;
        //    bool Flag;

        //    // Loop until a valid integer is entered for X
        //    do
        //    {
        //        Console.WriteLine("Enter First Number:");
        //        Flag = int.TryParse(Console.ReadLine(), out X);
        //    } while (!Flag);

        //    // Loop until a valid integer is entered for Y and Y is not zero
        //    do
        //    {
        //        Console.WriteLine("Enter Second Number:");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);
        //    } while (!Flag || Y == 0);

        //    Z = X / Y;

        //    // Demonstrating System.NullReferenceException
        //    int[] Numbers = null; // System.NullReferenceException
        //    if (Numbers?.Length > 10)
        //    {
        //        // Numbers = null => Numbers?.Length = null
        //        // Numbers != null => Numbers?.Length = Length
        //        Numbers[10] = 100;
        //    }
        //}
        static void Main(string[] args)
        {
            //try
            //{
            //    DoSomeProtectiveCode(); // Runtime Errors (Exceptions)
            //    throw new Exception(); // Throwing a new exception manually
            //}
            //catch (Exception ex)
            //{
            //    // If any exception happened in the try block
            //    // CLR will create an object from the class of exception
            //    // and pass it to the catch block
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("After `Try Catch");



            #region Acces Modifiers

            //TypeA obj = new TypeA(); //valid
            //TypeB obj2 = new Common.TypeB(); // Invalid [Internal]
            // 'TypeB' is inaccessible due to its protection level
            #endregion

            #region Enum 
            #region Ex01

            Grades x = Grades.A;
            Grades y = (Grades)2;
            Grades z = (Grades)10;

            Console.WriteLine(y); // Explicit casting 
            Console.WriteLine(z); // Explicit casting // there is no lable match 10



            if (x == Grades.A)
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }

            #region Ex 02
            Console.WriteLine("Please Enter Your Grade");
            //Grades k = (Grades) Enum.Parse(typeof(Grades) , Console.ReadLine()); //worst way beacuse there is alot of boxing and unboxing and it is not safe way to use parse so we will use try parse.
           bool result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object k); //Tryparse issues :1- there is alot of boxing and unboxing  2-when it is false it will return value which is null
            Console.WriteLine($"Your result is {result}");
            Console.WriteLine(k);


            #endregion








            #endregion




            #endregion









        }
    }
}
